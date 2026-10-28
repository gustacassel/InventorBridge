# BIMConnectorLinks

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.BIMComponent.ConnectorLinks`

```csharp
interface BIMConnectorLinks
{
    // Properties
    object Application { get; }
    int Count { get; }
    BIMConnectorLink Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    BIMConnectorLink Add(BIMConnector ConnectorOne, BIMConnector ConnectorTwo);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BIMComponent](../objects/BIMComponent.md).ConnectorLinks

**Referenced types:** [BIMConnector](../objects/BIMConnector.md), [BIMConnectorLink](../objects/BIMConnectorLink.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

