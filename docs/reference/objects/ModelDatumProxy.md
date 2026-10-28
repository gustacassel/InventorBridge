# ModelDatumProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ModelDatum](../objects/ModelDatum.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelDatums.Item[…] → (ModelDatumProxy)`

```csharp
interface ModelDatumProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    ModelDatumDefinition Definition { get; set; }
    HealthStatusEnum HealthStatus { get; }
    ModelDatumTargets ModelDatumTargets { get; }
    string Name { get; set; }
    ModelDatum NativeObject { get; }
    ComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ModelDatum](../objects/ModelDatum.md), [ModelDatumDefinition](../objects/ModelDatumDefinition.md), [ModelDatumTargets](../objects/ModelDatumTargets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

