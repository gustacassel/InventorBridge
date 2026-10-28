# DerivedPartTransformDef

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [DerivedPartDefinition](../objects/DerivedPartDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.DerivedPartComponents.Item[…].Definition → (DerivedPartTransformDef)`

```csharp
interface DerivedPartTransformDef
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
    DerivedPartEntities Parameters { get; }
    bool ReducedMemoryMode { get; set; }
    DerivedPartEntities Solids { get; }
    DerivedPartEntities Surfaces { get; }
    ObjectTypeEnum Type { get; }
    bool UseOrientedMinimumBoundingBox { get; set; }
    DerivedPartEntities iMateDefinitions { get; }
    // Methods
    void ExcludeAll();
    void GetTransformation(out Matrix Transform, out bool Mirror);
    void IncludeAll();
    void SetTransformation(Matrix Transform, bool Mirror = false);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DerivedPartComponents](../objects/DerivedPartComponents.md).CreateTransformDef

**Referenced types:** [DerivedComponentOptionEnum](../enums/DerivedComponentOptionEnum.md), [DerivedComponentStyleEnum](../enums/DerivedComponentStyleEnum.md), [DerivedPartEntities](../objects/DerivedPartEntities.md), [Matrix](../objects/Matrix.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

