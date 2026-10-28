# LightingStyles

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).LightingStyles`

```csharp
interface LightingStyles
{
    // Properties
    object Application { get; }
    int Count { get; }
    LightingStyle Item[object Index] { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    LightingStyle Add(string Name);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyDocument](../objects/AssemblyDocument.md).LightingStyles, [PartDocument](../objects/PartDocument.md).LightingStyles, [PresentationDocument](../objects/PresentationDocument.md).LightingStyles

**Referenced types:** [LightingStyle](../objects/LightingStyle.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

