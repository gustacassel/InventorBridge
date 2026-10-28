# WebBrowserDialog

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.WebBrowserDialogs.Item[…]`

```csharp
interface WebBrowserDialog
{
    // Properties
    Application Application { get; }
    WindowsSizeEnum DisabledWindowState { get; set; }
    int HWND { get; }
    int Height { get; set; }
    string InternalName { get; }
    int Left { get; set; }
    bool Modal { get; }
    string Title { get; set; }
    int Top { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    WebBrowserDialogEvents WebBrowserDialogEvents { get; }
    int Width { get; set; }
    WindowsSizeEnum WindowState { get; set; }
    // Methods
    void Delete();
    void Move(int Top, int Left, int Height, int Width);
    void Navigate(string Url);
    void Refresh();
}
```

**Returned by:** [WebBrowserDialogEvents](../objects/WebBrowserDialogEvents.md).Parent, [WebBrowserDialogs](../objects/WebBrowserDialogs.md).Add, [WebBrowserDialogs](../objects/WebBrowserDialogs.md).Item

**Referenced types:** [Application](../objects/Application.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [WebBrowserDialogEvents](../objects/WebBrowserDialogEvents.md), [WindowsSizeEnum](../enums/WindowsSizeEnum.md)

