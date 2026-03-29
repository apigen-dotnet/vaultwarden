#!/bin/bash
set -euo pipefail

SCRIPT_DIR="$(cd "$(dirname "$0")" && pwd)"
GENERATOR_DIR="$SCRIPT_DIR/../generator"

if [ ! -d "$GENERATOR_DIR" ]; then
  echo "Error: Generator not found at $GENERATOR_DIR"
  echo "Clone it: git clone https://github.com/apigen-dotnet/generator.git $GENERATOR_DIR"
  exit 1
fi

# Auto-discover the TOML config in specs/
CONFIG=$(ls "$SCRIPT_DIR"/specs/*.toml 2>/dev/null | head -1)
if [ -z "$CONFIG" ]; then
  echo "Error: No .toml config found in $SCRIPT_DIR/specs/"
  exit 1
fi

echo "Regenerating from specs..."
cd "$SCRIPT_DIR"
dotnet run --project "$GENERATOR_DIR/src/Apigen.Generator/Apigen.Generator.csproj" -- --config "$CONFIG" "$@"
echo "Done!"
