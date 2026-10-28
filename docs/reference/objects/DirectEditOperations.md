# DirectEditOperations

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.DirectEditFeatures.Item[…].DirectEditOperations`

```csharp
interface DirectEditOperations
{
    // Properties
    object Application { get; }
    int Count { get; }
    DirectEditOperation Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DirectEditFeature](../objects/DirectEditFeature.md).DirectEditOperations, [DirectEditFeatureProxy](../objects/DirectEditFeatureProxy.md).DirectEditOperations

**Referenced types:** [DirectEditOperation](../objects/DirectEditOperation.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

