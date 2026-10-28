# ModelWeldingSymbolDefinitions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelWeldingSymbols.Item[…].Definitions`

```csharp
interface ModelWeldingSymbolDefinitions
{
    // Properties
    AnnotationPlane AnnotationPlane { get; set; }
    AnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    object Application { get; }
    ObjectCollection AssociatedGeometries { get; set; }
    int Count { get; }
    GeometryIntent Intent { get; set; }
    ModelWeldingSymbolDefinition Item[int Index] { get; }
    ModelLeader Leader { get; }
    Point Position { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    ModelWeldingSymbolDefinition Add(object TargetIndex = Missing);
    ModelWeldingSymbolDefinition AddFromWeldBead(object WeldBead, object TargetIndex = Missing); // since 2025
    ModelWeldingSymbolDefinitions Copy();
    void Remove(int Index);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelWeldingSymbol](../objects/ModelWeldingSymbol.md).Definitions, [ModelWeldingSymbolDefinitions](../objects/ModelWeldingSymbolDefinitions.md).Copy, [ModelWeldingSymbolProxy](../objects/ModelWeldingSymbolProxy.md).Definitions, [ModelWeldingSymbols](../objects/ModelWeldingSymbols.md).CreateDefinitions

**Referenced types:** [AnnotationPlane](../objects/AnnotationPlane.md), [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md), [GeometryIntent](../objects/GeometryIntent.md), [ModelLeader](../objects/ModelLeader.md), [ModelWeldingSymbolDefinition](../objects/ModelWeldingSymbolDefinition.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

