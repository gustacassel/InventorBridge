# OrdinateDimensionSet

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingDimensions.OrdinateDimensionSets.Item[…]`

```csharp
interface OrdinateDimensionSet
{
    // Properties
    bool AlignMembers { get; set; }
    bool AllowBrokenLeaders { get; set; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool ContinuousRunning { get; set; }
    DimensionTypeEnum DimensionType { get; }
    bool DirectionReversed { get; set; }
    Layer Layer { get; set; }
    OrdinateDimensionsEnumerator Members { get; }
    ArrowheadTypeEnum OriginArrowheadType { get; set; }
    OrdinateDimension OriginMember { get; set; }
    Sheet Parent { get; }
    bool PositiveBothDirections { get; set; }
    int Precision { get; set; }
    bool ShowDirection { get; set; }
    DimensionStyle Style { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    OrdinateDimension AddMember(GeometryIntent GeometryIntent);
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [OrdinateDimension](../objects/OrdinateDimension.md).OrdinateDimensionSet, [OrdinateDimensionSets](../objects/OrdinateDimensionSets.md).Add, [OrdinateDimensionSets](../objects/OrdinateDimensionSets.md).Item

**Referenced types:** [ArrowheadTypeEnum](../enums/ArrowheadTypeEnum.md), [AttributeSets](../objects/AttributeSets.md), [DimensionStyle](../objects/DimensionStyle.md), [DimensionTypeEnum](../enums/DimensionTypeEnum.md), [GeometryIntent](../objects/GeometryIntent.md), [Layer](../objects/Layer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OrdinateDimension](../objects/OrdinateDimension.md), [OrdinateDimensionsEnumerator](../objects/OrdinateDimensionsEnumerator.md), [Sheet](../objects/Sheet.md)

