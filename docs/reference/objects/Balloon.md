# Balloon

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.Balloons.Item[…]`

```csharp
interface Balloon
{
    // Properties
    object Application { get; }
    bool Attached { get; }
    AttributeSets AttributeSets { get; }
    BalloonValueSets BalloonValueSets { get; }
    Layer Layer { get; set; }
    Leader Leader { get; }
    Sheet Parent { get; }
    DrawingView ParentView { get; }
    BalloonDirectionEnum PlacementDirection { get; set; }
    Point2d Position { get; set; }
    BalloonStyle Style { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetBalloonType(out BalloonTypeEnum BalloonType, out object BalloonTypeData);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void ReplaceBOMView(PartsListLevelEnum Level, object NumberingScheme = Missing, object MinimumDigitsOrDelimiter = Missing, object IgnoreOverrides = Missing); // since 2027
    void SaveItemOverridesToBOM();
    void SetBalloonType(BalloonTypeEnum BalloonType, object BalloonTypeData = Missing);
    void SortValueSets();
}
```

**Returned by:** [BalloonValueSet](../objects/BalloonValueSet.md).Parent, [Balloons](../objects/Balloons.md).Add, [Balloons](../objects/Balloons.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [BalloonDirectionEnum](../enums/BalloonDirectionEnum.md), [BalloonStyle](../objects/BalloonStyle.md), [BalloonTypeEnum](../enums/BalloonTypeEnum.md), [BalloonValueSets](../objects/BalloonValueSets.md), [DrawingView](../objects/DrawingView.md), [Layer](../objects/Layer.md), [Leader](../objects/Leader.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartsListLevelEnum](../enums/PartsListLevelEnum.md), [Point2d](../objects/Point2d.md), [Sheet](../objects/Sheet.md)

