# AnnotationPlanes

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.AnnotationPlanes`

```csharp
interface AnnotationPlanes
{
    // Properties
    object Application { get; }
    int Count { get; }
    AnnotationPlane Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FlatPattern](../objects/FlatPattern.md).AnnotationPlanes, [PartComponentDefinition](../objects/PartComponentDefinition.md).AnnotationPlanes, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).AnnotationPlanes

**Referenced types:** [AnnotationPlane](../objects/AnnotationPlane.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

