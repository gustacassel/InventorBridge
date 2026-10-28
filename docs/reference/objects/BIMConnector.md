# BIMConnector

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.BIMComponent.Connectors.Item[…]`

```csharp
interface BIMConnector
{
    // Properties
    object Application { get; }
    BIMConnectorDefinition Definition { get; }
    BIMConnectorDefinitionTypeEnum DefinitionType { get; }
    bool MissingAttachment { get; }
    string Name { get; set; }
    BIMComponent Parent { get; }
    bool Suppressed { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [BIMCableTrayConnectorDefinition](../objects/BIMCableTrayConnectorDefinition.md).Parent, [BIMConduitConnectorDefinition](../objects/BIMConduitConnectorDefinition.md).Parent, [BIMConnectorDefinition](../objects/BIMConnectorDefinition.md).Parent, [BIMConnectorLink](../objects/BIMConnectorLink.md).ConnectorOne, [BIMConnectorLink](../objects/BIMConnectorLink.md).ConnectorTwo, [BIMConnectors](../objects/BIMConnectors.md).Add, [BIMConnectors](../objects/BIMConnectors.md).Item, [BIMDuctConnectorDefinition](../objects/BIMDuctConnectorDefinition.md).Parent, [BIMElectricalConnectorDefinition](../objects/BIMElectricalConnectorDefinition.md).Parent, [BIMPipeConnectorDefinition](../objects/BIMPipeConnectorDefinition.md).Parent

**Referenced types:** [BIMComponent](../objects/BIMComponent.md), [BIMConnectorDefinition](../objects/BIMConnectorDefinition.md), [BIMConnectorDefinitionTypeEnum](../enums/BIMConnectorDefinitionTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

