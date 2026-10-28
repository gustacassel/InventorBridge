# BalloonStyle

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Style](../objects/Style.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.BalloonStyles.Item[…]`

```csharp
interface BalloonStyle
{
    // Properties
    LeaderStyle AlternateLeaderStyle { get; set; }
    object Application { get; }
    double BalloonDiameter { get; set; }
    BalloonTypeEnum BalloonType { get; set; }
    string Comments { get; set; }
    double DefaultOffset { get; set; }
    bool InUse { get; }
    string InternalName { get; }
    LeaderStyle LeaderStyle { get; set; }
    string Name { get; set; }
    object Parent { get; }
    string Properties { get; set; }
    bool ScaleToTextHeight { get; set; }
    bool StretchBalloonToText { get; set; }
    StyleLocationEnum StyleLocation { get; }
    StyleTypeEnum StyleType { get; }
    TextStyle TextStyle { get; set; }
    ObjectTypeEnum Type { get; }
    bool UpToDate { get; }
    // Methods
    Style ConvertToLocal();
    Style Copy(string Name);
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SaveToGlobal();
    void UpdateFromGlobal();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Balloon](../objects/Balloon.md).Style, [BalloonStylesEnumerator](../objects/BalloonStylesEnumerator.md).Item, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).BalloonStyle

**Referenced types:** [BalloonTypeEnum](../enums/BalloonTypeEnum.md), [LeaderStyle](../objects/LeaderStyle.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Style](../objects/Style.md), [StyleLocationEnum](../enums/StyleLocationEnum.md), [StyleTypeEnum](../enums/StyleTypeEnum.md), [TextStyle](../objects/TextStyle.md)

