# SheetMetalStyle

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Style](../objects/Style.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition → (SheetMetalComponentDefinition).SheetMetalStyles.Item[…]`

```csharp
interface SheetMetalStyle
{
    // Properties
    object Application { get; }
    BendAngleTypeEnum BendAngleReportType { get; set; }
    string BendRadius { get; set; }
    string BendReliefDepth { get; set; }
    BendReliefShapeEnum BendReliefShape { get; set; }
    string BendReliefWidth { get; set; }
    BendTransitionEnum BendTransition { get; set; }
    string BendTransitionArcRadius { get; set; }
    string Comments { get; set; }
    CornerReliefPlacementEnum CornerReliefPlacement { get; set; }
    CornerReliefShapeEnum CornerReliefShape { get; set; }
    string CornerReliefSize { get; set; }
    string GapSize { get; set; }
    bool InUse { get; }
    string InternalName { get; }
    string MinimumRemnant { get; set; }
    string Name { get; set; }
    object Parent { get; }
    PunchRepresentationTypeEnum PunchRepresentationType { get; set; }
    StyleLocationEnum StyleLocation { get; }
    StyleTypeEnum StyleType { get; }
    string Thickness { get; set; }
    CornerReliefShapeEnum ThreeBendCornerReliefShape { get; set; }
    string ThreeBendCornerReliefSize { get; set; }
    ObjectTypeEnum Type { get; }
    UnfoldMethod UnfoldMethod { get; set; }
    bool UpToDate { get; }
    // Methods
    void Activate();
    Style ConvertToLocal();
    Style Copy(string Name);
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SaveToGlobal();
    void UpdateFromGlobal();
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ContourFlangeDefinition](../objects/ContourFlangeDefinition.md).SheetMetalRule, [FaceFeatureDefinition](../objects/FaceFeatureDefinition.md).SheetMetalRule, [LoftedFlangeDefinition](../objects/LoftedFlangeDefinition.md).SheetMetalRule, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).ActiveSheetMetalStyle, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).GetBodySheetMetalStyle, [SheetMetalStyles](../objects/SheetMetalStyles.md).Item

**Referenced types:** [BendAngleTypeEnum](../enums/BendAngleTypeEnum.md), [BendReliefShapeEnum](../enums/BendReliefShapeEnum.md), [BendTransitionEnum](../enums/BendTransitionEnum.md), [CornerReliefPlacementEnum](../enums/CornerReliefPlacementEnum.md), [CornerReliefShapeEnum](../enums/CornerReliefShapeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PunchRepresentationTypeEnum](../enums/PunchRepresentationTypeEnum.md), [Style](../objects/Style.md), [StyleLocationEnum](../enums/StyleLocationEnum.md), [StyleTypeEnum](../enums/StyleTypeEnum.md), [UnfoldMethod](../objects/UnfoldMethod.md)

