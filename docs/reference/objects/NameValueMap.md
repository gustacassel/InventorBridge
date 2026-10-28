# NameValueMap

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientObjects.CreateNameValueMap(…)`

```csharp
interface NameValueMap
{
    // Properties
    int Count { get; }
    object Item[object Index] { get; }
    string Name[int Index] { get; }
    object Value[string Name] { get; set; }
    // Methods
    void Add(string Name, object Value);
    void Clear();
    void Insert(string Name, object Value, object TargetIndex = Missing, bool InsertBefore = true);
    void Remove(object Index);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FileDialog](../objects/FileDialog.md).OptionValues, [FileManager](../objects/FileManager.md).GetRevitEngineInstallationStatus, [OnFaceCurve](../objects/OnFaceCurve.md).Faces, [OnFaceCurveProxy](../objects/OnFaceCurveProxy.md).Faces, [PartsListFilterItem](../objects/PartsListFilterItem.md).Options, [TransientObjects](../objects/TransientObjects.md).CreateNameValueMap

