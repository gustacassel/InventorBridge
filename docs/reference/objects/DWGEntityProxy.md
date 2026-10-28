# DWGEntityProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface DWGEntityProxy
{
    // Properties
    object Application { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    string HandleID { get; }
    DWGEntity NativeObject { get; }
    ImportedDWGComponent Parent { get; }
    DWGEntity ParentEntity { get; }
    ObjectTypeEnum Type { get; }
}
```

**Referenced types:** [ComponentOccurrence](../objects/ComponentOccurrence.md), [DWGEntity](../objects/DWGEntity.md), [ImportedDWGComponent](../objects/ImportedDWGComponent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

