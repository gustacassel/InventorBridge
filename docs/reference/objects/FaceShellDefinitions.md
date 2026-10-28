# FaceShellDefinitions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientBRep.CreateSurfaceBodyDefinition(…).LumpDefinitions.Item[…].FaceShellDefinitions`

```csharp
interface FaceShellDefinitions
{
    // Properties
    object Application { get; }
    int Count { get; }
    FaceShellDefinition Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    FaceShellDefinition Add();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [LumpDefinition](../objects/LumpDefinition.md).FaceShellDefinitions

**Referenced types:** [FaceShellDefinition](../objects/FaceShellDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

