# iFeatureTemplateDescriptors

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.iFeatureTemplateDescriptors`

```csharp
interface iFeatureTemplateDescriptors
{
    // Properties
    object Application { get; }
    int Count { get; }
    iFeatureTemplateDescriptor Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ReferenceComponents](../objects/ReferenceComponents.md).iFeatureTemplateDescriptors

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iFeatureTemplateDescriptor](../objects/iFeatureTemplateDescriptor.md)

