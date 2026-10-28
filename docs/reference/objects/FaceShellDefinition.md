# FaceShellDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientBRep.CreateSurfaceBodyDefinition(…).LumpDefinitions.Item[…].FaceShellDefinitions.Item[…]`

```csharp
interface FaceShellDefinition
{
    // Properties
    object Application { get; }
    FaceDefinitions FaceDefinitions { get; }
    ObjectTypeEnum Type { get; }
    WireDefinitions WireDefinitions { get; }
}
```

**Returned by:** [FaceShellDefinitions](../objects/FaceShellDefinitions.md).Add, [FaceShellDefinitions](../objects/FaceShellDefinitions.md).Item

**Referenced types:** [FaceDefinitions](../objects/FaceDefinitions.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [WireDefinitions](../objects/WireDefinitions.md)

