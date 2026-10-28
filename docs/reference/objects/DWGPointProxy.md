# DWGPointProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface DWGPointProxy
{
    // Properties
    object Application { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    string HandleID { get; }
    DWGPoint NativeObject { get; }
    ImportedDWGComponent Parent { get; }
    DWGEntity ParentEntity { get; }
    Point Point { get; }
    ObjectTypeEnum Type { get; }
}
```

**Referenced types:** [ComponentOccurrence](../objects/ComponentOccurrence.md), [DWGEntity](../objects/DWGEntity.md), [DWGPoint](../objects/DWGPoint.md), [ImportedDWGComponent](../objects/ImportedDWGComponent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

