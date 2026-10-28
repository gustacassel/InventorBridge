# BIMConnectors

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.BIMComponent.Connectors`

```csharp
interface BIMConnectors
{
    // Properties
    object Application { get; }
    int Count { get; }
    BIMConnector Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    BIMConnector Add(BIMConnectorDefinition Definition, string Name = "");
    BIMCableTrayConnectorDefinition CreateCableTrayConnectorDefinition(ObjectCollection Geometry, BIMConnectorShapeEnum ConnectorShape);
    BIMConduitConnectorDefinition CreateConduitConnectorDefinition(ObjectCollection Geometry, BIMConnectorShapeEnum ConnectorShape);
    BIMDuctConnectorDefinition CreateDuctConnectorDefinition(ObjectCollection Geometry, BIMConnectorShapeEnum ConnectorShape);
    BIMElectricalConnectorDefinition CreateElectricalConnectorDefinition(ObjectCollection Geometry);
    BIMPipeConnectorDefinition CreatePipeConnectorDefinition(ObjectCollection Geometry, BIMConnectorShapeEnum ConnectorShape);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BIMComponent](../objects/BIMComponent.md).Connectors

**Referenced types:** [BIMCableTrayConnectorDefinition](../objects/BIMCableTrayConnectorDefinition.md), [BIMConduitConnectorDefinition](../objects/BIMConduitConnectorDefinition.md), [BIMConnector](../objects/BIMConnector.md), [BIMConnectorDefinition](../objects/BIMConnectorDefinition.md), [BIMConnectorShapeEnum](../enums/BIMConnectorShapeEnum.md), [BIMDuctConnectorDefinition](../objects/BIMDuctConnectorDefinition.md), [BIMElectricalConnectorDefinition](../objects/BIMElectricalConnectorDefinition.md), [BIMPipeConnectorDefinition](../objects/BIMPipeConnectorDefinition.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

