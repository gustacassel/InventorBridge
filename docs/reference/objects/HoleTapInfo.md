# HoleTapInfo

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ThreadInfo](../objects/ThreadInfo.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.GeneralOptions.ThreadTableQuery.CreateThreadInfo(…) → (HoleTapInfo)`

```csharp
interface HoleTapInfo
{
    // Properties
    object Application { get; }
    string Class { get; set; }
    string CustomThreadDesignation { get; }
    bool FullThreadDepth { get; set; }
    bool Internal { get; set; }
    object MajorDiameterMax { get; set; }
    object MajorDiameterMin { get; set; }
    bool Metric { get; set; }
    object MinorDiameterMax { get; set; }
    object MinorDiameterMin { get; set; }
    string NominalSize { get; }
    double Pitch { get; }
    object PitchDiameterMax { get; set; }
    object PitchDiameterMin { get; set; }
    bool RightHanded { get; set; }
    object TapDrillDiameter { get; set; }
    ObjectsEnumerator ThreadBasePoints { get; }
    Parameter ThreadDepth { get; }
    string ThreadDesignation { get; }
    Vector ThreadDirection { get; }
    string ThreadType { get; set; }
    string ThreadTypeIdentifier { get; }
    ObjectTypeEnum Type { get; }
}
```

5 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [HoleFeatures](../objects/HoleFeatures.md).CreateTapInfo

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [Parameter](../objects/Parameter.md), [Vector](../objects/Vector.md)

