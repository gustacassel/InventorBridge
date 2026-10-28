# ClientFeatureElementProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ClientFeatureElementProxy
{
    // Properties
    object Application { get; }
    bool BrowserVisible { get; set; }
    ComponentOccurrence ContainingOccurrence { get; }
    object Element { get; }
    bool HighlightWithFeature { get; set; }
    ClientFeatureElement NativeObject { get; }
    ClientFeatureDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    bool UserEditable { get; set; }
    // Methods
    void Delete();
}
```

**Referenced types:** [ClientFeatureDefinition](../objects/ClientFeatureDefinition.md), [ClientFeatureElement](../objects/ClientFeatureElement.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

