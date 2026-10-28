# LumpDefinitions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientBRep.CreateSurfaceBodyDefinition(…).LumpDefinitions`

```csharp
interface LumpDefinitions
{
    // Properties
    object Application { get; }
    int Count { get; }
    LumpDefinition Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    LumpDefinition Add();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SurfaceBodyDefinition](../objects/SurfaceBodyDefinition.md).LumpDefinitions

**Referenced types:** [LumpDefinition](../objects/LumpDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

