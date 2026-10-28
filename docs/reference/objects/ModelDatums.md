# ModelDatums

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelDatums`

```csharp
interface ModelDatums
{
    // Properties
    object Application { get; }
    int Count { get; }
    ModelDatum Item[object Index] { get; }
    string NextAvailableDatumText { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ModelDatum Add(ModelDatumDefinition Definition);
    ModelDatumDefinition CreateDefinition(ObjectCollection DatumTargetPoints, object DatumTargetPlanes = Missing, object DatumTargetTextPositions = Missing, object DatumTargetIndices = Missing, object DatumTargetType = Missing, object DatumTargetAreaValueOne = Missing, object DatumTargetAreaValueTwo = Missing, object DatumText = Missing);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelAnnotations](../objects/ModelAnnotations.md).ModelDatums

**Referenced types:** [ModelDatum](../objects/ModelDatum.md), [ModelDatumDefinition](../objects/ModelDatumDefinition.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

