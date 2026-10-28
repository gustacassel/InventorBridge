# ModelLeaderNotes

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelLeaderNotes`

```csharp
interface ModelLeaderNotes
{
    // Properties
    object Application { get; }
    int Count { get; }
    ModelLeaderNote Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ModelLeaderNote Add(ModelLeaderNoteDefinition Definition);
    ModelLeaderNoteDefinition CreateDefinition(ObjectCollection LeaderPoints, string FormattedText, AnnotationPlaneDefinition AnnotationPlaneDefinition);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelAnnotations](../objects/ModelAnnotations.md).ModelLeaderNotes

**Referenced types:** [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md), [ModelLeaderNote](../objects/ModelLeaderNote.md), [ModelLeaderNoteDefinition](../objects/ModelLeaderNoteDefinition.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

