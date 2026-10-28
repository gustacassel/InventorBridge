# CombineFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.CombineFeatures`

```csharp
interface CombineFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    CombineFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    CombineFeature Add(SurfaceBody BaseBody, ObjectCollection ToolBodies, PartFeatureOperationEnum Operation, bool KeepToolBodies = false);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).CombineFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).CombineFeatures

**Referenced types:** [CombineFeature](../objects/CombineFeature.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureOperationEnum](../enums/PartFeatureOperationEnum.md), [SurfaceBody](../objects/SurfaceBody.md)

