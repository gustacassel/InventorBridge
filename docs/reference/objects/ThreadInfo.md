# ThreadInfo

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.GeneralOptions.ThreadTableQuery.CreateThreadInfo(…)`

```csharp
interface ThreadInfo
{
    // Properties
    object Application { get; }
    string CustomThreadDesignation { get; }
    bool FullThreadDepth { get; set; }
    bool Internal { get; set; }
    bool Metric { get; set; }
    bool RightHanded { get; set; }
    ObjectsEnumerator ThreadBasePoints { get; }
    string ThreadDesignation { get; }
    Vector ThreadDirection { get; }
    string ThreadType { get; set; }
    string ThreadTypeIdentifier { get; }
    ObjectTypeEnum Type { get; }
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ThreadFeature](../objects/ThreadFeature.md).ThreadInfo, [ThreadFeatureProxy](../objects/ThreadFeatureProxy.md).ThreadInfo, [ThreadTableQuery](../objects/ThreadTableQuery.md).CreateThreadInfo

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [Vector](../objects/Vector.md)

