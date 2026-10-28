# DerivedPartDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.DerivedPartComponents.Item[…].Definition`

```csharp
interface DerivedPartDefinition
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
    void IncludeAll();
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DerivedPartComponent](../objects/DerivedPartComponent.md).Definition, [DerivedPartComponentProxy](../objects/DerivedPartComponentProxy.md).Definition

**Referenced types:** [DerivedComponentOptionEnum](../enums/DerivedComponentOptionEnum.md), [DerivedComponentStyleEnum](../enums/DerivedComponentStyleEnum.md), [DerivedPartEntities](../objects/DerivedPartEntities.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

