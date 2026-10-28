# CommandControlsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.UserInterfaceManager.AllReferencedControls(…)`

```csharp
interface CommandControlsEnumerator
{
    // Properties
    Application Application { get; }
    int Count { get; }
    CommandControl Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [UserInterfaceManager](../objects/UserInterfaceManager.md).AllReferencedControls

**Referenced types:** [Application](../objects/Application.md), [CommandControl](../objects/CommandControl.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

