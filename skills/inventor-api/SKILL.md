---
name: inventor-api
description: How to work with the Autodesk Inventor the user has open through the InventorBridge MCP tools (run_csharp, inspect, topology, bom, check, export, screenshot, ilogic_*, api_lookup, guide). Use it whenever the user asks to model, change, check, document or export anything in Inventor - parts, assemblies, drawings, sheet metal, iProperties, BOMs, iLogic rules - even if they do not name the tools.
---

# Working in Inventor through InventorBridge

The user watches the same Inventor window you work in. Explain what you are about to build or change, with the main dimensions, before you change it.

## Start

1. `guide("workflow")` once per session, then `inventor_status`: version, workspace folder, templates, open documents. If it lists `otherInventorProcesses`, tell the user which Inventor you are connected to.
2. On an existing model, `check` before changing anything, so you can tell your problems from the ones that were already there.
3. Before using a type, member or enum value you are not sure of, `api_lookup` it. Do not guess API names.

## Change in small steps

- One `run_csharp` call per meaningful step. Lengths in cm, angles in radians: use `Mm()` and `Deg()`.
- Pass `expect` whenever you know a number (volume, size, bodies, occurrences, free degrees of freedom).
- Read the `changes` part of every result. If it does not show what you meant, stop and check.
- Scripts that only read: `undoable: false`.
- New files: `CreateDocument(type, path)` under `WorkspacePath`, then `Save()`. Never overwrite a file without asking.
- Changing a size in an existing assembly usually means parts, patterns and constraints too: read `guide("assemblies")`.
- Undo the last script with `undo_last`.

## Check

- `inspect`: iProperties, features and constraints with problems, mass, sheet metal, drawing contents.
- `topology`: faces and edges to pick, also inside subassemblies (`"Sub:1/Part:2"`).
- `bom`: what an assembly is made of, with total quantities.
- `screenshot` with `view: "iso"` at the end; on drawings, `zoomTo` to read the parts list or the title block.

## When something holds

A call that returns "still running" with a window title means Inventor shows a dialog: usually an add-in's (a vault's "New file" dialog on saving) or an iLogic message. Tell the user what it is and ask them to answer it in Inventor, then call `script_result`.

## Vault

`vault_search` finds files and folders in the vault by name or pattern. Before changing an existing file, `vault_info` tells whether it is released, checked out by someone else, or out of date locally. When the user asks, `vault_change` checks the file out before you change it, and checks it in (with a comment, after saving) or moves it to another lifecycle state when you are done. See `guide('workflow')`.

## Handing files out

`export` writes STEP, IGES, STL, SAT, a sheet metal flat pattern DXF, or a drawing's PDF, DWG or DXF, without changing the document.

## Heavy loops

A loop over thousands of parts or faces is slow: each API call costs around 1 ms, inside Inventor or out of it, so running the loop as iLogic does not help. Ask Inventor for what it computes (mass, range box, `bom`), filter before looping, and read only what you need.

## iLogic

`ilogic_script` runs iLogic code and returns values; `ilogic_list`, `ilogic_set` and `ilogic_run` work with the rules stored in documents. Read `guide("workflow")`, section iLogic.

## More

`guide()` lists the guides: workflow, parts, assemblies, api-pitfalls. Read `api-pitfalls` when a call fails with a COM error you do not understand.
