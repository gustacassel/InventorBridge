# SurfaceTextureStyle

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Style](../objects/Style.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.SurfaceTextureStyles.Item[…]`

```csharp
interface SurfaceTextureStyle
{
    // Properties
    object Application { get; }
    LayDirectionTypeEnum AvailableLaySymbols { get; set; }
    ProfileDirectionTypeEnum AvailableProfileDirectionSymbols { get; set; } // since 2025
    string Comments { get; set; }
    bool EnableAllAroundSymbol { get; set; } // since 2025
    bool InUse { get; }
    string InternalName { get; }
    LeaderStyle LeaderStyle { get; set; }
    bool MachiningProhibitedSymbolSizeSmall { get; set; }
    MajorityTypeEnum MajorityType { get; set; }
    string Name { get; set; }
    object Parent { get; }
    SurfaceTextureStandardReferenceTypeEnum StandardReferenceType { get; set; } // since 2025
    StyleLocationEnum StyleLocation { get; }
    StyleTypeEnum StyleType { get; }
    TextStyle TextStyle { get; set; }
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

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).SurfaceTextureStyle, [SurfaceTextureStylesEnumerator](../objects/SurfaceTextureStylesEnumerator.md).Item, [SurfaceTextureSymbol](../objects/SurfaceTextureSymbol.md).Style

**Referenced types:** [LayDirectionTypeEnum](../enums/LayDirectionTypeEnum.md), [LeaderStyle](../objects/LeaderStyle.md), [MajorityTypeEnum](../enums/MajorityTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ProfileDirectionTypeEnum](../enums/ProfileDirectionTypeEnum.md), [Style](../objects/Style.md), [StyleLocationEnum](../enums/StyleLocationEnum.md), [StyleTypeEnum](../enums/StyleTypeEnum.md), [SurfaceTextureStandardReferenceTypeEnum](../enums/SurfaceTextureStandardReferenceTypeEnum.md), [TextStyle](../objects/TextStyle.md)

