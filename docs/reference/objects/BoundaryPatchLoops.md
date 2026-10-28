# BoundaryPatchLoops

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.BoundaryPatchFeatures.Item[…].Definition.BoundaryPatchLoops`

```csharp
interface BoundaryPatchLoops
{
    // Properties
    object Application { get; }
    int Count { get; }
    BoundaryPatchLoop Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    BoundaryPatchLoop Add(object BoundaryPath);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BoundaryPatchDefinition](../objects/BoundaryPatchDefinition.md).BoundaryPatchLoops

**Referenced types:** [BoundaryPatchLoop](../objects/BoundaryPatchLoop.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

