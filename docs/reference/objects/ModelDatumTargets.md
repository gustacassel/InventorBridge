# ModelDatumTargets

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelDatums.Item[…].ModelDatumTargets`

```csharp
interface ModelDatumTargets
{
    // Properties
    object Application { get; }
    int Count { get; }
    ModelDatumTarget Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelDatum](../objects/ModelDatum.md).ModelDatumTargets, [ModelDatumProxy](../objects/ModelDatumProxy.md).ModelDatumTargets

**Referenced types:** [ModelDatumTarget](../objects/ModelDatumTarget.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

