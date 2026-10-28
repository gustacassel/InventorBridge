# OriginIndicator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingViews.Item[…].OriginIndicator`

```csharp
interface OriginIndicator
{
    // Properties
    object Application { get; }
    bool Attached { get; }
    bool InUse { get; }
    GeometryIntent Intent { get; set; }
    Layer Layer { get; set; }
    LeaderStyle LeaderStyle { get; set; }
    double RelativeX { get; set; }
    double RelativeY { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void Delete(object ForceToDelete = Missing);
}
```

**Returned by:** [DetailDrawingView](../objects/DetailDrawingView.md).OriginIndicator, [DrawingView](../objects/DrawingView.md).OriginIndicator, [SectionDrawingView](../objects/SectionDrawingView.md).OriginIndicator

**Referenced types:** [GeometryIntent](../objects/GeometryIntent.md), [Layer](../objects/Layer.md), [LeaderStyle](../objects/LeaderStyle.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

