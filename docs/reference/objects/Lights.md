# Lights

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).LightingStyles.Item[…].Lights`

```csharp
interface Lights
{
    // Properties
    object Application { get; }
    int Count { get; }
    Light Item[object Index] { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    Light Add(LightTypeEnum LightType);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [LightingStyle](../objects/LightingStyle.md).Lights

**Referenced types:** [Light](../objects/Light.md), [LightTypeEnum](../enums/LightTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

