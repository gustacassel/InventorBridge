# DWGEntityArcSegment

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [DWGEntitySegment](../objects/DWGEntitySegment.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition.Polylines.Item[…].Segments.Item[…] → (DWGEntityArcSegment)`

```csharp
interface DWGEntityArcSegment
{
    // Properties
    object Application { get; }
    object Geometry { get; }
    DWGEntity Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [DWGEntityArcSegmentProxy](../objects/DWGEntityArcSegmentProxy.md).NativeObject

**Referenced types:** [DWGEntity](../objects/DWGEntity.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

