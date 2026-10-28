# MarkGeometrySet

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.MarkFeatures.Item[…].Definition.AddGeometrySet(…)`

```csharp
interface MarkGeometrySet
{
    // Properties
    object Application { get; }
    ObjectCollection Geometries { get; set; }
    MarkStyle Style { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

**Returned by:** [MarkDefinition](../objects/MarkDefinition.md).AddGeometrySet, [MarkDefinition](../objects/MarkDefinition.md).MarkGeometrySetItem

**Referenced types:** [MarkStyle](../objects/MarkStyle.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

