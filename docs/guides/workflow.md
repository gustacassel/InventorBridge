# Workflow

> Read first: plan, build in small steps, check every step, save files in the right place.

## Before the first change

1. Call `inventor_status`. It gives the Inventor version, the workspace folder where new files go, the default templates and the open documents.
2. Tell the user what you are going to build, with the main dimensions. They watch the same Inventor window.

## Build in small steps

Use one `run_csharp` call per meaningful step: one part, one group of features, or one assembly step. A small script fails with a clearer error, and each step becomes one undo step in Inventor.

- Look up every type, member or enum value you are not sure of with `api_lookup` before you write it.
- Pass `expect` whenever you know a number. For example, a tube's volume is π(R² − r²)·L in mm³, and a fully constrained assembly has `freeDegreesOfFreedom: 0`. A mismatch comes back as an error right away.
- Read the `changes` part of every result. It names the documents created or saved, and the features, sketches, occurrences and constraints added. If it does not show what you meant to do, stop and check.

## Check the result

- `inspect`: iProperties, features and their health, parameters, mass, occurrences, constraints and free degrees of freedom; for a drawing, sheets, views, parts lists and dimensions. `featuresWithProblems` and `constraintsWithProblems` are the first thing to read after a change. When `truncated` is there, a list was cut: raise `maxItems`.
- `bom`: what an assembly is made of, with total quantities per part number.
- `check`: what is broken in a document and everything it references (missing files, features and constraints with errors, documents to update, detached dimensions). Run it before and after changing an existing model, to tell your problems from the ones that were already there.
- `topology`: faces and edges with their positions, to choose what to constrain or modify next.
- `inspect`'s `boundingBoxMm` for an assembly is Inventor's range box, which can be larger than the parts when some are rotated. To check a size, use `expect: {"sizeMm": [...]}`, which measures the bodies.
- `screenshot`: at the end of a part or an assembly, or whenever orientation matters. Use `view: "iso"` for an overview. Work planes and sketches are hidden unless `hideHelpers: false`. On a drawing, `zoomTo: "partsList"`, `"titleBlock"` or a view's name (or `regionMm`) makes small text readable.

## Pick geometry by name

Indices from `topology` hold only while the geometry does not change. For anything a later step needs, such as the open ends of a tube, name it in the script that creates it, with `Name(edge, "end")`. Then get it back:

- in a part: `Named(partDocument, "end")`
- in an assembly: `Named(occurrence, "end")`, which returns the proxy that constraints need.

Names are the same ones as Inventor's "Assign Name" command, so the user can see them in Inventor.

## Files

- Save new files under `WorkspacePath`, with `System.IO.Path.Combine`.
- Create a file to keep with `CreateDocument(type, path)` and save it with `Save()`. `Documents.Add` is fine for a document that will not be saved, but its first `SaveAs` can open an add-in's "New file" dialog.
- Copies made by `CreateDocument` keep the template's internal name, like files copied in Windows. Inventor handles them, also several in one assembly.
- To hand a file to someone else (STEP, PDF, DWG, flat pattern DXF), use `export`, not `SaveAs`: it writes a copy and leaves the document as it was.
- Never overwrite an existing file without asking the user. Check with `System.IO.File.Exists` first.
- A part must be saved before it is placed in an assembly, because `ComponentOccurrences.Add` takes a file path.

## Dialogs

Scripts run with `App.SilentOperation` on: Inventor answers its own dialogs with the default choice, such as updating an assembly when it opens or reporting a file error, and the call throws instead of waiting for the user. Add-in dialogs ignore it. With Vault Data Standard installed, saving a new file opens its "New file" dialog and the script waits until the user fills it in or cancels; a cancel makes `SaveAs` throw.

When Inventor keeps a window open while a script is blocked, `run_csharp` returns "still running" after about 2 s with the window's title. Tell the user what it is and ask them to answer or cancel it in Inventor, then call `script_result`.

## Undo and failures

- The transaction covers only the document that was active when the script started. Documents the script creates, and changes to other documents (the parts of the active assembly, for example), are not covered.
- Pass `undoable: false` to scripts that only read. Otherwise each one leaves an empty step in the user's undo list.
- `undo_last` undoes the last script, like Ctrl+Z, and refuses when the last step in Inventor's undo list was the user's.
- If the MCP server stops while a script runs (restarted while a dialog held it), Inventor keeps that script's transaction open, every later change nests inside it and Inventor's own undo stays disabled. The next script closes it and says so.
- If a script that creates documents fails halfway, the `changes` part lists what was left. Close those documents with `Close(true)` in the next script, or tell the user.

## Closing documents

- `Close()` on a document that another open document references (a part of an open assembly, the model of an open drawing) only closes its window: the document stays loaded. The `changes` part says "closed the window of ...".
- Close from the top down: drawings first, then assemblies, then parts. Then `App.Documents.CloseAll(true)` unloads what nothing references any more.
- `Close(true)` closes without saving. Use it for files you only read.

## Long scripts

- Every property read is a call into another process. Avoid loops over thousands of faces or occurrences: filter first, and keep values in local variables.
- After 60 s, `run_csharp` returns "still running". Call `script_result` to wait for the result. The other tools answer "busy" until the script ends.

## iLogic

- `ilogic_script` runs iLogic code given as text and returns values: the code sets `RuleArguments.Arguments.Value("Result") = ...` or adds its own with `RuleArguments.Arguments.Add("Name", value)`. Code that stops before its end is reported as an error and rolled back.
- To store a rule in a document, write it with `ilogic_set` (it is not run) and run it with `ilogic_run`. A stored rule returns nothing to the agent: write results into a parameter or an iProperty and read them with `inspect`.
- iLogic is not a way to speed up loops. Rules run inside Inventor, but an API call costs as much or more there: 1.2 ms against 0.4 ms from `run_csharp`, and a loop over 4,000 occurrences took about as long both ways. The time goes into Inventor itself.
- `Logger` writes to iLogic's log window, not to the agent.
- iLogic does not report a rule's error to the caller: it opens an error dialog. The tools close the dialogs iLogic opens for the rules they run and return the error: for `ilogic_script`, a runtime error with its stack trace and a compilation error with iLogic's message, both with line numbers as in the code sent. Nothing is left open on the user's screen.
- A compilation error sometimes stops a rule without any dialog (a variable declared twice, for example). The result then says the code did not run: check the syntax and the names.
- A `MessageBox` the code shows itself still waits for the user: the call returns with its title.
- iLogic writes a copy of every rule it runs to `%TEMP%\iLogic Rules`. The tools delete the copies of the rules they run, and their own temporary rule files, also those left by a run the server did not see finish.
- Rules may already exist in the user's documents: read them with `ilogic_list` (`withText: true`) before replacing one.

## Vault

- `vault_info` reads, for the active document and everything it references (or for given paths), the vault path, version, revision, lifecycle state, category, who has the file checked out, and whether the local copy matches the vault's latest version. It uses the vault connection the user's Inventor already has, through an iLogic rule, so no password is involved, and it acts with the user's own rights.
- `vault_search` finds files (`names`) and folders (`folders`) by name, in the whole vault or `under` one folder such as `$/Engenharia/Produto`. A name is exact, or a pattern with `*` and `?`. Each file found comes with its vault path, the path it has in the working folder and whether a local copy exists; names not found are listed apart. Hidden files, such as the `.dwf` visualization attachments, are found and marked `hidden`; `skipHidden` leaves them out. A file name found in several folders means the vault holds same-named files there: say so, and do not pick one for the user.
- Results stop at `maxPerName` per name (50 by default) and say so in `truncated`. A broad pattern such as `*.iam` over the whole vault finds thousands; give a folder.
- Read it before changing an existing file. A released file, or one checked out by someone else, needs the user's decision before you change it; a local copy older than the vault's needs a "Get latest" first.
- The vault client's own status for a file can be stale, so `vault_info` also compares the local file's size with the vault's. When they differ, say so; do not decide which one is right.
- `vault_change` checks out, checks in, undoes a check-out, gets the latest version and changes the lifecycle state, through the same connection and with the user's rights. Everyone using the vault sees the result: do it when the user asked for it, and give a comment that says what changed.
- Check a file out before changing it. Changing a vault file that is not checked out makes the Vault add-in ask the user "check it out?", which holds the script.
- Save in Inventor before a check-in: `vault_change` refuses files with unsaved changes, and refuses to overwrite them with a download.
- A check-in sends the references Inventor reads, so the vault keeps an assembly's and a drawing's dependencies. Files the vault does not have yet are added, folders included; with `withReferences`, an assembly's new parts go in first. The vault's BOM data is not sent: items and BOM views in Vault need the user's check-in from Inventor.
- A state change writes a new version in the vault, which is downloaded. Files whose local copy was rewritten are reopened in Inventor when they have a window; a file loaded only as a reference keeps the old copy until its assembly is reopened.
- Each result says, per file, what was done, unchanged, skipped (checked out by someone else) or failed, with Vault's message. A state that does not exist comes back with the states the lifecycle has.
- A file checked out by someone else is skipped by every action but `get_latest`; `vault_info` names who has it and on which computer. While a file is checked out, Vault already counts the next version.
- The tool acts with the rights of the user logged in to Inventor. An administrator can check out a released file that a designer cannot: the result then says it is released. Ask the user before changing a released file.
- Drawings check in like assemblies: with `withReferences`, a new part goes in before its drawing, and the vault records the drawing's dependency on the model.
- New numbers, Data Standard's dialogs and items stay the user's to handle in Vault.

