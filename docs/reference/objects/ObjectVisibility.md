# ObjectVisibility

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ObjectVisibility`

```csharp
interface ObjectVisibility
{
    // Properties
    bool AllWorkFeatures { get; set; }
    bool Annotations3D { get; set; }
    object Application { get; }
    bool ComponentAnnotations3D { get; set; }
    bool ConstructionSurfaces { get; set; }
    bool GroupDiagnostics { get; set; }
    bool GroupSolids { get; set; }
    bool GroupSurfaces { get; set; }
    bool GroupWires { get; set; }
    bool OriginWorkAxes { get; set; }
    bool OriginWorkPlanes { get; set; }
    bool OriginWorkPoints { get; set; }
    Document Parent { get; }
    bool SketchDimensions { get; set; }
    bool Sketches { get; set; }
    bool Sketches3D { get; set; }
    ObjectTypeEnum Type { get; }
    bool UCSTriads { get; set; }
    bool UCSWorkAxes { get; set; }
    bool UCSWorkPlanes { get; set; }
    bool UCSWorkPoints { get; set; }
    bool UserWorkAxes { get; set; }
    bool UserWorkPlanes { get; set; }
    bool UserWorkPoints { get; set; }
    bool WeldmentSymbols { get; set; }
    bool Welds { get; set; }
}
```

**Returned by:** [AssemblyDocument](../objects/AssemblyDocument.md).ObjectVisibility, [PartDocument](../objects/PartDocument.md).ObjectVisibility

**Referenced types:** [Document](../objects/Document.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

