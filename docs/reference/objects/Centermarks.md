# Centermarks

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.Centermarks`

```csharp
interface Centermarks
{
    // Properties
    object Application { get; }
    int Count { get; }
    Centermark Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    Centermark Add(GeometryIntent Intent, bool ExtensionLinesVisible = true, bool AtPunchCenter = true, object CentermarkStyle = Missing, object Layer = Missing);
    Centermark AddByCenterOfGravity(DrawingView DrawingView, object CentermarkStyle = Missing, object Layer = Missing);
    Centermark AddByWorkFeature(object WorkFeature, DrawingView DrawingView, object CentermarkStyle = Missing, object Layer = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sheet](../objects/Sheet.md).Centermarks

**Referenced types:** [Centermark](../objects/Centermark.md), [DrawingView](../objects/DrawingView.md), [GeometryIntent](../objects/GeometryIntent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

