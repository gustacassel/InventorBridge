# ClientFeatureDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.ClientFeatures.Item[…].Definition`

```csharp
interface ClientFeatureDefinition
{
    // Properties
    object Application { get; }
    ClientFeatureElements ClientFeatureElements { get; }
    ClientGraphicsCollection ClientGraphicsCollection { get; }
    ObjectCollection FeatureInputs { get; set; }
    string FeatureType { get; }
    GraphicsDataSetsCollection GraphicsDataSetsCollection { get; }
    bool HighlightClientGraphicsWithFeature { get; set; }
    ClientFeature Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void AddDependency(object Dependency);
    void RemoveDependency(object Dependency);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ClientFeature](../objects/ClientFeature.md).Definition, [ClientFeatureElement](../objects/ClientFeatureElement.md).Parent, [ClientFeatureElementProxy](../objects/ClientFeatureElementProxy.md).Parent, [ClientFeatureProxy](../objects/ClientFeatureProxy.md).Definition, [ClientFeatures](../objects/ClientFeatures.md).CreateDefinition

**Referenced types:** [ClientFeature](../objects/ClientFeature.md), [ClientFeatureElements](../objects/ClientFeatureElements.md), [ClientGraphicsCollection](../objects/ClientGraphicsCollection.md), [GraphicsDataSetsCollection](../objects/GraphicsDataSetsCollection.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

