# DWGEntitiesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition.Entities`

```csharp
interface DWGEntitiesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    DWGEntity Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DWGBlockDefinition](../objects/DWGBlockDefinition.md).Entities, [DWGBlockDefinitionProxy](../objects/DWGBlockDefinitionProxy.md).Entities

**Referenced types:** [DWGEntity](../objects/DWGEntity.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

