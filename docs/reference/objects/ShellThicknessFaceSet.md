# ShellThicknessFaceSet

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.ShellFeatures.Item[…].Definition.FaceSetItem[…]`

```csharp
interface ShellThicknessFaceSet
{
    // Properties
    object Application { get; }
    FaceCollection Faces { get; set; }
    Parameter Thickness { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

**Returned by:** [ShellDefinition](../objects/ShellDefinition.md).AddThicknessFaceSet, [ShellDefinition](../objects/ShellDefinition.md).FaceSetItem

**Referenced types:** [FaceCollection](../objects/FaceCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md)

