# Light

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).LightingStyles.Item[…].Lights.Item[…]`

```csharp
interface Light
{
    // Properties
    object Application { get; }
    Color Color { get; set; }
    double ConstantAttenuation { get; set; }
    Vector Direction { get; set; }
    double Intensity { get; set; }
    LightDefinitionTypeEnum LightDefinitionType { get; set; }
    LightTypeEnum LightType { get; set; }
    double LinearAttenuation { get; set; }
    bool On { get; set; }
    LightingStyle Parent { get; }
    Point Position { get; set; }
    double QuadraticAttenuation { get; set; }
    double SpotLightCutoffAngle { get; set; }
    double SpotLightFalloff { get; set; }
    double SpotLightInnerAngle { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [Lights](../objects/Lights.md).Add, [Lights](../objects/Lights.md).Item

**Referenced types:** [Color](../objects/Color.md), [LightDefinitionTypeEnum](../enums/LightDefinitionTypeEnum.md), [LightTypeEnum](../enums/LightTypeEnum.md), [LightingStyle](../objects/LightingStyle.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [Vector](../objects/Vector.md)

