# ModelAnnotationsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.AnnotationPlanes.Item[…].Annotations`

```csharp
interface ModelAnnotationsEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    ModelAnnotation Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AnnotationPlane](../objects/AnnotationPlane.md).Annotations, [AnnotationPlaneProxy](../objects/AnnotationPlaneProxy.md).Annotations, [ModelCompositeAnnotationDefinition](../objects/ModelCompositeAnnotationDefinition.md).Annotations

**Referenced types:** [ModelAnnotation](../objects/ModelAnnotation.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

