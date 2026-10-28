# DerivedFuturePartDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.DerivedFuturePartComponents.Item[…].Definition`

```csharp
interface DerivedFuturePartDefinition
{
    // Properties
    string ActiveDesignViewRepresentation { get; set; }
    object Application { get; }
    string FullFileName { get; }
    DerivedComponentOptionEnum IncludeAllSolids { get; set; }
    DerivedComponentOptionEnum IncludeAllSurfaces { get; set; }
    bool IsAssociativeDesignView { get; set; }
    DerivedPartEntities Solids { get; }
    DerivedPartEntities Surfaces { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void ExcludeAll();
    void IncludeAll();
}
```

**Returned by:** [DerivedFuturePartComponent](../objects/DerivedFuturePartComponent.md).Definition, [DerivedFuturePartComponentProxy](../objects/DerivedFuturePartComponentProxy.md).Definition

**Referenced types:** [DerivedComponentOptionEnum](../enums/DerivedComponentOptionEnum.md), [DerivedPartEntities](../objects/DerivedPartEntities.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

