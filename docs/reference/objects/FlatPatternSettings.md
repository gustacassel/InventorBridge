# FlatPatternSettings

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).FlatPatternSettings`

```csharp
interface FlatPatternSettings
{
    // Properties
    object Application { get; }
    bool DeferUpdate { get; set; }
    Document Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [PartDocument](../objects/PartDocument.md).FlatPatternSettings

**Referenced types:** [Document](../objects/Document.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

