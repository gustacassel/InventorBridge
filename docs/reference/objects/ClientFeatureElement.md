# ClientFeatureElement

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.ClientFeatures.Item[…].Definition.ClientFeatureElements.Item[…]`

```csharp
interface ClientFeatureElement
{
    // Properties
    object Application { get; }
    bool BrowserVisible { get; set; }
    object Element { get; }
    bool HighlightWithFeature { get; set; }
    ClientFeatureDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    bool UserEditable { get; set; }
    // Methods
    void Delete();
}
```

**Returned by:** [ClientFeatureElementProxy](../objects/ClientFeatureElementProxy.md).NativeObject, [ClientFeatureElements](../objects/ClientFeatureElements.md).Add, [ClientFeatureElements](../objects/ClientFeatureElements.md).Item

**Referenced types:** [ClientFeatureDefinition](../objects/ClientFeatureDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

