# DWGPolylineProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface DWGPolylineProxy
{
    // Properties
    object Application { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    string HandleID { get; }
    DWGPolyline NativeObject { get; }
    ImportedDWGComponent Parent { get; }
    DWGEntity ParentEntity { get; }
    DWGEntitySegmentsEnumerator Segments { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [ComponentOccurrence](../objects/ComponentOccurrence.md), [DWGEntity](../objects/DWGEntity.md), [DWGEntitySegmentsEnumerator](../objects/DWGEntitySegmentsEnumerator.md), [DWGPolyline](../objects/DWGPolyline.md), [ImportedDWGComponent](../objects/ImportedDWGComponent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

