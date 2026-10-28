# LumpDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientBRep.CreateSurfaceBodyDefinition(…).LumpDefinitions.Item[…]`

```csharp
interface LumpDefinition
{
    // Properties
    object Application { get; }
    FaceShellDefinitions FaceShellDefinitions { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [LumpDefinitions](../objects/LumpDefinitions.md).Add, [LumpDefinitions](../objects/LumpDefinitions.md).Item

**Referenced types:** [FaceShellDefinitions](../objects/FaceShellDefinitions.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

