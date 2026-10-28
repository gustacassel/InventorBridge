# FileDialogEvents

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface FileDialogEvents
{
    // Properties
    object Application { get; }
    FileDialog Parent { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnOptions(NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnOptionsReset(NameValueMap Context, out HandlingCodeEnum HandlingCode); // since 2026
}
```

**Returned by:** [FileDialog](../objects/FileDialog.md).FileDialogEvents

**Referenced types:** [FileDialog](../objects/FileDialog.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

