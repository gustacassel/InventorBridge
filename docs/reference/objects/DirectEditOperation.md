# DirectEditOperation

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.DirectEditFeatures.Item[…].DirectEditOperations.Item[…]`

```csharp
interface DirectEditOperation
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

**Returned by:** [DirectEditOperationProxy](../objects/DirectEditOperationProxy.md).NativeObject, [DirectEditOperations](../objects/DirectEditOperations.md).Item

**Referenced types:** [DirectEditFeature](../objects/DirectEditFeature.md), [DirectEditOperationTypeEnum](../enums/DirectEditOperationTypeEnum.md), [Faces](../objects/Faces.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

