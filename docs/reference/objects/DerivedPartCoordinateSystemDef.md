# DerivedPartCoordinateSystemDef

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [DerivedPartDefinition](../objects/DerivedPartDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.DerivedPartComponents.Item[…].Definition → (DerivedPartCoordinateSystemDef)`

```csharp
interface DerivedPartCoordinateSystemDef
{
    // Properties
    string ActiveDesignViewRepresentation { get; set; }
    string ActiveModelState { get; set; }
    object Application { get; }
    DerivedComponentStyleEnum DeriveStyle { get; set; }
    DerivedPartEntities Finishes { get; } // since 2025
    bool IncludeAllParameters { get; set; }
    DerivedComponentOptionEnum IncludeAllSolids { get; set; }
    DerivedComponentOptionEnum IncludeAllSurfaces { get; set; }
    DerivedComponentOptionEnum IncludeAlliMateDefinitions { get; set; }
    bool IsAssociativeDesignView { get; set; }
    bool LinkFaceColorFromSource { get; set; }
    bool LinkSheetMetalStyles { get; set; }
    bool LinkSketchFormattingFromSource { get; set; }
    DerivedPartMirrorPlaneEnum MirrorPlane { get; set; }
    DerivedPartEntities Parameters { get; }
    bool ReducedMemoryMode { get; set; }
    DerivedPartEntities Solids { get; }
    DerivedPartEntities Surfaces { get; }
    ObjectTypeEnum Type { get; }
    bool UseOrientedMinimumBoundingBox { get; set; }
    DerivedPartEntities iMateDefinitions { get; }
    // Methods
    void ExcludeAll();
    void GetCoordinateSystem(out Point Origin, out Vector XAxis, out Vector YAxis, out Vector ZAxis);
    void GetScale(out double XScale, out double YScale, out double ZScale);
    void IncludeAll();
    void SetCoordinateSystem(Point Origin, Vector XAxis, Vector YAxis);
    void SetScale(double XScale, double YScale, double ZScale);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DerivedPartComponents](../objects/DerivedPartComponents.md).CreateCoordinateSystemDef

**Referenced types:** [DerivedComponentOptionEnum](../enums/DerivedComponentOptionEnum.md), [DerivedComponentStyleEnum](../enums/DerivedComponentStyleEnum.md), [DerivedPartEntities](../objects/DerivedPartEntities.md), [DerivedPartMirrorPlaneEnum](../enums/DerivedPartMirrorPlaneEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [Vector](../objects/Vector.md)

