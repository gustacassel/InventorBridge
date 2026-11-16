# Parts

> Modeling parts: a sketch, a profile, an extrusion or a revolution, naming the edges a later step needs, saving.

Status: the scripts below ran on Inventor 2024.4 (2026-11-13), saved to a folder outside the project because an add-in intercepted saving there; the guide tests also compile them against the 2024 interop.

## The pattern

1. Create the file with `CreateDocument(DocumentTypeEnum.kPartDocumentObject, path)`, under `WorkspacePath`. It copies the default template, opens the copy and sets the part number to the file name.
2. Draw a sketch on a work plane. Sketch coordinates are 2D and in cm.
3. Make a `Profile` from the sketch with `Profiles.AddForSolid()`. Concentric circles give a ring.
4. Add a feature: extrusion, revolution, sweep...
5. Name the faces or edges that a later step needs.
6. Save with `part.Save()`. Unlike `Documents.Add` followed by `SaveAs`, this opens no "New file" dialog of add-ins that intercept saving (Vault Data Standard does).

Origin planes and axes: `WorkPlanes[1]` is YZ, `[2]` is XZ, `[3]` is XY. `WorkAxes[1]` is X, `[2]` is Y, `[3]` is Z. On the XY plane, the sketch's X and Y are the model's X and Y.

## A tube (extrusion of a ring)

Outer diameter 50 mm, wall 3 mm, length 500 mm, along +Z from the origin. A matching `expect` is `{"volumeMm3": 221482.3, "sizeMm": [50, 50, 500], "bodies": 1}`, where the volume is π(25² − 22²)·500.

```csharp
double outerRadius = Mm(25), innerRadius = Mm(22), length = Mm(500);

string path = System.IO.Path.Combine(WorkspacePath ?? "", "Tube-50x3x500.ipt");
// Copies the part template to the new file (it fails if the file exists) and opens it.
var part = (PartDocument)CreateDocument(DocumentTypeEnum.kPartDocumentObject, path);
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

part.Save();
return path;
```

## A 90° bend (revolution of a ring)

Same tube section, 100 mm bend radius to the centerline. The ring is drawn on the XY plane at x = 100 mm and turned 90° about the Y axis. The start end lies in the XY plane, centered at (100, 0, 0). The other end lies in the YZ plane, centered on the Z axis. The volume is π(25² − 22²)·(π/2·100) ≈ 69580.6 mm³.

```csharp
double outerRadius = Mm(25), innerRadius = Mm(22), bendRadius = Mm(100);

string path = System.IO.Path.Combine(WorkspacePath ?? "", "Bend-50x3-R100.ipt");
// Copies the part template to the new file (it fails if the file exists) and opens it.
var part = (PartDocument)CreateDocument(DocumentTypeEnum.kPartDocumentObject, path);
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

part.Save();
return path;
```

## Holes and chamfers

Hole features, not circles cut by an extrusion, are what drawings read for hole and thread notes. Sketch the centers on the face the holes start from; from such a sketch, `kPositiveExtentDirection` goes into the material. A hole pointing the other way cuts nothing, and Inventor reports it as `kDriverLostHealth`.

```csharp
var part = (PartDocument)ActiveDocument;
var definition = part.ComponentDefinition;
SurfaceBody body = definition.SurfaceBodies[1];

// The top face of a 12 mm plate lying on the XY plane.
Face top = body.Faces.Cast<Face>().First(face =>
    face.SurfaceType == SurfaceTypeEnum.kPlaneSurface && Math.Abs(face.PointOnFace.Z - Mm(12)) < 1e-6);
PlanarSketch sketch = definition.Sketches.Add(top);
ObjectCollection clearance = Objects.CreateObjectCollection();
clearance.Add(sketch.SketchPoints.Add(sketch.ModelToSketchSpace(Geometry.CreatePoint(Mm(40), Mm(15), Mm(12))), true));
clearance.Add(sketch.SketchPoints.Add(sketch.ModelToSketchSpace(Geometry.CreatePoint(Mm(40), Mm(45), Mm(12))), true));
ObjectCollection tapped = Objects.CreateObjectCollection();
tapped.Add(sketch.SketchPoints.Add(sketch.ModelToSketchSpace(Geometry.CreatePoint(Mm(100), Mm(30), Mm(12))), true));

HoleFeatures holes = definition.Features.HoleFeatures;
HoleFeature through = holes.AddDrilledByThroughAllExtent(holes.CreateSketchPlacementDefinition(clearance), Mm(13),
    PartFeatureExtentDirectionEnum.kPositiveExtentDirection);
HoleTapInfo thread = holes.CreateTapInfo(true, "ISO Metric profile", "M10x1.5", "6H", true);
HoleFeature threaded = holes.AddDrilledByThroughAllExtent(holes.CreateSketchPlacementDefinition(tapped), thread,
    PartFeatureExtentDirectionEnum.kPositiveExtentDirection);

// 5 mm chamfers on the straight edges along Z.
EdgeCollection corners = Objects.CreateEdgeCollection();
foreach (Edge edge in body.Edges)
{
    Point start = edge.StartVertex.Point, end = edge.StopVertex.Point;
    if (edge.GeometryType == CurveTypeEnum.kLineSegmentCurve && Math.Abs(start.X - end.X) < 1e-6 && Math.Abs(start.Y - end.Y) < 1e-6)
    {
        corners.Add(edge);
    }
}

definition.Features.ChamferFeatures.AddUsingDistance(corners, Mm(5));
return $"{through.HealthStatus}, {threaded.HealthStatus}, {corners.Count} edges chamfered";
```

Sheet metal parts come from a sheet metal template; their features are under `((SheetMetalFeatures)definition.Features)`: `FaceFeatures`, `FlangeFeatures` and the others. Cast `part.ComponentDefinition` to `SheetMetalComponentDefinition` for `Thickness`, `Unfold()` and `FlatPattern`.

## Notes

- `SetDistanceExtent`, `AddByAngle` and other `object` arguments take a number in API units (cm, radians). Many also take an expression string such as `"500 mm"`. A user parameter name works too, which keeps the model editable.
- To work from parameters, add them first with `definition.Parameters.UserParameters.AddByExpression("Length", "500 mm", "mm")`, then pass `"Length"` as the distance.
- To find a face or edge at a known position without looping, use `body.LocateUsingPoint(ObjectTypeEnum.kEdgeObject, point)`, with the point in cm.
