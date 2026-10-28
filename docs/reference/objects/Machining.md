# Machining

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition → (WeldmentComponentDefinition).Machining`

```csharp
interface Machining
{
    // Properties
    object Application { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Edit();
    void ExitEdit();
}
```

**Returned by:** [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).Machining

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

