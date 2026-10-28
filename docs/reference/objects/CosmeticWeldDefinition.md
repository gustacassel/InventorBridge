# CosmeticWeldDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition → (WeldmentComponentDefinition).Welds.CosmeticWelds.Item[…].Definition`

```csharp
interface CosmeticWeldDefinition
{
    // Properties
    object Application { get; }
    object Area { get; set; }
    EdgeCollection Edges { get; set; }
    PartFeatureExtentEnum ExtentType { get; }
    object FromFace { get; }
    object ToFace { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    CosmeticWeldDefinition Copy();
    void SetFromToExtent(object FromFace, object ToFace);
    void SetThroughAllExtent();
}
```

**Returned by:** [CosmeticWeld](../objects/CosmeticWeld.md).Definition, [CosmeticWeldDefinition](../objects/CosmeticWeldDefinition.md).Copy, [CosmeticWelds](../objects/CosmeticWelds.md).CreateDefinition

**Referenced types:** [EdgeCollection](../objects/EdgeCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureExtentEnum](../enums/PartFeatureExtentEnum.md)

