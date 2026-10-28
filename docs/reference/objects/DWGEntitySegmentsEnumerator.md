# DWGEntitySegmentsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition.Polylines.Item[…].Segments`

```csharp
interface DWGEntitySegmentsEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    DWGEntitySegment Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DWGAcadSupportedProxy](../objects/DWGAcadSupportedProxy.md).Segments, [DWGAcadSupportedProxyProxy](../objects/DWGAcadSupportedProxyProxy.md).Segments, [DWGPolyline](../objects/DWGPolyline.md).Segments, [DWGPolyline2D](../objects/DWGPolyline2D.md).Segments, [DWGPolyline2DProxy](../objects/DWGPolyline2DProxy.md).Segments, [DWGPolyline3D](../objects/DWGPolyline3D.md).Segments, [DWGPolyline3DProxy](../objects/DWGPolyline3DProxy.md).Segments, [DWGPolylineProxy](../objects/DWGPolylineProxy.md).Segments

**Referenced types:** [DWGEntitySegment](../objects/DWGEntitySegment.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

