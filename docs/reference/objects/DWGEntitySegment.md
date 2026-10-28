# DWGEntitySegment

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition.Polylines.Item[…].Segments.Item[…]`

```csharp
interface DWGEntitySegment
{
    // Properties
    object Application { get; }
    DWGEntity Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [DWGEntitySegmentProxy](../objects/DWGEntitySegmentProxy.md).NativeObject, [DWGEntitySegmentsEnumerator](../objects/DWGEntitySegmentsEnumerator.md).Item

**Referenced types:** [DWGEntity](../objects/DWGEntity.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

