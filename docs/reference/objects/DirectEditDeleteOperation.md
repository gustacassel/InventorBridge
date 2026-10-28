# DirectEditDeleteOperation

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface DirectEditDeleteOperation
{
    // Properties
    object Application { get; }
    DirectEditOperationTypeEnum DirectEditOperationType { get; }
    Faces Faces { get; }
    string Name { get; }
    DirectEditFeature Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete(bool RetainConsumedSketches = false, bool RetainDependentFeaturesAndSketches = false, bool RetainDependentWorkFeatures = false);
}
```

**Returned by:** [DirectEditDeleteOperationProxy](../objects/DirectEditDeleteOperationProxy.md).NativeObject

**Referenced types:** [DirectEditFeature](../objects/DirectEditFeature.md), [DirectEditOperationTypeEnum](../enums/DirectEditOperationTypeEnum.md), [Faces](../objects/Faces.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

