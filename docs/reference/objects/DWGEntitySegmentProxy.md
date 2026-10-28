# DWGEntitySegmentProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface DWGEntitySegmentProxy
{
    // Properties
    object Application { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    string HandleID { get; }
    DWGEntitySegment NativeObject { get; }
    ImportedDWGComponent Parent { get; }
    DWGEntity ParentEntity { get; }
    ObjectTypeEnum Type { get; }
}
```

**Referenced types:** [ComponentOccurrence](../objects/ComponentOccurrence.md), [DWGEntity](../objects/DWGEntity.md), [DWGEntitySegment](../objects/DWGEntitySegment.md), [ImportedDWGComponent](../objects/ImportedDWGComponent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

