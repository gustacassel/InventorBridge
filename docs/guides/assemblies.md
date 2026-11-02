# Assemblies

> Placing saved parts, connecting them with constraints through named edges and proxies, checking degrees of freedom.

Status: the scripts below compile against the Inventor 2024 interop but have not yet been run on a real Inventor.

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
- `Occurrences.ItemByName[...]` finds top-level occurrences only. For nested ones, look in `Occurrences.AllLeafOccurrences`.
- Constraint offsets and angles are `object`: a number in cm or radians, or an expression string such as `"10 mm"`.
- If a constraint fails or becomes sick, `inspect` shows its health. Try the other solution: flip `AxesOpposed`, or use `AddMateConstraint` instead of flush.
