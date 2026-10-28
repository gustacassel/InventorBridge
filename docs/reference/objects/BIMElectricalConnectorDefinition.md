# BIMElectricalConnectorDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.BIMComponent.Connectors.CreateElectricalConnectorDefinition(…)`

```csharp
interface BIMElectricalConnectorDefinition
{
    // Properties
    double ApparentLoad { get; set; }
    object ApparentLoadParameter { get; set; }
    double ApparentLoadPhase1 { get; set; }
    object ApparentLoadPhase1Parameter { get; set; }
    double ApparentLoadPhase2 { get; set; }
    object ApparentLoadPhase2Parameter { get; set; }
    double ApparentLoadPhase3 { get; set; }
    object ApparentLoadPhase3Parameter { get; set; }
    object Application { get; }
    BIMConnectorShapeEnum ConnectorShape { get; }
    string Description { get; set; }
    object DescriptionParameter { get; set; }
    UnitVector Direction { get; }
    bool ExposeApparentLoadAsParameter { get; set; }
    bool ExposeApparentLoadPhase1AsParameter { get; set; }
    bool ExposeApparentLoadPhase2AsParameter { get; set; }
    bool ExposeApparentLoadPhase3AsParameter { get; set; }
    bool ExposeDescriptionAsParameter { get; set; }
    bool ExposeHasMotorAsParameter { get; set; }
    bool ExposeLoadClassificationAsParameter { get; set; }
    bool ExposeNumberOfPolesAsParameter { get; set; }
    bool ExposePowerFactorAsParameter { get; set; }
    bool ExposeVoltageAsParameter { get; set; }
    ObjectCollection Geometry { get; }
    bool HasMotor { get; set; }
    object HasMotorParameter { get; set; }
    string LoadClassification { get; set; }
    object LoadClassificationParameter { get; set; }
    int NumberOfPoles { get; set; }
    object NumberOfPolesParameter { get; set; }
    Point Origin { get; }
    BIMConnector Parent { get; }
    double PowerFactor { get; set; }
    object PowerFactorParameter { get; set; }
    BIMElectricalPowerFactorStateEnum PowerFactorState { get; set; }
    BIMElectricalSystemTypeEnum SystemType { get; set; }
    ObjectTypeEnum Type { get; }
    double Voltage { get; set; }
    object VoltageParameter { get; set; }
    // Methods
    void ReverseDirection();
    void SetShape(ObjectCollection Geometry, BIMConnectorShapeEnum ConnectorShape = BIMConnectorShapeEnum.kUndefinedShapeConnector);
}
```

**Returned by:** [BIMConnectors](../objects/BIMConnectors.md).CreateElectricalConnectorDefinition

**Referenced types:** [BIMConnector](../objects/BIMConnector.md), [BIMConnectorShapeEnum](../enums/BIMConnectorShapeEnum.md), [BIMElectricalPowerFactorStateEnum](../enums/BIMElectricalPowerFactorStateEnum.md), [BIMElectricalSystemTypeEnum](../enums/BIMElectricalSystemTypeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [UnitVector](../objects/UnitVector.md)

