# _DocPerformanceMonitor

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface _DocPerformanceMonitor
{
    // Properties
    int ASMHistoryMemory { get; }
    bool LeakDetected { get; }
    int NodeCount { get; }
    int SegmentCount { get; }
    _SegPerformanceMonitor SegmentItem[object Index] { get; }
    // Methods
    void DontSaveIdentifiedMTLeaks(bool dontSave);
    void GetGraphicsLOD(out int NumberOfLODs, out double[] LODTolerances);
    void GetMemoryInUse(out int Committed, out int Reserved, out int InActiveUse);
    void SetDetectLeaks(bool detect);
    void SetGraphicsLOD(int NumberOfLODs);
    // Events
    event OnDatabaseClose();
    event OnIStorageClose();
    event OnIStorageOpen(int OpenedWithFlags);
    event OnIdle(NameValueMap Context);
    event OnSegmentLoad(string SegmentName);
    event OnViewUpdate(object ViewObject, int BeforeOrAfter, NameValueMap Context);
}
```

**Referenced types:** [NameValueMap](../objects/NameValueMap.md)

