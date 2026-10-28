# ModelDatumDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelDatums.Item[…].Definition`

```csharp
interface ModelDatumDefinition
{
    // Properties
    object Application { get; }
    double[] DatumTargetAreaDiameters { get; set; }
    double[] DatumTargetAreaHeights { get; set; }
    double[] DatumTargetAreaWidths { get; set; }
    int[] DatumTargetIndices { get; set; }
    ObjectCollection DatumTargetPlanes { get; set; }
    ObjectCollection DatumTargetPoints { get; set; }
    ObjectCollection DatumTargetTextPositions { get; set; }
    ModelDatumTargetTypeEnum DatumTargetType { get; set; }
    string DatumText { get; set; }
    ModelDatum Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void ApplySizeToAllDatumTargets(double DiameterOrWidth, object Height = Missing);
    ModelDatumDefinition Copy();
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelDatum](../objects/ModelDatum.md).Definition, [ModelDatumDefinition](../objects/ModelDatumDefinition.md).Copy, [ModelDatumProxy](../objects/ModelDatumProxy.md).Definition, [ModelDatums](../objects/ModelDatums.md).CreateDefinition

**Referenced types:** [ModelDatum](../objects/ModelDatum.md), [ModelDatumTargetTypeEnum](../enums/ModelDatumTargetTypeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

