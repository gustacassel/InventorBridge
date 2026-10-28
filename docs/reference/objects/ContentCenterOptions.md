# ContentCenterOptions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ContentCenterOptions`

```csharp
interface ContentCenterOptions
{
    // Properties
    object Application { get; }
    bool CheckFamiliesUpdates { get; set; }
    bool CustomFamilyAsStandard { get; set; }
    bool RefreshOutOfDateStandardParts { get; set; }
    bool SaveAsmToSharedFolder { get; set; } // since 2027
    ObjectTypeEnum Type { get; }
    // Methods
    void GetAccessOption(out ContentCenterAccessOptionEnum AccessOption, out string LibrariesLocation);
    void SetAccessOption(ContentCenterAccessOptionEnum AccessOption, string LibrariesLocation = "");
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).ContentCenterOptions, [InventorServer](../objects/InventorServer.md).ContentCenterOptions

**Referenced types:** [ContentCenterAccessOptionEnum](../enums/ContentCenterAccessOptionEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

