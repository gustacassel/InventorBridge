# ModelDatumIdentifierDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelDatumIdentifiers.Item[…].Definition`

```csharp
interface ModelDatumIdentifierDefinition
{
    // Properties
    AnnotationPlane AnnotationPlane { get; set; }
    AnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    object Application { get; }
    ArrowheadTypeEnum ArrowheadType { get; set; }
    string DatumText { get; set; }
    GeometryIntent Intent { get; set; }
    ModelDatumIdentifier Parent { get; }
    Point TextPosition { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    ModelDatumIdentifierDefinition Copy();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelDatumIdentifier](../objects/ModelDatumIdentifier.md).Definition, [ModelDatumIdentifierDefinition](../objects/ModelDatumIdentifierDefinition.md).Copy, [ModelDatumIdentifierProxy](../objects/ModelDatumIdentifierProxy.md).Definition, [ModelDatumIdentifiers](../objects/ModelDatumIdentifiers.md).CreateDefinition

**Referenced types:** [AnnotationPlane](../objects/AnnotationPlane.md), [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md), [ArrowheadTypeEnum](../enums/ArrowheadTypeEnum.md), [GeometryIntent](../objects/GeometryIntent.md), [ModelDatumIdentifier](../objects/ModelDatumIdentifier.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

