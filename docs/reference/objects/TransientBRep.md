# TransientBRep

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientBRep`

```csharp
interface TransientBRep
{
    // Methods
    SurfaceBody Copy(object Entity);
    SurfaceBody CreateIntersectionWithPlane(SurfaceBody Body, Plane Plane);
    SurfaceBody CreateRuledSurface(Wire SectionOne, Wire SectionTwo);
    SurfaceBody CreateSilhouetteCurve(Face Face, UnitVector ViewDirection, bool ReturnCoincidentSilhouettes);
    SurfaceBody CreateSolidBlock(Box Box);
    SurfaceBody CreateSolidCylinderCone(Point BottomPoint, Point TopPoint, double BottomMajorRadius, double BottomMinorRadius, double TopMajorRadius, object MajorAxisPosition = Missing);
    SurfaceBody CreateSolidSphere(Point Center, double Radius);
    SurfaceBody CreateSolidTorus(Point Center, double MajorRadius, double MinorRadius);
    SurfaceBodyDefinition CreateSurfaceBodyDefinition();
    void DeleteFaces(object Faces, bool DeleteSpecifiedFaces);
    void DoBoolean(SurfaceBody BlankBody, SurfaceBody ToolBody, BooleanTypeEnum BooleanType);
    ObjectCollection GetIdenticalBodies(ObjectCollection InputSurfaceBodies, object Options = Missing);
    void ImprintBodies(SurfaceBody InputBodyOne, SurfaceBody InputBodyTwo, bool ImprintCoincidentEdges, out SurfaceBody OutputBodyOne, out SurfaceBody OutputBodyTwo, out Faces BodyOneOverlappingFaces, out Faces BodyTwoOverlappingFaces, out Edges BodyOneOverlappingEdges, out Edges BodyTwoOverlappingEdges, double Tolerance = 0);
    SurfaceBodies ReadFromFile(string FileName);
    void Transform(SurfaceBody SurfaceBody, Matrix Transform);
    void WriteToFile(ObjectCollection Bodies, string FileName, string Format = "");
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).TransientBRep, [InventorServer](../objects/InventorServer.md).TransientBRep

**Referenced types:** [BooleanTypeEnum](../enums/BooleanTypeEnum.md), [Box](../objects/Box.md), [Edges](../objects/Edges.md), [Face](../objects/Face.md), [Faces](../objects/Faces.md), [Matrix](../objects/Matrix.md), [ObjectCollection](../objects/ObjectCollection.md), [Plane](../objects/Plane.md), [Point](../objects/Point.md), [SurfaceBodies](../objects/SurfaceBodies.md), [SurfaceBody](../objects/SurfaceBody.md), [SurfaceBodyDefinition](../objects/SurfaceBodyDefinition.md), [UnitVector](../objects/UnitVector.md), [Wire](../objects/Wire.md)

