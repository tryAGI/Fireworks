#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Fireworks \
  --clientClassName FireworksClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme ApiKey:Header:Authorization \
  --exclude-deprecated-operations
