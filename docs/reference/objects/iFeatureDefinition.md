# iFeatureDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.iFeatures.Item[…].iFeatureDefinition`

```csharp
interface iFeatureDefinition
{
    // Properties
    iFeatureTableRow ActiveTableRow { get; set; }
    object Application { get; }
    bool IsPunchTool { get; }
    bool IsTableDriven { get; }
    string PunchId { get; }
    ObjectTypeEnum Type { get; }
    iFeatureInputs iFeatureInputs { get; }
    iFeatureTable iFeatureTable { get; }
}
```

**Returned by:** [PunchToolFeature](../objects/PunchToolFeature.md).iFeatureDefinition, [PunchToolFeatureProxy](../objects/PunchToolFeatureProxy.md).iFeatureDefinition, [PunchToolFeatures](../objects/PunchToolFeatures.md).CreateiFeatureDefinition, [iFeature](../objects/iFeature.md).iFeatureDefinition, [iFeatureProxy](../objects/iFeatureProxy.md).iFeatureDefinition, [iFeatures](../objects/iFeatures.md).CreateiFeatureDefinition

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iFeatureInputs](../objects/iFeatureInputs.md), [iFeatureTable](../objects/iFeatureTable.md), [iFeatureTableRow](../objects/iFeatureTableRow.md)

