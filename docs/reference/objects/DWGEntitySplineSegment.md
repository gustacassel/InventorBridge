# DWGEntitySplineSegment

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [DWGEntitySegment](../objects/DWGEntitySegment.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition.Polylines.Item[…].Segments.Item[…] → (DWGEntitySplineSegment)`

```csharp
interface DWGEntitySplineSegment
{
    // Properties
    object Application { get; }
    Point EndPoint { get; }
    DWGEntity Parent { get; }
    Point StartPoint { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [DWGEntitySplineSegmentProxy](../objects/DWGEntitySplineSegmentProxy.md).NativeObject

**Referenced types:** [DWGEntity](../objects/DWGEntity.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

