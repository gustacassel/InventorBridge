# BIMDuctConnectorDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.BIMComponent.Connectors.CreateDuctConnectorDefinition(…)`

```csharp
interface BIMDuctConnectorDefinition
{
    // Properties
    object Application { get; }
    BIMDuctConnectionTypeEnum ConnectionType { get; set; }
    BIMConnectorShapeEnum ConnectorShape { get; }
    string Description { get; set; }
    object DescriptionParameter { get; set; }
    object Diameter { get; }
    object DiameterOverride { get; set; }
    UnitVector Direction { get; }
    bool ExposeDescriptionAsParameter { get; set; }
    bool ExposeFlowValueAsParameter { get; set; }
    bool ExposeLossValueAsParameter { get; set; }
    BIMDuctFlowConfigurationEnum FlowConfiguration { get; set; }
    BIMFlowDirectionEnum FlowDirection { get; set; }
    double FlowValue { get; set; }
    object FlowValueParameter { get; set; }
    ObjectCollection Geometry { get; }
    object Height { get; }
    UnitVector HeightDirection { get; }
    object HeightOverride { get; set; }
    BIMDuctLossMethodEnum LossMethod { get; set; }
    double LossValue { get; set; }
    object LossValueParameter { get; set; }
    Point Origin { get; }
    BIMConnector Parent { get; }
    BIMDuctSystemTypeEnum SystemType { get; set; }
    ObjectTypeEnum Type { get; }
    object Width { get; }
    UnitVector WidthDirection { get; }
    object WidthOverride { get; set; }
    // Methods
    void ReverseDirection();
    void SetShape(ObjectCollection Geometry, BIMConnectorShapeEnum ConnectorShape = BIMConnectorShapeEnum.kUndefinedShapeConnector);
}
```

**Returned by:** [BIMConnectors](../objects/BIMConnectors.md).CreateDuctConnectorDefinition

**Referenced types:** [BIMConnector](../objects/BIMConnector.md), [BIMConnectorShapeEnum](../enums/BIMConnectorShapeEnum.md), [BIMDuctConnectionTypeEnum](../enums/BIMDuctConnectionTypeEnum.md), [BIMDuctFlowConfigurationEnum](../enums/BIMDuctFlowConfigurationEnum.md), [BIMDuctLossMethodEnum](../enums/BIMDuctLossMethodEnum.md), [BIMDuctSystemTypeEnum](../enums/BIMDuctSystemTypeEnum.md), [BIMFlowDirectionEnum](../enums/BIMFlowDirectionEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [UnitVector](../objects/UnitVector.md)

