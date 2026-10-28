# ThreadTableQuery

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.GeneralOptions.ThreadTableQuery`

```csharp
interface ThreadTableQuery
{
    // Properties
    object Application { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ThreadInfo CreateThreadInfo(bool Internal, bool RightHanded, string ThreadType, string ThreadDesignation, string Class = "");
    string[] GetAvailableClasses(bool Internal, string ThreadType, string ThreadDesignation);
    string[] GetAvailableDesignations(bool Internal, string ThreadType, string NominalSize);
    string[] GetAvailableThreadSizes(bool Internal, string ThreadType);
    string[] GetAvailableThreadTypes();
    string GetThreadTypeIdentifier(string ThreadTypeName);
    string GetThreadTypeName(string ThreadTypeIdentifier);
}
```

**Returned by:** [GeneralOptions](../objects/GeneralOptions.md).ThreadTableQuery

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ThreadInfo](../objects/ThreadInfo.md)

