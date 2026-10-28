# DWGEntityLineSegment

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [DWGEntitySegment](../objects/DWGEntitySegment.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition.Polylines.Item[…].Segments.Item[…] → (DWGEntityLineSegment)`

```csharp
interface DWGEntityLineSegment
{
    // Properties
    object Application { get; }
    LineSegment Geometry { get; }
    DWGEntity Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [DWGEntityLineSegmentProxy](../objects/DWGEntityLineSegmentProxy.md).NativeObject

**Referenced types:** [DWGEntity](../objects/DWGEntity.md), [LineSegment](../objects/LineSegment.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

