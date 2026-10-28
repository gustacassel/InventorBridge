# Ribbons

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.UserInterfaceManager.Ribbons`

```csharp
interface Ribbons
{
    // Properties
    Application Application { get; }
    int Count { get; }
    Ribbon Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [UserInterfaceManager](../objects/UserInterfaceManager.md).Ribbons

**Referenced types:** [Application](../objects/Application.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Ribbon](../objects/Ribbon.md)

