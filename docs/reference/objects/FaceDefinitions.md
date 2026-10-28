# FaceDefinitions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientBRep.CreateSurfaceBodyDefinition(…).LumpDefinitions.Item[…].FaceShellDefinitions.Item[…].FaceDefinitions`

```csharp
interface FaceDefinitions
{
    // Properties
    object Application { get; }
    int Count { get; }
    FaceDefinition Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    FaceDefinition Add(object SurfaceGeometry, bool IsParamReversed);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FaceShellDefinition](../objects/FaceShellDefinition.md).FaceDefinitions

**Referenced types:** [FaceDefinition](../objects/FaceDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

