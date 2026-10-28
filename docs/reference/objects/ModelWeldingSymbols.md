# ModelWeldingSymbols

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelWeldingSymbols`

```csharp
interface ModelWeldingSymbols
{
    // Properties
    object Application { get; }
    int Count { get; }
    ModelWeldingSymbol Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ModelWeldingSymbol Add(ModelWeldingSymbolDefinitions Definitions);
    ModelWeldingSymbolDefinitions CreateDefinitions(ObjectCollection LeaderPoints, AnnotationPlaneDefinition AnnotationPlaneDefinition);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelAnnotations](../objects/ModelAnnotations.md).ModelWeldingSymbols

**Referenced types:** [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md), [ModelWeldingSymbol](../objects/ModelWeldingSymbol.md), [ModelWeldingSymbolDefinitions](../objects/ModelWeldingSymbolDefinitions.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

