# ClientView

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.ClientViews.Item[…]`

```csharp
interface ClientView
{
    // Properties
    object Application { get; }
    Camera Camera { get; }
    DisplayModeEnum DisplayMode { get; set; }
    object Document { get; }
    GroundShadowEnum GroundShadow { get; set; }
    int HWND { get; }
    ClientViews Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Close();
    void GetSubsetExtents(out int Top, out int Left, out int Width, out int Height);
    void Update(bool Interactive);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ClientViews](../objects/ClientViews.md).Add, [ClientViews](../objects/ClientViews.md).AddBySubset, [ClientViews](../objects/ClientViews.md).Item

**Referenced types:** [Camera](../objects/Camera.md), [ClientViews](../objects/ClientViews.md), [DisplayModeEnum](../enums/DisplayModeEnum.md), [GroundShadowEnum](../enums/GroundShadowEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

