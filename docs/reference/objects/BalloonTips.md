# BalloonTips

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.UserInterfaceManager.BalloonTips`

```csharp
interface BalloonTips
{
    // Properties
    Application Application { get; }
    int Count { get; }
    BalloonTip Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    BalloonTip Add(string InternalName, string Title, string Message);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [UserInterfaceManager](../objects/UserInterfaceManager.md).BalloonTips

**Referenced types:** [Application](../objects/Application.md), [BalloonTip](../objects/BalloonTip.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

