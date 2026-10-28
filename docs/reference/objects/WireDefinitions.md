# WireDefinitions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientBRep.CreateSurfaceBodyDefinition(…).LumpDefinitions.Item[…].FaceShellDefinitions.Item[…].WireDefinitions`

```csharp
interface WireDefinitions
{
    // Properties
    object Application { get; }
    int Count { get; }
    WireDefinition Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    WireDefinition Add();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FaceShellDefinition](../objects/FaceShellDefinition.md).WireDefinitions

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [WireDefinition](../objects/WireDefinition.md)

