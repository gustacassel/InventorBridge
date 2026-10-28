# ModelCompositeAnnotations

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelCompositeAnnotations`

```csharp
interface ModelCompositeAnnotations
{
    // Properties
    object Application { get; }
    int Count { get; }
    ModelCompositeAnnotation Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ModelCompositeAnnotation Add(ModelCompositeAnnotationDefinition Definition, object ClientId = Missing);
    ModelCompositeAnnotationDefinition CreateDefinition(ModelAnnotation BaseAnnotation, object AnnotationType = Missing);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelAnnotations](../objects/ModelAnnotations.md).ModelCompositeAnnotations

**Referenced types:** [ModelAnnotation](../objects/ModelAnnotation.md), [ModelCompositeAnnotation](../objects/ModelCompositeAnnotation.md), [ModelCompositeAnnotationDefinition](../objects/ModelCompositeAnnotationDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

