# Parts

> Modeling parts: a sketch, a profile, an extrusion or a revolution, naming the edges a later step needs, saving.

Status: the scripts below compile against the Inventor 2024 interop but have not yet been run on a real Inventor.

## The pattern

1. Create the document from the part template.
2. Draw a sketch on a work plane. Sketch coordinates are 2D and in cm.
3. Make a `Profile` from the sketch with `Profiles.AddForSolid()`. Concentric circles give a ring.
4. Add a feature: extrusion, revolution, sweep...
5. Name the faces or edges that a later step needs.
6. Save under `WorkspacePath`.

Origin planes and axes: `WorkPlanes[1]` is YZ, `[2]` is XZ, `[3]` is XY. `WorkAxes[1]` is X, `[2]` is Y, `[3]` is Z. On the XY plane, the sketch's X and Y are the model's X and Y.

## A tube (extrusion of a ring)

Outer diameter 50 mm, wall 3 mm, length 500 mm, along +Z from the origin. A matching `expect` is `{"volumeMm3": 221482.3, "sizeMm": [50, 50, 500], "bodies": 1}`, where the volume is π(25² − 22²)·500.

```csharp
double outerRadius = Mm(25), innerRadius = Mm(22), length = Mm(500);

string template = App.FileManager.GetTemplateFile(DocumentTypeEnum.kPartDocumentObject);
var part = (PartDocument)App.Documents.Add(DocumentTypeEnum.kPartDocumentObject, template, true);
PartComponentDefinition definition = part.ComponentDefinition;

PlanarSketch sketch = definition.Sketches.Add(definition.WorkPlanes[3]);
sketch.SketchCircles.AddByCenterRadius(Geometry.CreatePoint2d(0, 0), outerRadius);
sketch.SketchCircles.AddByCenterRadius(Geometry.CreatePoint2d(0, 0), innerRadius);
Profile profile = sketch.Profiles.AddForSolid();

ExtrudeDefinition extrude = definition.Features.ExtrudeFeatures.CreateExtrudeDefinition(profile, PartFeatureOperationEnum.kJoinOperation);
extrude.SetDistanceExtent(length, PartFeatureExtentDirectionEnum.kPositiveExtentDirection);
definition.Features.ExtrudeFeatures.Add(extrude);

// Name the outer circular edges at both ends, for the assembly constraints.
foreach (Edge edge in definition.SurfaceBodies[1].Edges)
{
    if (edge.Geometry is Circle circle && Math.Abs(circle.Radius - outerRadius) < 1e-6)
    {
        Name(edge, circle.Center.Z < length / 2 ? "start" : "end");
    }
}

string path = System.IO.Path.Combine(WorkspacePath ?? "", "Tube-50x3x500.ipt");
if (System.IO.File.Exists(path))
{
    throw new InvalidOperationException(path + " already exists: ask the user before overwriting it.");
}

part.SaveAs(path, false);
return path;
```

## A 90° bend (revolution of a ring)

Same tube section, 100 mm bend radius to the centerline. The ring is drawn on the XY plane at x = 100 mm and turned 90° about the Y axis. The start end lies in the XY plane, centered at (100, 0, 0). The other end lies in the YZ plane, centered on the Z axis. The volume is π(25² − 22²)·(π/2·100) ≈ 69580.6 mm³.

```csharp
double outerRadius = Mm(25), innerRadius = Mm(22), bendRadius = Mm(100);

string template = App.FileManager.GetTemplateFile(DocumentTypeEnum.kPartDocumentObject);
var part = (PartDocument)App.Documents.Add(DocumentTypeEnum.kPartDocumentObject, template, true);
PartComponentDefinition definition = part.ComponentDefinition;

PlanarSketch sketch = definition.Sketches.Add(definition.WorkPlanes[3]);
sketch.SketchCircles.AddByCenterRadius(Geometry.CreatePoint2d(bendRadius, 0), outerRadius);
sketch.SketchCircles.AddByCenterRadius(Geometry.CreatePoint2d(bendRadius, 0), innerRadius);
Profile profile = sketch.Profiles.AddForSolid();

definition.Features.RevolveFeatures.AddByAngle(profile, definition.WorkAxes[2], Deg(90),
    PartFeatureExtentDirectionEnum.kPositiveExtentDirection, PartFeatureOperationEnum.kJoinOperation);

foreach (Edge edge in definition.SurfaceBodies[1].Edges)
{
    if (edge.Geometry is Circle circle && Math.Abs(circle.Radius - outerRadius) < 1e-6)
    {
        Name(edge, Math.Abs(circle.Center.Z) < 1e-6 ? "start" : "end");
    }
}

string path = System.IO.Path.Combine(WorkspacePath ?? "", "Bend-50x3-R100.ipt");
if (System.IO.File.Exists(path))
{
    throw new InvalidOperationException(path + " already exists: ask the user before overwriting it.");
}

part.SaveAs(path, false);
return path;
```

## Notes

- `SetDistanceExtent`, `AddByAngle` and other `object` arguments take a number in API units (cm, radians). Many also take an expression string such as `"500 mm"`. A user parameter name works too, which keeps the model editable.
- To work from parameters, add them first with `definition.Parameters.UserParameters.AddByExpression("Length", "500 mm", "mm")`, then pass `"Length"` as the distance.
- To find a face or edge at a known position without looping, use `body.LocateUsingPoint(ObjectTypeEnum.kEdgeObject, point)`, with the point in cm.
