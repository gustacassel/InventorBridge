# BIMCableTrayConnectorDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.BIMComponent.Connectors.CreateCableTrayConnectorDefinition(…)`

```csharp
interface BIMCableTrayConnectorDefinition
{
    // Properties
    object Application { get; }
    BIMCableTrayConnectionTypeEnum ConnectionType { get; set; }
    BIMConnectorShapeEnum ConnectorShape { get; }
    UnitVector Direction { get; }
    ObjectCollection Geometry { get; }
    object Height { get; }
    UnitVector HeightDirection { get; }
    object HeightOverride { get; set; }
    Point Origin { get; }
    BIMConnector Parent { get; }
    ObjectTypeEnum Type { get; }
    object Width { get; }
    UnitVector WidthDirection { get; }
    object WidthOverride { get; set; }
    // Methods
    void ReverseDirection();
    void SetShape(ObjectCollection Geometry, BIMConnectorShapeEnum ConnectorShape = BIMConnectorShapeEnum.kUndefinedShapeConnector);
}
```

**Returned by:** [BIMConnectors](../objects/BIMConnectors.md).CreateCableTrayConnectorDefinition

**Referenced types:** [BIMCableTrayConnectionTypeEnum](../enums/BIMCableTrayConnectionTypeEnum.md), [BIMConnector](../objects/BIMConnector.md), [BIMConnectorShapeEnum](../enums/BIMConnectorShapeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [UnitVector](../objects/UnitVector.md)

