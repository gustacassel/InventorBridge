# AnnotationPlaneProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface AnnotationPlaneProxy
{
    // Properties
    ModelAnnotationsEnumerator Annotations { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    AnnotationPlaneDefinition Definition { get; }
    AnnotationPlane NativeObject { get; }
    ComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AnnotationPlane](../objects/AnnotationPlane.md), [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md), [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ModelAnnotationsEnumerator](../objects/ModelAnnotationsEnumerator.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

