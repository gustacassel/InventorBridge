# StylesManager

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.StylesManager`

```csharp
interface StylesManager
{
    // Properties
    object Application { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetStyleNameFromKey(out byte[] ReferenceKey, out string InternalName, out string DisplayName);
}
```

4 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).StylesManager, [InventorServer](../objects/InventorServer.md).StylesManager

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

