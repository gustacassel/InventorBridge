# BIMConduitConnectorDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.BIMComponent.Connectors.CreateConduitConnectorDefinition(…)`

```csharp
interface BIMConduitConnectorDefinition
{
    // Properties
    object Application { get; }
    BIMConduitConnectionTypeEnum ConnectionType { get; set; }
    BIMConnectorShapeEnum ConnectorShape { get; }
    object Diameter { get; }
    object DiameterOverride { get; set; }
    UnitVector Direction { get; }
    ObjectCollection Geometry { get; }
    Point Origin { get; }
    BIMConnector Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void ReverseDirection();
    void SetShape(ObjectCollection Geometry, BIMConnectorShapeEnum ConnectorShape = BIMConnectorShapeEnum.kUndefinedShapeConnector);
}
```

**Returned by:** [BIMConnectors](../objects/BIMConnectors.md).CreateConduitConnectorDefinition

**Referenced types:** [BIMConduitConnectionTypeEnum](../enums/BIMConduitConnectionTypeEnum.md), [BIMConnector](../objects/BIMConnector.md), [BIMConnectorShapeEnum](../enums/BIMConnectorShapeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [UnitVector](../objects/UnitVector.md)

