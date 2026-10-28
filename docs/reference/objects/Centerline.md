# Centerline

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.Centerlines.Item[…]`

```csharp
interface Centerline
{
    // Properties
    object Application { get; }
    bool Attached { get; }
    AttributeSets AttributeSets { get; }
    CenterlineTypeEnum CenterlineType { get; }
    Point2d EndPoint { get; set; }
    ObjectsEnumerator FitPoints { get; }
    object Geometry { get; }
    CurveTypeEnum GeometryType { get; }
    Layer Layer { get; set; }
    object ModelWorkFeature { get; }
    Sheet Parent { get; }
    GeometryIntent PatternCenter { get; }
    Point2d StartPoint { get; set; }
    CentermarkStyle Style { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void Delete();
    void GetBisectorEntities(out GeometryIntent EntityOne, out GeometryIntent EntityTwo);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [Centerlines](../objects/Centerlines.md).Add, [Centerlines](../objects/Centerlines.md).AddBisector, [Centerlines](../objects/Centerlines.md).AddByWorkFeature, [Centerlines](../objects/Centerlines.md).AddCenteredPattern, [Centerlines](../objects/Centerlines.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [CenterlineTypeEnum](../enums/CenterlineTypeEnum.md), [CentermarkStyle](../objects/CentermarkStyle.md), [CurveTypeEnum](../enums/CurveTypeEnum.md), [GeometryIntent](../objects/GeometryIntent.md), [Layer](../objects/Layer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [Point2d](../objects/Point2d.md), [Sheet](../objects/Sheet.md)

