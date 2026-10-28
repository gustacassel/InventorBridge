# Centermark

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.Centermarks.Item[…]`

```csharp
interface Centermark
{
    // Properties
    object Application { get; }
    bool Attached { get; }
    object AttachedEntity { get; }
    AttributeSets AttributeSets { get; }
    ObjectsEnumerator Centerlines { get; }
    CentermarkTypeEnum CentermarkType { get; }
    bool ExtensionLinesVisible { get; set; }
    Point2d ExtensionPointFour { get; set; }
    UnitVector2d ExtensionPointFourDirection { get; }
    Point2d ExtensionPointOne { get; set; }
    UnitVector2d ExtensionPointOneDirection { get; }
    Point2d ExtensionPointThree { get; set; }
    UnitVector2d ExtensionPointThreeDirection { get; }
    Point2d ExtensionPointTwo { get; set; }
    UnitVector2d ExtensionPointTwoDirection { get; }
    Layer Layer { get; set; }
    Sheet Parent { get; }
    Point2d Position { get; }
    CentermarkStyle Style { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Centermarks](../objects/Centermarks.md).Add, [Centermarks](../objects/Centermarks.md).AddByCenterOfGravity, [Centermarks](../objects/Centermarks.md).AddByWorkFeature, [Centermarks](../objects/Centermarks.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [CentermarkStyle](../objects/CentermarkStyle.md), [CentermarkTypeEnum](../enums/CentermarkTypeEnum.md), [Layer](../objects/Layer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [Point2d](../objects/Point2d.md), [Sheet](../objects/Sheet.md), [UnitVector2d](../objects/UnitVector2d.md)

