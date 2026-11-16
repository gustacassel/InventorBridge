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
4. **Safe by default.** Every execution runs inside an Inventor transaction (undoable). A long script is never killed in the middle of a COM call: after 60 s the call returns and the result is collected later. Saving, overwriting and checking files into Vault are separate, explicit actions.
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
   - Measured (2026-11-16, Inventor 2024.4): it does not help. A cheap call (`ActiveDocument.DisplayName`) costs 1.18 ms from an external rule against 0.43 ms from `run_csharp`; three reads on each of 3,980 occurrences took 14.5 s as a rule against 12.3 s through `run_csharp`, and reading the part number of each took 22.4 s against 22.8 s. The time goes into Inventor's own work, not the process boundary. iLogic stays useful for its own functions and the users' existing rules, not for speed.
3. **Our own add-in:** only if 1 and 2 are not enough, measured on real cases. The iLogic measurement suggests an add-in would not be faster either: the cost is inside Inventor. Then `ScriptHost` (which targets `netstandard2.0`) is hosted in an add-in with two builds (`net48` for 2024, `net8.0-windows` for 2025+), and the MCP server talks to it over a named pipe.

### 3.3 MCP tools (initial set)

| Tool | Purpose |
|---|---|
| `inventor_status` | Version, open documents, active document, document units |
| `inspect` | Structured summary of the active document: feature or occurrence tree, parameters, iProperties, mass. Paginated, with controllable depth |
| `run_csharp` | Compiles and runs a C# script with `app`, `doc` and helpers (`mm()`, `deg()`, `Log()`) available. Runs in a transaction; returns output, return value, compilation errors or a translated COM exception |
| `script_result` | Result of a script still running when its `run_csharp` call returned |
| `topology` | Faces and edges of a part or occurrence with positions, normals, cylinder axes and circle centers, to pick them in a script |
| `guide` | The hand-written guides (`docs/guides`), served so the agent can read them from any folder |
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
  tests/InventorBridge.Mcp.Tests/  tests without Inventor: lookup, guides, compilation, the MCP server over stdio
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
   - Fixed (2026-11-02): `[In, Out]` parameters (arrays the call fills, such as `CurveEvaluator.GetPointAtParam`) are shown as `ref`, as C# needs, instead of `out`.
   - Done in the generator (2026-11-16): properties whose getter and setter have different types (`Parameter.Units`: string getter, object setter; 18 such members in 2024) cannot be used as properties from C#, so the reference shows them as `string get_Units(); void set_Units(object value);`. Checked on a 2024-only run; `docs/reference` still has to be regenerated with the four interops.
2. **Proof of concept:** MCP server with `inventor_status`, `inspect`, `run_csharp`, `screenshot`, tested on Inventor 2024. Validate the "agent writes a script, runs it, checks it" loop with Claude Code. Measure typical script times.
   - Done (2026-10-28): `src/InventorBridge.Mcp` with `inventor_status`, `inventor_start`, `run_csharp`, `inspect` and `screenshot`. Verified without Inventor: the MCP handshake, tool listing, the "Inventor is not running" errors, and that Roslyn compiles scripts against the 2024 interop on .NET 8 (including a full sketch-and-extrude tube script).
   - Inventor transactions belong to one document (there is no global transaction), so `run_csharp` wraps the script in a transaction on the document that is active when it starts; documents the script creates are not covered.
   - Done (2026-11-02), after looking at SolidCraft's MCP server:
     - `run_csharp` lists what the script changed (documents created, saved or closed; features, sketches, occurrences and constraints added), from snapshots of the open documents taken before and after.
     - `run_csharp` takes an optional `expect` (volume, bounding box size, solid bodies, occurrences, free degrees of freedom) and returns an error when the result does not match, keeping the changes.
     - `topology` lists faces and edges with what a script needs to pick them; split cylinders are merged with the centers of their circular edges. Scripts name entities with `Name()` and find them with `Named()`, using the attribute of Inventor's "Assign Name" command (`iLogicEntityNameSet`).
     - Instead of a timeout, a script still running after 60 s is left to finish: `run_csharp` returns "still running", `script_result` waits for the result, and the other tools answer "busy". A COM call cannot be interrupted safely; an endless loop needs a server restart.
   - Done (2026-11-02), after the M8ven Trust Index review: every tool declares all four MCP hints (readOnly, destructive, idempotent, openWorld; only `run_csharp` is open-world, because a script can reach files and the network), and `tests/InventorBridge.Mcp.Tests` covers what runs without Inventor, including the server over stdio and the compilation of every guide example.
   - Done (2026-11-13): first runs on a real Inventor 2024.4 (pt-BR, Vault workspace). The parts and assemblies guide examples work (saved to a test folder), as do expect, rollback, compilation errors, long scripts, drawings and exports. A COM call costs 0.4 to 1 ms: reading the names of the 4204 leaf occurrences of a 789-document assembly took 4.4 s, while its mass, range box and BOM take under 0.2 s.
   - Done (2026-11-13), from those runs:
     - Scripts run with `SilentOperation` on, so Inventor's own dialogs (update on open, file errors) no longer hold them. Add-in dialogs still can (Vault Data Standard opens one on every save of a new file): while a script waits, Inventor's other windows are checked every second, and one that stays open 2 s ends the wait with its title.
     - `undoable: false` runs a script without a transaction, so read-only scripts no longer fill the undo list.
     - A script that closes the document its transaction is on is no longer reported as failed.
     - The change list tells created, opened and saved documents apart, counts referenced documents instead of listing them, says when `Close()` only closed a window, and makes no claim about documents it does not track above 300.
     - Scripts run with the invariant culture (numbers with a dot) and can use `dynamic`.
   - Done (2026-11-13), reading:
     - `inspect` reads the iProperties by internal property set name (the same in every language), the file state (needs an update, read-only file), model state, mass, material, sheet metal thickness and flat pattern size, the features and constraints with problems, and for drawings the sheets, views, parts lists, balloons and dimensions. It says which lists `maxItems` cut.
     - `bom`: the bill of materials from the Model Data view (reading it changes nothing, unlike enabling the structured view), with quantities rolled up and totals per part number.
     - `topology` takes paths into subassemblies, reports the ends of holes and slots whose edges are arcs, and lists tori (bends) with their ends.
     - `expect` sizeMm falls back to the assembly's range box above 1000 parts, marked as approximate. A part's own range box can be much larger than its body when it is rotated: on a real sheet metal support it was 146 mm wide for a 70 mm body.
   - Done (2026-11-13), files and safety:
     - `export`: STEP, IGES, STL and SAT through `SaveAs(path, true)`, where the extension picks the translator; the flat pattern of sheet metal through `DataIO`; drawings to PDF, and to DWG and DXF through the translator add-ins, because `SaveAs` opens an options dialog for those even when silent. The DWG translator needs a configuration file, and the ones Inventor installs zip the output, so a copy with `USE TRANSMITTAL=No` is used.
     - `CreateDocument` (script global): a new file copied from the template, opened and saved later with `Save()`, because a first `SaveAs` makes Vault Data Standard open its dialog. Copies keep the template's internal name, as with the RGO add-in, which does the same in production; the change list tells such twins apart by file.
     - `check`: missing files, features and constraints with errors, documents that need an update, broken flat patterns, detached dimensions and balloons, across every referenced document (790 documents in 22 s).
     - `undo_last`: Ctrl+Z for the last script only.
     - A server that stops while a script is held by a dialog leaves the script's transaction open in Inventor; every later change nests in it and Inventor's undo stays disabled. This happened once in testing. The next script, or `undo_last`, now ends such a transaction and says so.
     - `export`, `check` and `bom` run like scripts: tracked, returning after 60 s or as soon as Inventor keeps a dialog open.
   - Done (2026-11-16):
     - `screenshot` hides work planes, axes, points and sketches for the capture (object visibility and the document's unsaved-changes flag are put back), and on drawings zooms to a view, the parts list, the title block or a sheet region, then puts the user's camera back.
     - `inventor_status` lists other Inventor processes: Windows hands any running Inventor to a client, so with two the user may be watching the other one, and one without a window is usually left over from a crash.
     - Window detection also reports Windows' standard dialogs without a title (a `MessageBox` without a caption).
   - To do: one Inventor crash, while a script closed parts before the assembly and drawing that referenced them, did not happen again in three tries.
3. **Documentation:** 5 guides + 10 tested recipes + `inventor-api` skill. Measure the improvement: the same tasks with and without docs.
   - Started (2026-11-02): `docs/guides` with `workflow`, `parts`, `assemblies` and `api-pitfalls`, served by the `guide` tool; the server instructions tell the agent to read `workflow` first. Their C# blocks compile against the 2024 interop but have not run on Inventor yet.
   - Done (2026-11-16): `docs/guides/drawings.md`. The steps (sheet from a format, views, dimensions on view curves, parts list, stacked balloons, saving the drawing alone) ran while detailing a 30-part assembly; the drafting practice section also reflects 583 production drawings read in batches (one sheet, a base view with two or three projections, hidden lines removed, labels only on sections and details, few dimensions, stock sizes as reference dimensions, a flat pattern view with bend notes on every sheet metal drawing, a parts list and balloons on every assembly). Sections, details, breaks, hole and bend notes, center marks and weld symbols are listed but not yet scripted.
   - Done (2026-11-16): the rest of detailing, run on Inventor 2024.4 on a 1200 mm bar with clearance and tapped holes and chamfers, and on a bent sheet metal part, both created for the test outside the workspace. Each new block of `drawings.md` (breaks, section and detail views, the flat pattern view, automated center marks, hole and thread notes with the hole count, chamfer and bend notes, an ISO fillet weld symbol) and the holes and chamfers block of `parts.md` ran as written on fresh documents. Found on the way: a hole that cuts nothing reports `kDriverLostHealth`; `<QuantityNote/>` is the only spelling of the hole count a note accepts; a fillet weld under ISO takes `SizeOrStrength`, not `Leg1`. Not run: sketched symbols, and weld symbols on a weldment assembly.
   - Done (2026-11-16): the reference generator left out `BreakOperations.Add`, the break method of 2024, because 2026 and 2027 hide it in favor of newer methods: a member hidden in the newest version was dropped for every version. Now a member is left out only when every version hides it; otherwise its pages carry "hidden in 2026, 2027" and `members.tsv` lists only the versions where it is visible. Covered by `ApiMergerTests`; `docs/reference` takes the change at its next regeneration with all four interops.
   - Done (2026-11-16): `skills/inventor-api/SKILL.md`, a short skill for agents using the tools, pointing to the guides the server serves; `AGENTS.md` at the root, for agents changing this repository (build, tests, testing against a real Inventor, conventions). For Codex users, the README says to put the skill's text in their own project's `AGENTS.md`.
4. **iLogic:** `ilogic_*` tools and temporary-rule execution for heavy tasks; `undo_last`.
   - Done (2026-11-16): `ilogic_list`, `ilogic_set` and `ilogic_run` through the iLogic add-in's automation, late-bound. `AddRule` runs a new rule at once, whatever `RulesEnabled` says, so `ilogic_set` adds a comment and then sets the text with rules disabled, which does not run it. A run goes through the script transaction (`undo_last` undoes it) and is tracked like a script: a rule's `MessageBox` or iLogic's error dialog comes back by title. The orphaned-transaction recovery was confirmed here: a server stopped while iLogic's error dialog held a rule, and the next script closed the rule's transaction.
   - `undo_last`: done in phase 2 (see above).
   - Done (2026-11-16): `ilogic_script` runs iLogic code given as text as a temporary external rule, with arguments and values returned through the same `NameValueMap`, which the rule can change and extend. iLogic does not report a rule's errors to the caller (it shows its error dialog and returns), so the code gets a last statement that records it reached its end, before `End Sub` of `Main` or at the end; without it the run is an error and is rolled back. Measured, it is not faster than `run_csharp` (see 3.2).
5. **Company standards:** support for each company's private standards and skills (`docs/company`), iProperties checks and part number cross-checks against the ERP (read-only).
   - Done (2026-11-16): company guides. The `guide` tool also serves Markdown guides from the folders in `INVENTORBRIDGE_GUIDES`, set where the server is registered, listed apart; a company guide cannot replace a general one, and the server instructions name the company guides and tell the agent to read them before creating, naming, saving or exporting files. The content stays in each company's repository.
6. **Our own add-in:** only if the measurements from phases 2 and 4 show it is needed.

## 6. Open questions

- ~~Which Inventor versions to support?~~ Resolved: initial target 2024; reference for 2024 to 2027.
- Which version to test right after 2024?
- Vault integration: are check-out and check-in out of the initial scope, or explicit tools? Partly resolved (2026-11-16): reading is a tool. The Vault add-in keeps the logged-in connection inside Inventor's process; an iLogic rule runs there and takes it (`Connectivity.InventorAddin.EdmAddin.EdmSecurity.Instance.VaultConnection`, as in-house add-ins do), so `vault_info` reads versions, revisions, lifecycle states, checkouts and local status with the user's own rights and no password. The client's status can be stale (a recreated drawing showed as unchanged), so local and vault sizes are compared too. Writing (check-out, check-in, lifecycle, numbering) stays out until it is decided; the connection carries the user's rights, which on the test machine were an administrator's.
- Priority use cases: modeling new parts, generating drawings, reviewing models, exporting BOMs to the ERP?
- ~~Internal or public repository?~~ Resolved: public. The reference only contains names and signatures extracted from the DLLs; the DLLs, the Autodesk posters and company standards stay out.
