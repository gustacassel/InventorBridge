# ModelCompositeAnnotationDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.Item[…].CompositeAnnotation.Definition`

```csharp
interface ModelCompositeAnnotationDefinition
{
    // Properties
    ModelAnnotationsEnumerator Annotations { get; }
    object Application { get; }
    ModelAnnotation BaseAnnotation { get; }
    ModelCompositeAnnotation Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void AddAnnotation(ModelAnnotation ModelAnnotation);
    ModelCompositeAnnotationDefinition Copy();
    void RemoveAnnotation(ModelAnnotation ModelAnnotation);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelCompositeAnnotation](../objects/ModelCompositeAnnotation.md).Definition, [ModelCompositeAnnotationDefinition](../objects/ModelCompositeAnnotationDefinition.md).Copy, [ModelCompositeAnnotationProxy](../objects/ModelCompositeAnnotationProxy.md).Definition, [ModelCompositeAnnotations](../objects/ModelCompositeAnnotations.md).CreateDefinition

**Referenced types:** [ModelAnnotation](../objects/ModelAnnotation.md), [ModelAnnotationsEnumerator](../objects/ModelAnnotationsEnumerator.md), [ModelCompositeAnnotation](../objects/ModelCompositeAnnotation.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

