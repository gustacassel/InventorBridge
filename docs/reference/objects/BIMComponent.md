# BIMComponent

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.BIMComponent`

```csharp
interface BIMComponent
{
    // Properties
    object Application { get; }
    ComponentDefinition ComponentDefinition { get; }
    BIMComponentDescription ComponentDescription { get; }
    BIMConnectorLinks ConnectorLinks { get; }
    BIMConnectors Connectors { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void ExportBuildingComponent(string FullFileName);
    void ExportBuildingComponentWithOptions(string FullFileName, NameValueMap pOptions);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).BIMComponent, [BIMComponentPropertySet](../objects/BIMComponentPropertySet.md).Parent, [BIMConnector](../objects/BIMConnector.md).Parent, [BIMExchangeServer](../objects/BIMExchangeServer.md).GetBIMComponent, [PartComponentDefinition](../objects/PartComponentDefinition.md).BIMComponent, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).BIMComponent, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).BIMComponent

**Referenced types:** [BIMComponentDescription](../objects/BIMComponentDescription.md), [BIMConnectorLinks](../objects/BIMConnectorLinks.md), [BIMConnectors](../objects/BIMConnectors.md), [ComponentDefinition](../objects/ComponentDefinition.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

