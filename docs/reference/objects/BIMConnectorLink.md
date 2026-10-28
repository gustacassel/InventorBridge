# BIMConnectorLink

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.BIMComponent.ConnectorLinks.Item[…]`

```csharp
interface BIMConnectorLink
{
    // Properties
    object Application { get; }
    BIMConnector ConnectorOne { get; }
    BIMConnector ConnectorTwo { get; }
    string Name { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [BIMConnectorLinks](../objects/BIMConnectorLinks.md).Add, [BIMConnectorLinks](../objects/BIMConnectorLinks.md).Item

**Referenced types:** [BIMConnector](../objects/BIMConnector.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

