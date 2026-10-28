# BalloonTip

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.UserInterfaceManager.BalloonTips.Item[…]`

```csharp
interface BalloonTip
{
    // Properties
    Application Application { get; }
    string ClientData { get; set; }
    bool Enabled { get; set; }
    string InternalName { get; }
    int Interval { get; set; }
    string Message { get; set; }
    UserInterfaceManager Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void Display(string Message = "");
    // Events
    event OnClick(NameValueMap Context);
    event OnDisplay(out bool Cancel);
}
```

**Returned by:** [BalloonTips](../objects/BalloonTips.md).Add, [BalloonTips](../objects/BalloonTips.md).Item

**Referenced types:** [Application](../objects/Application.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [UserInterfaceManager](../objects/UserInterfaceManager.md)

