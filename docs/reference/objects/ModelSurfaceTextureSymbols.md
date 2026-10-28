# ModelSurfaceTextureSymbols

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelSurfaceTextureSymbols`

```csharp
interface ModelSurfaceTextureSymbols
{
    // Properties
    object Application { get; }
    int Count { get; }
    ModelSurfaceTextureSymbol Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ModelSurfaceTextureSymbol Add(ModelSurfaceTextureSymbolDefinition Definition);
    ModelSurfaceTextureSymbolDefinition CreateDefinition(ObjectCollection LeaderPoints, AnnotationPlaneDefinition AnnotationPlaneDefinition);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelAnnotations](../objects/ModelAnnotations.md).ModelSurfaceTextureSymbols

**Referenced types:** [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md), [ModelSurfaceTextureSymbol](../objects/ModelSurfaceTextureSymbol.md), [ModelSurfaceTextureSymbolDefinition](../objects/ModelSurfaceTextureSymbolDefinition.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

