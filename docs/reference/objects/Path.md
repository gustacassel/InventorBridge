# Path

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.SweepFeatures.Item[…].SolidSweepDefinition.Path`

```csharp
interface Path
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Closed { get; }
    int Count { get; }
    PathEntity Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    Wires Wires { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ContourFlangeDefinition](../objects/ContourFlangeDefinition.md).Path, [Features](../objects/Features.md).CreatePath, [Features](../objects/Features.md).CreateSpecifiedPath, [FlatPatternFeatures](../objects/FlatPatternFeatures.md).CreatePath, [LoftedFlangeDefinition](../objects/LoftedFlangeDefinition.md).ProfileOne, [LoftedFlangeDefinition](../objects/LoftedFlangeDefinition.md).ProfileTwo, [PartFeatures](../objects/PartFeatures.md).CreatePath, [PartFeatures](../objects/PartFeatures.md).CreateSpecifiedPath, [PathEntity](../objects/PathEntity.md).Parent, [PathEntityProxy](../objects/PathEntityProxy.md).Parent, [PathProxy](../objects/PathProxy.md).NativeObject, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).CreatePath, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).CreateSpecifiedPath, [SolidSweepDefinition](../objects/SolidSweepDefinition.md).Path, [SweepDefinition](../objects/SweepDefinition.md).GuideRail, [SweepDefinition](../objects/SweepDefinition.md).Path

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PathEntity](../objects/PathEntity.md), [Wires](../objects/Wires.md)

