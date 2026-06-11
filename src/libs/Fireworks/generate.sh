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

rm -rf ../../cli/Fireworks.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/Fireworks.CLI \
  --sdk-project ../../libs/Fireworks/Fireworks.csproj \
  --targetFramework net10.0 \
  --namespace Fireworks \
  --clientClassName FireworksClient \
  --package-id Fireworks.CLI \
  --tool-command-name fireworks \
  --user-secrets-id Fireworks.CLI \
  --api-key-env-var FIREWORKS_API_KEY \
  --base-url-env-var FIREWORKS_BASE_URL \
  --cli-credential-file \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:Authorization
