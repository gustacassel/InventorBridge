# ModelGeneralNoteDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelGeneralNotes.Item[…].Definition`

```csharp
interface ModelGeneralNoteDefinition
{
    // Properties
    AnnotationPlane AnnotationPlane { get; set; }
    AnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    object Application { get; }
    GeometryIntent Intent { get; set; }
    bool OnScreen { get; }
    ModelAnnotation Parent { get; }
    Point Position { get; set; }
    IntPtr ScreenQuadrant { get; set; }
    bool ShowTextBorder { get; set; }
    GeneralNoteSymbolDefinitions SymbolDefinitions { get; }
    ModelAnnotationText Text { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ModelGeneralNoteDefinition Copy();
    void SetToModelSpaceDisplay(AnnotationPlaneDefinition AnnotationPlaneDefinition, object Intent, object Position = Missing);
    void SetToOnScreenDisplay(object ScreenQuadrant = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [GeneralNoteSymbolDefinition](../objects/GeneralNoteSymbolDefinition.md).Parent, [ModelGeneralNote](../objects/ModelGeneralNote.md).Definition, [ModelGeneralNoteDefinition](../objects/ModelGeneralNoteDefinition.md).Copy, [ModelGeneralNoteProxy](../objects/ModelGeneralNoteProxy.md).Definition, [ModelGeneralNotes](../objects/ModelGeneralNotes.md).CreateDefinition

**Referenced types:** [AnnotationPlane](../objects/AnnotationPlane.md), [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md), [GeneralNoteSymbolDefinitions](../objects/GeneralNoteSymbolDefinitions.md), [GeometryIntent](../objects/GeometryIntent.md), [ModelAnnotation](../objects/ModelAnnotation.md), [ModelAnnotationText](../objects/ModelAnnotationText.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

