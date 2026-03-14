dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  Chroma \
  ChromaClient \
  https://raw.githubusercontent.com/tryAGI/Chroma/main/src/libs/Chroma/openapi.json \
  tryAGI \
  --output .
