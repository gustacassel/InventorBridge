# CentermarkStyle

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Style](../objects/Style.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.CentermarkStyles.Item[…]`

```csharp
interface CentermarkStyle
{
    // Properties
    object Application { get; }
    string Comments { get; set; }
    double DefaultRadius { get; set; }
    double ExtensionLength { get; set; }
    double GapDistance { get; set; }
    bool InUse { get; }
    string InternalName { get; }
    double MarkSize { get; set; }
    string Name { get; set; }
    double OvershootDistance { get; set; }
    object Parent { get; }
    StyleLocationEnum StyleLocation { get; }
    StyleTypeEnum StyleType { get; }
    ObjectTypeEnum Type { get; }
    bool UpToDate { get; }
    // Methods
    Style ConvertToLocal();
    Style Copy(string Name);
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SaveToGlobal();
    void UpdateFromGlobal();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Centerline](../objects/Centerline.md).Style, [Centermark](../objects/Centermark.md).Style, [CentermarkStylesEnumerator](../objects/CentermarkStylesEnumerator.md).Item, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).CenterOfGravityStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).CenterlineStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).CentermarkStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).SheetMetalPunchStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).WorkAxisStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).WorkPlaneStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).WorkPointStyle

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Style](../objects/Style.md), [StyleLocationEnum](../enums/StyleLocationEnum.md), [StyleTypeEnum](../enums/StyleTypeEnum.md)

