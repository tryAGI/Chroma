# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for [Chroma](https://www.trychroma.com/), the open-source AI-native embedding database, auto-generated from the Chroma OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as NuGet package `tryAGI.Chroma`.

## Build Commands

```bash
# Build the solution
dotnet build Chroma.slnx

# Build for release (also produces NuGet package)
dotnet build Chroma.slnx -c Release

# Run integration tests (no API key needed -- Chroma is a local database)
dotnet test src/tests/IntegrationTests/Chroma.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/Chroma && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code is **entirely auto-generated** -- do not manually edit files in `src/libs/Chroma/Generated/`.

1. `src/libs/Chroma/openapi.json` -- the committed Chroma OpenAPI spec snapshot
2. `src/libs/Chroma/generate.sh` -- starts a temporary official Chroma server, downloads `/openapi.json`, and runs AutoSDK CLI to update `Generated/`
3. CI auto-updates the spec and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Chroma/` | Main SDK library (`ChromaClient`) |
| `src/tests/IntegrationTests/` | Integration tests against a Chroma instance |

### Documentation Generation

Tests in `src/tests/IntegrationTests/Examples` are the single source of truth for both test coverage and documentation:
- Each file has a JSDoc header (`order`, `title`, `slug`) consumed by `autosdk docs sync .`
- Comments prefixed with `////` become prose paragraphs in generated docs
- CI workflow (`.github/workflows/mkdocs.yml`) auto-generates `docs/examples/` and populates `EXAMPLES:START/END` markers in README.md, docs/index.md, and mkdocs.yml
- Config: `autosdk.docs.json` points to `src/tests/IntegrationTests/Examples`

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + AwesomeAssertions

### Key Conventions

- No hand-written extension files -- the SDK is purely generated code
- The client class is named `ChromaClient`
- The namespace is `Chroma`
- Chroma is a self-hosted database, so no cloud API key is required for testing

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
