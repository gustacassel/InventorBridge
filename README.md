# InventorBridge

A bridge between AI agents (Claude Code, Codex and other MCP clients) and Autodesk Inventor: API documentation designed for agents and, in later phases, an MCP server that runs code inside Inventor.

> Independent project, not affiliated with Autodesk. Autodesk and Inventor are registered trademarks of Autodesk, Inc.

## What exists today

- **[API reference](docs/reference/index.md)** for Inventor 2024 to 2027, generated from the interop DLLs:
  - one page per object and per enum, with the interface in pseudo-C#;
  - COM inheritance ("`ExtrudeFeature` inherits from `PartFeature`"), which the interop does not show;
  - an example path from `Application` to each object;
  - what returns each object and where each enum is used;
  - a `// since 20xx` mark on members that do not exist in every version;
  - [`members.tsv`](docs/reference/members.tsv), one member per line, for `grep`.
- **DocGen** (`src/DocGen`), the generator of that reference.

The full plan is in [ARCHITECTURE.md](ARCHITECTURE.md).

## Generating the reference

The Autodesk interop DLLs are not in the repository. Put one per version at `lib/inventor/<year>/Autodesk.Inventor.Interop.dll`:

| Version | Where to get it |
|---|---|
| 2024 and earlier | The Inventor installation: `C:\Program Files\Autodesk\Inventor <year>\Bin\Public Assemblies\` |
| 2025 and later | The interop downloads page on Autodesk support ("Inventor Interop binary files") |

Then, from the repository root (requires the .NET 8 SDK):

```bash
dotnet run --project src/DocGen
```

DocGen does not run Inventor and does not need it installed: it only reads the DLLs' metadata.

## Layout

```
src/DocGen/
  Reading/     reading the DLLs and inheritance.txt
  Model/       per-version model and combined model
  Analysis/    version merging, inheritance, reverse indexes, access paths
  Output/      Markdown pages, index, members.tsv and JSON
  inheritance.txt   derived/base pairs extracted from the object model poster legend
docs/reference/     generated output (do not edit by hand)
```

## License

[MIT](LICENSE). The license covers the code and documentation in this repository, not the DLLs or any other Autodesk material, which remain under Autodesk's own terms.
