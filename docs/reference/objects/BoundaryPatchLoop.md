# BoundaryPatchLoop

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.BoundaryPatchFeatures.Item[…].Definition.BoundaryPatchLoops.Item[…]`

```csharp
interface BoundaryPatchLoop
{
    // Properties
    object Application { get; }
    object BoundaryPath { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    BoundaryPatchConditionEnum GetBoundaryCondition(object BoundaryPathEntity);
    object GetBoundaryTangentWeight(object BoundaryPathEntity);
    void SetBoundaryCondition(object BoundaryPathEntity, BoundaryPatchConditionEnum BoundaryPathCondition);
    void SetBoundaryTangentWeight(object BoundaryPathEntity, object BoundaryPathTangentWeight);
}
```

**Returned by:** [BoundaryPatchLoops](../objects/BoundaryPatchLoops.md).Add, [BoundaryPatchLoops](../objects/BoundaryPatchLoops.md).Item

**Referenced types:** [BoundaryPatchConditionEnum](../enums/BoundaryPatchConditionEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

