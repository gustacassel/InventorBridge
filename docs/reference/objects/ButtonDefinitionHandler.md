# ButtonDefinitionHandler

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ButtonDefinitionHandler
{
    // Properties
    ControlDefinition ControlDefinition { get; }
    bool Enabled { get; set; }
    bool Pressed { get; set; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnClick();
}
```

**Referenced types:** [ControlDefinition](../objects/ControlDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

