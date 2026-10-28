# BIMPipeConnectorDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.BIMComponent.Connectors.CreatePipeConnectorDefinition(…)`

```csharp
interface BIMPipeConnectorDefinition
{
    // Properties
    bool AllowSlopeAdjustment { get; set; }
    object AllowSlopeAdjustmentParameter { get; set; }
    object Application { get; }
    BIMPipeConnectionTypeEnum ConnectionType { get; set; }
    BIMConnectorShapeEnum ConnectorShape { get; }
    string Description { get; set; }
    object DescriptionParameter { get; set; }
    object Diameter { get; }
    object DiameterOverride { get; set; }
    UnitVector Direction { get; }
    bool ExposeAllowSlopeAdjustmentAsParameter { get; set; }
    bool ExposeDescriptionAsParameter { get; set; }
    bool ExposeFlowValueAsParameter { get; set; }
    bool ExposeLossValueAsParameter { get; set; }
    BIMPipeFlowConfigurationEnum FlowConfiguration { get; set; }
    BIMFlowDirectionEnum FlowDirection { get; set; }
    double FlowValue { get; set; }
    object FlowValueParameter { get; set; }
    ObjectCollection Geometry { get; }
    BIMPipeLossMethodEnum LossMethod { get; set; }
    double LossValue { get; set; }
    object LossValueParameter { get; set; }
    object NominalDiameter { get; set; }
    Point Origin { get; }
    BIMConnector Parent { get; }
    BIMPipeSystemTypeEnum SystemType { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void ReverseDirection();
    void SetShape(ObjectCollection Geometry, BIMConnectorShapeEnum ConnectorShape = BIMConnectorShapeEnum.kUndefinedShapeConnector);
}
```

**Returned by:** [BIMConnectors](../objects/BIMConnectors.md).CreatePipeConnectorDefinition

**Referenced types:** [BIMConnector](../objects/BIMConnector.md), [BIMConnectorShapeEnum](../enums/BIMConnectorShapeEnum.md), [BIMFlowDirectionEnum](../enums/BIMFlowDirectionEnum.md), [BIMPipeConnectionTypeEnum](../enums/BIMPipeConnectionTypeEnum.md), [BIMPipeFlowConfigurationEnum](../enums/BIMPipeFlowConfigurationEnum.md), [BIMPipeLossMethodEnum](../enums/BIMPipeLossMethodEnum.md), [BIMPipeSystemTypeEnum](../enums/BIMPipeSystemTypeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [UnitVector](../objects/UnitVector.md)

