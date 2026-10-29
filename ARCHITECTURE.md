# Architecture: a bridge between AI agents and Autodesk Inventor

Draft v1 (2026-10-25). The goal is to let Claude Code, Codex and other MCP clients read, modify and verify Inventor models safely, backed by documentation that reduces hallucinations about the API.

## 1. What already exists and what to reuse

| Project | What to reuse | What to avoid |
|---|---|---|
| [NeonGlay/inventor-mcp](https://github.com/NeonGlay/inventor-mcp) (MIT) | Notes on COM API behavior in 2026, transactions with rollback, skills | Depending on pywin32's `gencache` (breaks `GetActiveObject`) |
| [effectustasi/autodesk-inventor-mcp](https://github.com/effectustasi/autodesk-inventor-mcp) (MIT) | Minimalist approach: a few inspection tools plus one free-form script tool | PowerShell as the scripting language (untyped, poor errors) |
| [Andiveli/mcp-cad](https://github.com/Andiveli/mcp-cad) | Early-bound COM in .NET, tag-based references (`@hole_center`), viewport capture | 80+ fixed tools: lots of context spent and little flexibility |
| [hsavas/inventor-mcp](https://github.com/hsavas/inventor-mcp) | Only as a coverage reference (assemblies, joints, drawings) | **Do not copy code**: its license forbids commercial use without permission |

Conclusion: nobody has invested in a **documentation layer for agents**, nor in **iLogic**. That is the differentiator.

## 2. Design principles

1. **Few tools, one strong executor.** The agent writes C# code against the real API and the server runs it. Fixed tools only for what is frequent or needs a structured format (inspection, screenshot, iLogic).
2. **Documentation is generated from the interop DLLs.** Signatures, enums and members come from reflection over each version's `Autodesk.Inventor.Interop.dll`. The agent looks things up instead of guessing.
3. **Fast, verifiable feedback.** Compilation errors come back with line and message; every change produces a summary of what changed; screenshots are available for visual checks.
4. **Safe by default.** Every execution runs inside an Inventor transaction (undoable), with a timeout. Saving, overwriting and checking files into Vault are separate, explicit actions.
5. **Works with any agent.** Standard MCP (stdio) + plain Markdown documentation + `AGENTS.md` for Codex and skills for Claude Code.
6. **Nothing installed inside Inventor**, unless a measurement shows it is needed (see 3.2).

## 3. Components

```
Claude Code / Codex
   |  reads docs/ and skills/       (local files)
   |  calls MCP tools               (stdio)
   v
InventorBridge.Mcp  (.NET 8, official ModelContextProtocol SDK)
   |  ScriptHost (Roslyn C#), transactions, screen capture
   |  out-of-process COM (GetActiveObject via ROT)
   v
Inventor 2024, 2025, 2026...  (whichever version is open on the machine)
   |  optional heavy work: iLogic rule run in-process
```

### 3.1 MCP server (`InventorBridge.Mcp`)
A single `net8.0-windows` process, launched by the agent. It connects to an already open Inventor through COM:

- **Connection:** `Marshal.GetActiveObject` does not exist in .NET 8; use P/Invoke on `oleaut32!GetActiveObject` with the `Inventor.Application` ProgID (`CLSIDFromProgID` + `GetActiveObject`). If Inventor is not open, return a clear error (it does not start Inventor on its own, to avoid using a license by accident).
- **Dedicated STA thread:** every COM call goes through a single STA thread with a work queue.
- **`IMessageFilter`:** registered on the STA thread to retry calls rejected with `RPC_E_CALL_REJECTED` while Inventor is busy or has a dialog open.
- **Interop:** compiles against the **oldest supported** interop (2024). COM interfaces are backward compatible, so the same binary works with 2025+.

Advantage over an add-in: a single build for every version (Inventor 2024 uses .NET Framework 4.8 and 2025+ uses .NET 8, but that only matters for code loaded inside Inventor), nothing installed in Inventor, and no Inventor restart on every rebuild.

### 3.2 Performance and when to use an add-in
Each property or method access through out-of-process COM is a cross-process call (roughly 0.1 to 1 ms). For almost everything this does not matter. It gets slow in loops over thousands of entities (every face of an imported model, every occurrence of a large assembly).

Mitigations, in order:
1. **Write scripts with fewer calls:** use filtered collections (`Occurrences.AllLeafOccurrences`, `BOM`), fetch only what is needed and keep values in local variables. This goes into the guides.
2. **iLogic as in-process execution:** for heavy tasks, the server writes a temporary external rule (VB.NET) and calls the iLogic add-in, which ships with Inventor, through its automation interface (`RunExternalRule`). The code runs inside Inventor without us installing anything.
3. **Our own add-in:** only if 1 and 2 are not enough, measured on real cases. Then `ScriptHost` (which targets `netstandard2.0`) is hosted in an add-in with two builds (`net48` for 2024, `net8.0-windows` for 2025+), and the MCP server talks to it over a named pipe.

### 3.3 MCP tools (initial set)

| Tool | Purpose |
|---|---|
| `inventor_status` | Version, open documents, active document, document units |
| `inspect` | Structured summary of the active document: feature or occurrence tree, parameters, iProperties, mass. Paginated, with controllable depth |
| `run_csharp` | Compiles and runs a C# script with `app`, `doc` and helpers (`mm()`, `deg()`, `Log()`) available. Runs in a transaction; returns output, return value, compilation errors or a translated COM exception |
| `undo_last` | Undoes the last transaction opened by the bridge |
| `screenshot` | Viewport capture (optional view and zoom), returned as an image |
| `api_lookup` | Searches the generated reference, filtered by the connected version: "members of `PartComponentDefinition`", "values of `PartFeatureExtentDirectionEnum`" |
| `ilogic_list` / `ilogic_get` / `ilogic_set` / `ilogic_run` | Read, write and run internal and external iLogic rules (also the in-process execution path, see 3.2) |
| `export` | STEP, PDF, DWG, flat pattern DXF, to a defined output folder |

New tools are only added when a recipe repeats a lot or needs structured output.

### 3.4 Documentation (`docs/`)

| Folder | Content | Source |
|---|---|---|
| `docs/reference/` | One file per interface and enum: members, types, parameters, valid enum values, with "since 20xx" and "removed in 20xx" marks. Index of objects and enums | Generated by `InventorBridge.ReferenceGenerator` from each version's interop |
| `docs/guides/` | Object model, internal units (cm, rad), `TransientGeometry` and matrices, transactions, `ObjectCollection`, enum pitfalls across versions, COM performance, iLogic vs API | Hand-written |
| `docs/recipes/` | Short, **tested** recipes: part from a sketch, tapped hole, circular pattern, placing a component with constraints, joints, drawing view with dimensions, BOM export, filling iProperties | Hand-written and validated by `tests/recipes` |
| `docs/company/` | Each company's standards: naming, required iProperties, templates, material library, link between the Inventor part number and the ERP item code | Written by each company's engineering team, in its own private repository; not part of this repository |

Legal note: the text of Autodesk's official help is copyrighted. Signatures extracted by reflection can be used; descriptions copied from the help do not go into the repository.

### 3.5 Skills and agent instructions
- `skills/inventor-api/SKILL.md`: how to work (call `api_lookup` before using an unknown member, always use a transaction, check with `inspect`/`screenshot`, avoid loops with many COM calls), with links to guides and recipes.
- `skills/inventor-ilogic/SKILL.md`: iLogic rule patterns, when to use iLogic and when to use the API.
- `skills/<company>-engineering/SKILL.md`: company standards, in each company's private repository.
- `AGENTS.md` at the root: the same content for Codex.

### 3.6 Inventor versions

The initial target is Inventor 2024. With out-of-process COM, the version matters little:

- The server compiles against the 2024 interop and works with 2024 and later.
- The agent's scripts (`run_csharp`) are compiled at runtime against the interop **of the connected version**, loaded from the installation folder (`Bin\Public Assemblies`). That gives the agent the full API of each version.
- The reference generator processes the interop of each version and generates a single reference with version marks. `api_lookup` filters by the connected version.
- The Autodesk DLLs live in `lib/inventor/<year>/`, outside version control (`.gitignore`). They are not redistributed.

## 4. Repository layout

```
InventorBridge/
  src/
    InventorBridge.Mcp/       stdio MCP server (net8.0-windows)
      Connection/             STA thread, message filter, attaching to or starting Inventor
      Scripting/              Roslyn script runner and transactions
      Reading/                status, inspection and view capture
      Reference/              api_lookup over the generated reference
      Tools/                  the MCP tools
    InventorBridge.Core/      (only if an add-in is ever needed: Scripting/ moves here, netstandard2.0)
    InventorBridge.ReferenceGenerator/  reflection over the interops -> docs/reference
      Reading/                reading the DLLs and inheritance.txt
      Model/                  per-version model and combined model
      Analysis/               version merging, inheritance, reverse indexes, access paths
      Output/                 Markdown pages, index, members.tsv and JSON
  docs/{reference,guides,recipes}/
  skills/
  tests/recipes/              runs each recipe in a blank document and checks the result
  lib/inventor/<year>/        Autodesk interop DLLs (outside git)
  AGENTS.md
```

## 5. Phases

The reference generator only needs the DLLs, not Inventor. That is why it comes first: it can be built on any machine while the proof of concept waits for a workstation with Inventor.

1. **API reference:** multi-version reference generated from the interops (2024 onward) + `api_lookup` as a standalone MCP tool, already useful for writing iLogic and add-ins.
   - Done (2026-10-25): `src/InventorBridge.ReferenceGenerator` (first called DocGen) generates `docs/reference` from `lib/inventor/<year>/`. COM inheritance comes from `src/InventorBridge.ReferenceGenerator/inheritance.txt` (extracted from the InventorObjectModel 2024 to 2027 posters), confirmed by vtable order.
   - Done (2026-10-28): reference for 2024, 2025, 2026 and 2027, with a "since 20xx" mark per member. The 2024 interop comes from the Inventor installation; 2025+ come from Autodesk's interop downloads page (2025 v29.3, 2026 v30.2, 2027 v31.0).
   - Done (2026-10-29): `api_lookup` in the MCP server. The build copies the object and enum pages and `members.tsv` next to the server; the tool returns a page without links, the members of a type that match a text, or a name search, hiding members that the running Inventor version does not have. Enums longer than 100 values are cut short and searched by name instead.
   - To do: properties whose getter and setter have different types (e.g. `Parameter.Units`: string getter, object setter) cannot be used as properties from C#; the reference should show them as `get_Units()` / `set_Units(object)`.
2. **Proof of concept:** MCP server with `inventor_status`, `inspect`, `run_csharp`, `screenshot`, tested on Inventor 2024. Validate the "agent writes a script, runs it, checks it" loop with Claude Code. Measure typical script times.
   - Done (2026-10-28): `src/InventorBridge.Mcp` with `inventor_status`, `inventor_start`, `run_csharp`, `inspect` and `screenshot`. Verified without Inventor: the MCP handshake, tool listing, the "Inventor is not running" errors, and that Roslyn compiles scripts against the 2024 interop on .NET 8 (including a full sketch-and-extrude tube script).
   - Inventor transactions belong to one document (there is no global transaction), so `run_csharp` wraps the script in a transaction on the document that is active when it starts; documents the script creates are not covered.
   - To do: run the tube-and-bend assembly example on a real Inventor 2024 and measure script times; a script timeout (a stuck script currently blocks the STA thread).
3. **Documentation:** 5 guides + 10 tested recipes + `inventor-api` skill. Measure the improvement: the same tasks with and without docs.
4. **iLogic:** `ilogic_*` tools and temporary-rule execution for heavy tasks; `undo_last`.
5. **Company standards:** support for each company's private standards and skills (`docs/company`), iProperties checks and part number cross-checks against the ERP (read-only).
6. **Our own add-in:** only if the measurements from phases 2 and 4 show it is needed.

## 6. Open questions

- ~~Which Inventor versions to support?~~ Resolved: initial target 2024; reference for 2024 to 2027.
- Which version to test right after 2024?
- Vault integration: are check-out and check-in out of the initial scope, or explicit tools?
- Priority use cases: modeling new parts, generating drawings, reviewing models, exporting BOMs to the ERP?
- ~~Internal or public repository?~~ Resolved: public. The reference only contains names and signatures extracted from the DLLs; the DLLs, the Autodesk posters and company standards stay out.
