# DirectEditDeleteOperationProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface DirectEditDeleteOperationProxy
{
    // Properties
    object Application { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    DirectEditOperationTypeEnum DirectEditOperationType { get; }
    Faces Faces { get; }
    string Name { get; }
    DirectEditDeleteOperation NativeObject { get; }
    DirectEditFeature Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete(bool RetainConsumedSketches = false, bool RetainDependentFeaturesAndSketches = false, bool RetainDependentWorkFeatures = false);
}
```

**Referenced types:** [ComponentOccurrence](../objects/ComponentOccurrence.md), [DirectEditDeleteOperation](../objects/DirectEditDeleteOperation.md), [DirectEditFeature](../objects/DirectEditFeature.md), [DirectEditOperationTypeEnum](../enums/DirectEditOperationTypeEnum.md), [Faces](../objects/Faces.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

