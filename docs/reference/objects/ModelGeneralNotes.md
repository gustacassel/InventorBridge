# ModelGeneralNotes

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelGeneralNotes`

```csharp
interface ModelGeneralNotes
{
    // Properties
    object Application { get; }
    int Count { get; }
    ModelGeneralNote Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ModelGeneralNote Add(ModelGeneralNoteDefinition Definition);
    ModelGeneralNoteDefinition CreateDefinition(string FormattedText, bool OnScreen, object ScreenQuadrant = Missing, object AnnotationPlaneDefinition = Missing);
    ModelFeatureControlFrameDefinition CreateEmbeddedFeatureControlFrameDefinition();
    ModelSurfaceTextureSymbolDefinition CreateEmbeddedSurfaceTextureSymbolDefinition();
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelAnnotations](../objects/ModelAnnotations.md).ModelGeneralNotes

**Referenced types:** [ModelFeatureControlFrameDefinition](../objects/ModelFeatureControlFrameDefinition.md), [ModelGeneralNote](../objects/ModelGeneralNote.md), [ModelGeneralNoteDefinition](../objects/ModelGeneralNoteDefinition.md), [ModelSurfaceTextureSymbolDefinition](../objects/ModelSurfaceTextureSymbolDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

