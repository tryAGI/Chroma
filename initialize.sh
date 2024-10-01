dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  Chroma \
  ChromaClient \
  https://raw.githubusercontent.com/amikos-tech/chroma-go/main/openapi.yaml \
  tryAGI \
  --output .
