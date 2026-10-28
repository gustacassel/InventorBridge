# DWGPolyline3DProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface DWGPolyline3DProxy
{
    // Properties
    object Application { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    string HandleID { get; }
    DWGPolyline3D NativeObject { get; }
    ImportedDWGComponent Parent { get; }
    DWGEntity ParentEntity { get; }
    DWGEntitySegmentsEnumerator Segments { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [ComponentOccurrence](../objects/ComponentOccurrence.md), [DWGEntity](../objects/DWGEntity.md), [DWGEntitySegmentsEnumerator](../objects/DWGEntitySegmentsEnumerator.md), [DWGPolyline3D](../objects/DWGPolyline3D.md), [ImportedDWGComponent](../objects/ImportedDWGComponent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

