# Sketch3DSettings

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).Sketch3DSettings`

```csharp
interface Sketch3DSettings
{
    // Properties
    object Application { get; }
    string AutoBendRadius { get; set; }
    Document Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [PartDocument](../objects/PartDocument.md).Sketch3DSettings

**Referenced types:** [Document](../objects/Document.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

