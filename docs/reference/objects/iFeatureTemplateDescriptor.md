# iFeatureTemplateDescriptor

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.iFeatureTemplateDescriptors.Item[…]`

```csharp
interface iFeatureTemplateDescriptor
{
    // Properties
    object Application { get; }
    string InternalName { get; }
    string LastKnownSourceFileName { get; }
    ComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void DelayReplaceAll(string NewSourceFilename);
}
```

**Returned by:** [PunchToolFeature](../objects/PunchToolFeature.md).iFeatureTemplateDescriptor, [PunchToolFeatureProxy](../objects/PunchToolFeatureProxy.md).iFeatureTemplateDescriptor, [iFeature](../objects/iFeature.md).iFeatureTemplateDescriptor, [iFeatureProxy](../objects/iFeatureProxy.md).iFeatureTemplateDescriptor, [iFeatureTemplateDescriptors](../objects/iFeatureTemplateDescriptors.md).Item

**Referenced types:** [ComponentDefinition](../objects/ComponentDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

