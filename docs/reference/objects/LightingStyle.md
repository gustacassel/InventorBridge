# LightingStyle

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Style](../objects/Style.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).LightingStyles.Item[…]`

```csharp
interface LightingStyle
{
    // Properties
    double Ambience { get; set; }
    double AmbientShadowIntensity { get; set; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    double Brightness { get; set; }
    int Exposure { get; set; }
    double ImageBasedLightingBrightness { get; set; }
    double ImageBasedLightingRotation { get; set; }
    double ImageBasedLightingScale { get; set; }
    bool ImageBasedLightingShowImage { get; set; }
    bool InUse { get; }
    string InternalName { get; }
    LightingStyleTypeEnum LightingStyleType { get; }
    Lights Lights { get; }
    string Name { get; set; }
    object Parent { get; }
    double ShadowDensity { get; set; }
    ShadowDirectionEnum ShadowDirection { get; set; }
    double ShadowSoftness { get; set; }
    StyleLocationEnum StyleLocation { get; }
    ObjectTypeEnum Type { get; }
    bool UpToDate { get; }
    // Methods
    LightingStyle ConvertToLocal();
    LightingStyle Copy(string NewName);
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SaveToGlobal();
    void UpdateFromGlobal();
    void UploadImage(string ImageFileName, object EnvName = Missing);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyDocument](../objects/AssemblyDocument.md).ActiveLightingStyle, [Light](../objects/Light.md).Parent, [LightingStyle](../objects/LightingStyle.md).ConvertToLocal, [LightingStyle](../objects/LightingStyle.md).Copy, [LightingStyles](../objects/LightingStyles.md).Add, [LightingStyles](../objects/LightingStyles.md).Item, [PartDocument](../objects/PartDocument.md).ActiveLightingStyle, [PresentationDocument](../objects/PresentationDocument.md).ActiveLightingStyle

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [LightingStyleTypeEnum](../enums/LightingStyleTypeEnum.md), [Lights](../objects/Lights.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ShadowDirectionEnum](../enums/ShadowDirectionEnum.md), [StyleLocationEnum](../enums/StyleLocationEnum.md)

