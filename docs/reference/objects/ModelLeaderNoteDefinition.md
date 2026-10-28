# ModelLeaderNoteDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelLeaderNotes.Item[…].Definition`

```csharp
interface ModelLeaderNoteDefinition
{
    // Properties
    AnnotationPlane AnnotationPlane { get; set; }
    AnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    object Application { get; }
    ArrowheadTypeEnum ArrowheadType { get; set; }
    ObjectCollection AssociatedGeometries { get; set; }
    GeometryIntent Intent { get; set; }
    ModelLeader Leader { get; }
    ModelAnnotation Parent { get; }
    Point Position { get; set; }
    bool ShowTextBorder { get; set; }
    ModelAnnotationText Text { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ModelLeaderNoteDefinition Copy();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelLeaderNote](../objects/ModelLeaderNote.md).Definition, [ModelLeaderNoteDefinition](../objects/ModelLeaderNoteDefinition.md).Copy, [ModelLeaderNoteProxy](../objects/ModelLeaderNoteProxy.md).Definition, [ModelLeaderNotes](../objects/ModelLeaderNotes.md).CreateDefinition

**Referenced types:** [AnnotationPlane](../objects/AnnotationPlane.md), [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md), [ArrowheadTypeEnum](../enums/ArrowheadTypeEnum.md), [GeometryIntent](../objects/GeometryIntent.md), [ModelAnnotation](../objects/ModelAnnotation.md), [ModelAnnotationText](../objects/ModelAnnotationText.md), [ModelLeader](../objects/ModelLeader.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

