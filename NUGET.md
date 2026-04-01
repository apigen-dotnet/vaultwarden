# Apigen.Vaultwarden

Generated C# client for the [Vaultwarden](https://github.com/dani-garcia/vaultwarden) API (Bitwarden-compatible).

## Installation

```bash
dotnet add package Apigen.Vaultwarden
```

## Usage

Vaultwarden authentication requires PBKDF2/Argon2id key derivation and encrypted vault decryption. See the [complete working example](https://github.com/apigen-dotnet/vaultwarden/tree/main/examples/Apigen.Vaultwarden.TestClient) for the full login + vault sync + decrypt flow.

## Versioning

Package versions follow the upstream application version: the **major.minor** matches the application API version, and the **patch** is our client revision. For example, package `2.6.7` was built against API version `2.6.x` and is our 7th client release for that API version.

## License

MIT
