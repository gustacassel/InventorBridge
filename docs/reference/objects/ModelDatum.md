# ModelDatum

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelDatums.Item[…]`

```csharp
interface ModelDatum
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ModelDatumDefinition Definition { get; set; }
    HealthStatusEnum HealthStatus { get; }
    ModelDatumTargets ModelDatumTargets { get; }
    string Name { get; set; }
    ComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelDatumDefinition](../objects/ModelDatumDefinition.md).Parent, [ModelDatumProxy](../objects/ModelDatumProxy.md).NativeObject, [ModelDatumTarget](../objects/ModelDatumTarget.md).ModelDatum, [ModelDatumTargetProxy](../objects/ModelDatumTargetProxy.md).ModelDatum, [ModelDatums](../objects/ModelDatums.md).Add, [ModelDatums](../objects/ModelDatums.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ModelDatumDefinition](../objects/ModelDatumDefinition.md), [ModelDatumTargets](../objects/ModelDatumTargets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

