# TriadSegmentEnum

Inventor API enum · versions: 2024+ · [index](../index.md)

```csharp
enum TriadSegmentEnum
{
    kAllSegments = 0,
    kOriginSegment = 1,
    kXAxisTranslationSegment = 2,
    kYAxisTranslationSegment = 4,
    kZAxisTranslationSegment = 8,
    kXAxisRotationSegment = 16,
    kYAxisRotationSegment = 32,
    kZAxisRotationSegment = 64,
    kXYPlaneTranslationSegment = 128,
    kXZPlaneTranslationSegment = 256,
    kYZPlaneTranslationSegment = 512,
}
```

**Used by:** [TriadEvents](../objects/TriadEvents.md).DegreesOfFreedom, [TriadEvents](../objects/TriadEvents.md).OnEndMove, [TriadEvents](../objects/TriadEvents.md).OnMove, [TriadEvents](../objects/TriadEvents.md).OnSegmentSelectionChange, [TriadEvents](../objects/TriadEvents.md).OnStartMove, [TriadEvents](../objects/TriadEvents.md).Reposition

