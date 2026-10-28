# VertexDefinitions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientBRep.CreateSurfaceBodyDefinition(…).VertexDefinitions`

```csharp
interface VertexDefinitions
{
    // Properties
    object Application { get; }
    int Count { get; }
    VertexDefinition Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    VertexDefinition Add(Point Position);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SurfaceBodyDefinition](../objects/SurfaceBodyDefinition.md).VertexDefinitions

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [VertexDefinition](../objects/VertexDefinition.md)

