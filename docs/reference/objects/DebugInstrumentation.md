# DebugInstrumentation

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface DebugInstrumentation
{
    // Properties
    object Object[int Cookie] { get; }
    string ObjectDescription[int Cookie] { get; }
    int ObjectInstanceNumber[int Cookie] { get; }
    int ObjectReferenceCount[int Cookie] { get; }
    DebugWatchType ObjectWatchType[int Cookie] { get; set; }
    // Methods
    void GetLiveObjects(out int[] Cookies);
    int GetObjectCookie(object Object);
    void GetTraceInfo(out bool Enabled, out string TraceFilename);
    void SetProfileInfo(bool Enable, bool WriteToFileOnStop = true, string FileName = "");
    void SetTrace(bool Enable = true, string TraceFilename = "");
    // Events
    event ObjectAddRefd(int Cookie, int ToReferenceCount);
    event ObjectCreated(int Cookie);
    event ObjectDestroyed(int Cookie);
    event ObjectQueryInterfaced(int Cookie, string InterfaceIID, bool Successful);
    event ObjectReleased(int Cookie, int ToReferenceCount);
    event OnMemberInvoke(int Cookie, string MemberName, EventTimingEnum BeforeOrAfter, int Result);
}
```

**Referenced types:** [EventTimingEnum](../enums/EventTimingEnum.md)

