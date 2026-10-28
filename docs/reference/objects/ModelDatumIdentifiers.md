# ModelDatumIdentifiers

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelDatumIdentifiers`

```csharp
interface ModelDatumIdentifiers
{
    // Properties
    object Application { get; }
    int Count { get; }
    string ExcludedDatumTextCharacters { get; }
    ModelDatumIdentifier Item[object Index] { get; }
    string NextAvailableDatumText { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ModelDatumIdentifier Add(ModelDatumIdentifierDefinition Definition);
    ModelDatumIdentifierDefinition CreateDefinition(GeometryIntent Intent, AnnotationPlaneDefinition AnnotationPlaneDefinition, Point TextPosition);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelAnnotations](../objects/ModelAnnotations.md).ModelDatumIdentifiers

**Referenced types:** [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md), [GeometryIntent](../objects/GeometryIntent.md), [ModelDatumIdentifier](../objects/ModelDatumIdentifier.md), [ModelDatumIdentifierDefinition](../objects/ModelDatumIdentifierDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

