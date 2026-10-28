# ThreadFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.ThreadFeatures`

```csharp
interface ThreadFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    ThreadFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ThreadFeature Add(Face Face, Edge StartEdge, ThreadInfo ThreadInfo, bool DirectionReversed = false, bool FullDepth = true, object ThreadDepth = Missing, object ThreadOffset = Missing);
    StandardThreadInfo CreateStandardThreadInfo(bool Internal, bool RightHanded, string ThreadType, string ThreadDesignation, string Class);
    TaperedThreadInfo CreateTaperedThreadInfo(bool Internal, bool RightHanded, string ThreadType, string ThreadDesignation);
}
```

4 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Features](../objects/Features.md).ThreadFeatures, [PartFeatures](../objects/PartFeatures.md).ThreadFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).ThreadFeatures

**Referenced types:** [Edge](../objects/Edge.md), [Face](../objects/Face.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [StandardThreadInfo](../objects/StandardThreadInfo.md), [TaperedThreadInfo](../objects/TaperedThreadInfo.md), [ThreadFeature](../objects/ThreadFeature.md), [ThreadInfo](../objects/ThreadInfo.md)

