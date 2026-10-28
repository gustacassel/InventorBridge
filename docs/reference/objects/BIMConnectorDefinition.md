# BIMConnectorDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.BIMComponent.Connectors.Item[…].Definition`

```csharp
interface BIMConnectorDefinition
{
    // Properties
    object Application { get; }
    BIMConnectorShapeEnum ConnectorShape { get; }
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

**Returned by:** [BIMConnector](../objects/BIMConnector.md).Definition

**Referenced types:** [BIMConnector](../objects/BIMConnector.md), [BIMConnectorShapeEnum](../enums/BIMConnectorShapeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [UnitVector](../objects/UnitVector.md)

