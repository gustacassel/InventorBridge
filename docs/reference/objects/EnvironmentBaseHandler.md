# EnvironmentBaseHandler

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface EnvironmentBaseHandler
{
    // Properties
    EnvironmentBase EnvironmentBase { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnActivate();
    event OnDeactivate();
}
```

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

