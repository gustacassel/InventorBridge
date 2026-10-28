# AnnotationPlaneDefinitionsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.CreateAnnotationPlaneDefinitionUsingIntents(…)`

```csharp
interface AnnotationPlaneDefinitionsEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    AnnotationPlaneDefinition Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelAnnotations](../objects/ModelAnnotations.md).CreateAnnotationPlaneDefinitionUsingIntents

**Referenced types:** [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

