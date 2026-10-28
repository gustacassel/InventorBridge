# TaperedThreadInfo

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ThreadInfo](../objects/ThreadInfo.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.GeneralOptions.ThreadTableQuery.CreateThreadInfo(…) → (TaperedThreadInfo)`

```csharp
interface TaperedThreadInfo
{
    // Properties
    object Application { get; }
    object BasicMinorDiameter { get; set; }
    string CustomThreadDesignation { get; }
    object EffectiveDiameter { get; set; }
    object EffectiveLength { get; set; }
    object EngagementDiameter { get; set; }
    object EngagementLength { get; set; }
    object ExternalPitchDiameter { get; set; }
    bool FullThreadDepth { get; set; }
    bool Internal { get; set; }
    bool Metric { get; set; }
    object NominalExternalDiameter { get; set; }
    object NominalExternalLength { get; set; }
    object OutsidePipeDiameter { get; set; }
    object OverallExternalLength { get; set; }
    double Pitch { get; set; }
    bool RightHanded { get; set; }
    object TapDrillDiameter { get; set; }
    ObjectsEnumerator ThreadBasePoints { get; }
    string ThreadDesignation { get; }
    Vector ThreadDirection { get; }
    object ThreadHeight { get; set; }
    string ThreadType { get; set; }
    string ThreadTypeIdentifier { get; }
    string ThreadsPerInch { get; set; }
    ObjectTypeEnum Type { get; }
    object VanishThread { get; set; }
    object WrenchMakeupDiameter { get; set; }
    object WrenchMakeupLength { get; set; }
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [HoleFeatures](../objects/HoleFeatures.md).CreateTaperedTapInfo, [ThreadFeatures](../objects/ThreadFeatures.md).CreateTaperedThreadInfo

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [Vector](../objects/Vector.md)

