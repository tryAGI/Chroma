#!/usr/bin/env bash
set -euo pipefail

script_dir="$(cd -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd)"
cd "${script_dir}"

dotnet tool install --global autosdk.cli --prerelease

openapi_host="${CHROMA_OPENAPI_HOST:-localhost}"
openapi_port="${CHROMA_OPENAPI_PORT:-8000}"
openapi_url="${CHROMA_OPENAPI_URL:-http://${openapi_host}:${openapi_port}/openapi.json}"

temp_dir="$(mktemp -d)"
venv_dir="${temp_dir}/venv"
db_dir="${temp_dir}/db"
server_log="${temp_dir}/chroma.log"
server_pid=""

cleanup() {
  if [ -n "${server_pid}" ] && kill -0 "${server_pid}" 2>/dev/null; then
    kill "${server_pid}" 2>/dev/null || true
    wait "${server_pid}" 2>/dev/null || true
  fi

  rm -rf "${temp_dir}"
}

trap cleanup EXIT

if [ -z "${CHROMA_OPENAPI_URL:-}" ]; then
  python3 -m venv "${venv_dir}"
  # shellcheck disable=SC1091
  source "${venv_dir}/bin/activate"
  pip install -q "chromadb"

  chroma run --path "${db_dir}" >"${server_log}" 2>&1 &
  server_pid=$!

  for _ in $(seq 1 60); do
    if curl -fsS "${openapi_url}" -o openapi.json; then
      break
    fi

    sleep 1
  done

  if [ ! -s openapi.json ]; then
    echo "Failed to fetch OpenAPI spec from ${openapi_url}."
    cat "${server_log}"
    exit 1
  fi
else
  curl -fsS "${openapi_url}" -o openapi.json
fi

rm -rf Generated

autosdk generate openapi.json \
  --namespace Chroma \
  --clientClassName ChromaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --base-url "http://${openapi_host}:${openapi_port}"
