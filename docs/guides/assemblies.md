# Assemblies

> Placing saved parts, connecting them with constraints through named edges and proxies, checking degrees of freedom.

Status: the scripts below ran on Inventor 2024.4 (2026-11-13), saved to a folder outside the project because an add-in intercepted saving there; the guide tests also compile them against the 2024 interop.

## The pattern

1. Save every part first: `ComponentOccurrences.Add` takes a file path.
2. Create the assembly from the assembly template.
3. Place each part. Placing them all at the origin is fine, because the constraints move them.
4. Ground one occurrence, usually the first.
5. Constrain using proxies. A face or edge of a part is not valid in the assembly; its proxy is. `Named(occurrence, "name")` returns the proxy of a named entity. `occurrence.CreateGeometryProxy(entity, out object proxy)` returns the proxy of any entity, including work planes.
6. Check with `expect: {"freeDegreesOfFreedom": ...}` or `inspect`, then take a screenshot.

## Two tubes and a bend

This uses the parts from the "parts" guide, whose outer end edges are named "start" and "end".

```csharp
string tubePath = System.IO.Path.Combine(WorkspacePath ?? "", "Tube-50x3x500.ipt");
string bendPath = System.IO.Path.Combine(WorkspacePath ?? "", "Bend-50x3-R100.ipt");

string template = App.FileManager.GetTemplateFile(DocumentTypeEnum.kAssemblyDocumentObject);
var assembly = (AssemblyDocument)App.Documents.Add(DocumentTypeEnum.kAssemblyDocumentObject, template, true);
AssemblyComponentDefinition definition = assembly.ComponentDefinition;

Matrix origin = Geometry.CreateMatrix();
ComponentOccurrence tube1 = definition.Occurrences.Add(tubePath, origin);
ComponentOccurrence bend = definition.Occurrences.Add(bendPath, origin);
ComponentOccurrence tube2 = definition.Occurrences.Add(tubePath, origin);
tube1.Grounded = true;

// Insert makes two circular edges coaxial and puts their planes together.
// AxesOpposed = true puts the parts end to end; false would push one into the other.
definition.Constraints.AddInsertConstraint(Named(tube1, "end"), Named(bend, "start"), true, 0);
definition.Constraints.AddInsertConstraint(Named(bend, "end"), Named(tube2, "start"), true, 0);

return $"{tube1.Name}, {bend.Name}, {tube2.Name}";
```

After this, the bend can still turn about the first tube's axis, and the second tube about its own axis: `freeDegreesOfFreedom` is 2. The second tube's rotation does not change its shape. The bend's rotation decides where the second tube points.

## Fixing the bend's direction

The bend turns within its own XZ plane, which also contains the first tube's axis after the insert. Making that plane flush with the first tube's XZ plane sends the second tube toward the first tube's X direction:

```csharp
var assembly = (AssemblyDocument)App.ActiveDocument;
AssemblyComponentDefinition definition = assembly.ComponentDefinition;
ComponentOccurrence tube1 = definition.Occurrences.ItemByName["Tube-50x3x500:1"];
ComponentOccurrence bend = definition.Occurrences.ItemByName["Bend-50x3-R100:1"];

var tubeDefinition = (PartComponentDefinition)tube1.Definition;
var bendDefinition = (PartComponentDefinition)bend.Definition;
tube1.CreateGeometryProxy(tubeDefinition.WorkPlanes[2], out object tubePlane);
bend.CreateGeometryProxy(bendDefinition.WorkPlanes[2], out object bendPlane);

definition.Constraints.AddFlushConstraint(bendPlane, tubePlane, 0);
```

Now only the second tube's own rotation is left, so `freeDegreesOfFreedom` is 1. Take a screenshot with `view: "iso"` to confirm the direction. To point the other way, add an `AddAngleConstraint` between the same planes, or flip the bend's revolution direction in the part.

## Notes

- Occurrence names are "{file name}:{n}", as listed by `inspect` or the `changes` part of the result.
- `Occurrences.ItemByName[...]` finds top-level occurrences only. For nested ones, walk `SubOccurrences` (`topology` takes the same path, such as `"Frame:1/Bracket:2"`, and prints the code), or look in `Occurrences.AllLeafOccurrences`.
- Constraint offsets and angles are `object`: a number in cm or radians, or an expression string such as `"10 mm"`.
- If a constraint fails or becomes sick, `inspect` shows its health. Try the other solution: flip `AxesOpposed`, or use `AddMateConstraint` instead of flush.

## Changing a size in an existing assembly

A size is rarely one parameter. Making a 1000 mm rail 1500 mm long took, on a real assembly:

1. The length parameter in each part that runs along the rail.
2. The hole and slot patterns in those parts: their spacing was 800 mm so that the end holes sat 100 mm from each end, so it had to become 1300 mm.
3. A component pattern in a subassembly that placed the second support 800 mm from the first.
4. `Rebuild()` of the top assembly: bolts inserted into holes at the moved end only followed after it.

Before changing anything, list what depends on the size: the parameters of each part (`get_Units()` gives their units), the patterns (`RectangularPatternFeature.XSpacing`, `RectangularOccurrencePattern.ColumnOffset`) and the constraint offsets. After the change, call `Update()` on each changed part and subassembly, then `Update()` and `Rebuild()` on the top assembly, and read `constraintsWithProblems` with `inspect`.

Changing a part that other assemblies use changes it everywhere. Files from a vault are read-only until they are checked out (`inspect` says `readOnlyFile`), so tell the user before saving.

## Large assemblies

- Every property read is a call into Inventor's process, about 0.4 to 1 ms. Reading only the names of 4,200 parts takes about 4 s; a loop that reads ten properties per part takes over a minute.
- Ask Inventor for what it already computes instead of looping: `MassProperties.Mass`, `RangeBox`, the BOM (`bom`), `Occurrences.AllLeafOccurrences.Count`.
- `bom` walks every level to add up the totals: about 20 s for 4,200 parts in 718 part numbers.
- To count a component or find where it is used, call `where_used`, or in a script ask for `Occurrences.AllReferencedOccurrences[document]`: every occurrence of that document at any depth. On one assembly, that took 0.35 s where walking the tree and reading each occurrence's iProperties took almost 10 minutes.
- Reference occurrences are left out of every BOM view, including Parts Only: a count from the BOM leaves them out. `where_used` lists them with their structure.
- A script that runs much longer than expected can be stopped with `script_cancel`: it stops at its next loop step and is rolled back.
