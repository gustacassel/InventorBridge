# BIMComponentDescription

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.BIMComponent.ComponentDescription`

```csharp
interface BIMComponentDescription
{
    // Properties
    object Application { get; }
    BIMComponentPropertySets ComponentPropertySets { get; }
    string FamilyType { get; set; }
    ObjectCollection ModelProperties { get; set; }
    BIMComponentOrientationTypeEnum OrientationType { get; set; }
    int RevitFamilyCategory { get; set; } // since 2026
    IPictureDisp Thumbnail { get; set; }
    ObjectTypeEnum Type { get; }
    UserCoordinateSystem UserCoordinateSystemOrientation { get; set; }
    Point ViewCubeOrientationOrigin { get; set; }
    // Methods
    void SetCustomThumbnail(string FullFileName);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BIMComponent](../objects/BIMComponent.md).ComponentDescription

**Referenced types:** [BIMComponentOrientationTypeEnum](../enums/BIMComponentOrientationTypeEnum.md), [BIMComponentPropertySets](../objects/BIMComponentPropertySets.md), [IPictureDisp](../objects/IPictureDisp.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [UserCoordinateSystem](../objects/UserCoordinateSystem.md)

