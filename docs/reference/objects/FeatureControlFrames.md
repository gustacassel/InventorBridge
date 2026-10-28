# FeatureControlFrames

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.FeatureControlFrames`

```csharp
interface FeatureControlFrames
{
    // Properties
    object Application { get; }
    int Count { get; }
    FeatureControlFrame Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    FeatureControlFrame Add(ObjectCollection LeaderPoints, FeatureControlFrameRows FeatureControlFrameRows, bool AllAroundSymbol = false, string DatumIdentifier = "", string Notes = "", object FeatureControlFrameStyle = Missing, object Layer = Missing);
    FeatureControlFrameRows CreateFeatureControlFrameRows();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sheet](../objects/Sheet.md).FeatureControlFrames

**Referenced types:** [FeatureControlFrame](../objects/FeatureControlFrame.md), [FeatureControlFrameRows](../objects/FeatureControlFrameRows.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

