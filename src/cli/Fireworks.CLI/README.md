# Fireworks.CLI

Command-line interface for the Fireworks SDK generated with AutoSDK.

## Installation

```bash
dotnet tool install --global Fireworks.CLI --prerelease
```

## Usage

```bash
fireworks --help
fireworks audio --help
```

## Shell completion

The `completion` command prints a script built from the live command tree, so
subcommands, option names and the values of enum-typed options stay correct after the
spec is refreshed and the CLI regenerated — there is no word list to maintain.

```bash
fireworks completion bash > /usr/local/etc/bash_completion.d/fireworks
fireworks completion zsh  > _fireworks   # then put it on your zsh fpath
fireworks completion fish > ~/.config/fish/completions/fireworks.fish
```

## Customization

Generated operation, tag, and API group command classes are partial. Implement
`static partial void CustomizeCommand(ref Command command)` in a separate source
file to add aliases or validators, change the action, or replace a command. The
hook runs after the generated command has been configured.