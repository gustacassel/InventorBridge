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

- `inspect`: features and their health, parameters, occurrences, constraints and free degrees of freedom.
- `topology`: faces and edges with their positions, to choose what to constrain or modify next.
- `screenshot`: at the end of a part or an assembly, or whenever orientation matters. Use `view: "iso"` for an overview.

## Pick geometry by name

Indices from `topology` hold only while the geometry does not change. For anything a later step needs, such as the open ends of a tube, name it in the script that creates it, with `Name(edge, "end")`. Then get it back:

- in a part: `Named(partDocument, "end")`
- in an assembly: `Named(occurrence, "end")`, which returns the proxy that constraints need.

Names are the same ones as Inventor's "Assign Name" command, so the user can see them in Inventor.

## Files

- Save new files under `WorkspacePath`, with `System.IO.Path.Combine`.
- Never overwrite an existing file without asking the user. Check with `System.IO.File.Exists` first.
- A part must be saved before it is placed in an assembly, because `ComponentOccurrences.Add` takes a file path.

## Dialogs

Scripts run with `App.SilentOperation` on: Inventor answers its own dialogs with the default choice, such as updating an assembly when it opens or reporting a file error, and the call throws instead of waiting for the user. Add-in dialogs ignore it. With Vault Data Standard installed, saving a new file opens its "New file" dialog and the script waits until the user fills it in or cancels; a cancel makes `SaveAs` throw.

When Inventor keeps a window open while a script is blocked, `run_csharp` returns "still running" after about 2 s with the window's title. Tell the user what it is and ask them to answer or cancel it in Inventor, then call `script_result`.

## Undo and failures

- The transaction covers only the document that was active when the script started. Documents the script creates, and changes to other documents (the parts of the active assembly, for example), are not covered.
- Pass `undoable: false` to scripts that only read. Otherwise each one leaves an empty step in the user's undo list.
- If a script that creates documents fails halfway, the `changes` part lists what was left. Close those documents with `Close(true)` in the next script, or tell the user.

## Closing documents

- `Close()` on a document that another open document references (a part of an open assembly, the model of an open drawing) only closes its window: the document stays loaded. The `changes` part says "closed the window of ...".
- Close from the top down: drawings first, then assemblies, then parts. Then `App.Documents.CloseAll(true)` unloads what nothing references any more.
- `Close(true)` closes without saving. Use it for files you only read.

## Long scripts

- Every property read is a call into another process. Avoid loops over thousands of faces or occurrences: filter first, and keep values in local variables.
- After 60 s, `run_csharp` returns "still running". Call `script_result` to wait for the result. The other tools answer "busy" until the script ends.
