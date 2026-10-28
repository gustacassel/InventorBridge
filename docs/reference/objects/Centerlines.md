# Centerlines

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.Centerlines`

```csharp
interface Centerlines
{
    // Properties
    object Application { get; }
    int Count { get; }
    Centerline Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    Centerline Add(ObjectCollection CenterEntities, object CentermarkStyle = Missing, object Layer = Missing, bool Closed = false);
    Centerline AddBisector(GeometryIntent EntityOne, GeometryIntent EntityTwo, object CentermarkStyle = Missing, object Layer = Missing);
    Centerline AddByWorkFeature(object WorkFeature, DrawingView DrawingView, object CentermarkStyle = Missing, object Layer = Missing);
    Centerline AddCenteredPattern(GeometryIntent PatternCenter, ObjectCollection CenterEntities, object CentermarkStyle = Missing, object Layer = Missing, bool Closed = false);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sheet](../objects/Sheet.md).Centerlines

**Referenced types:** [Centerline](../objects/Centerline.md), [DrawingView](../objects/DrawingView.md), [GeometryIntent](../objects/GeometryIntent.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

