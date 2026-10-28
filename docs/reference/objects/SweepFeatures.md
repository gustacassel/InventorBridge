# SweepFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.SweepFeatures`

```csharp
interface SweepFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    SweepFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SweepFeature Add(SweepDefinition Definition);
    SweepFeature AddSolidSweep(SolidSweepDefinition Definition);
    SolidSweepDefinition CreateSolidSweepDefinition(SurfaceBody ToolBody, Path Path, PartFeatureOperationEnum Operation, ObjectCollection AffectedBodies, bool KeepToolbody = false);
    SweepDefinition CreateSweepDefinition(SweepTypeEnum SweepType, Profile Profile, Path Path, PartFeatureOperationEnum Operation);
}
```

9 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Features](../objects/Features.md).SweepFeatures, [FlatPatternFeatures](../objects/FlatPatternFeatures.md).SweepFeatures, [PartFeatures](../objects/PartFeatures.md).SweepFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).SweepFeatures

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureOperationEnum](../enums/PartFeatureOperationEnum.md), [Path](../objects/Path.md), [Profile](../objects/Profile.md), [SolidSweepDefinition](../objects/SolidSweepDefinition.md), [SurfaceBody](../objects/SurfaceBody.md), [SweepDefinition](../objects/SweepDefinition.md), [SweepFeature](../objects/SweepFeature.md), [SweepTypeEnum](../enums/SweepTypeEnum.md)

