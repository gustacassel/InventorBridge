# ModelDimensions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelDimensions`

```csharp
interface ModelDimensions
{
    // Properties
    AngularModelDimensions AngularModelDimensions { get; }
    object Application { get; }
    int Count { get; }
    DiameterModelDimensions DiameterModelDimensions { get; }
    ModelDimension Item[object Index] { get; }
    LinearModelDimensions LinearModelDimensions { get; }
    RadiusModelDimensions RadiusModelDimensions { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ModelDimension PromoteFrom(object pDimConstr);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelAnnotations](../objects/ModelAnnotations.md).ModelDimensions

**Referenced types:** [AngularModelDimensions](../objects/AngularModelDimensions.md), [DiameterModelDimensions](../objects/DiameterModelDimensions.md), [LinearModelDimensions](../objects/LinearModelDimensions.md), [ModelDimension](../objects/ModelDimension.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RadiusModelDimensions](../objects/RadiusModelDimensions.md)

