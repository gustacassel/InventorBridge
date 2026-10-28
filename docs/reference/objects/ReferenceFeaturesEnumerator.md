# ReferenceFeaturesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.ShrinkwrapComponents.Item[…].ReferenceFeatures`

```csharp
interface ReferenceFeaturesEnumerator
{
    // Properties
    int Count { get; }
    ReferenceFeature Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DerivedAssemblyComponent](../objects/DerivedAssemblyComponent.md).ReferenceFeatures, [DerivedAssemblyComponentProxy](../objects/DerivedAssemblyComponentProxy.md).ReferenceFeatures, [DerivedFutureAssemblyComponent](../objects/DerivedFutureAssemblyComponent.md).ReferenceFeatures, [DerivedFutureAssemblyComponentProxy](../objects/DerivedFutureAssemblyComponentProxy.md).ReferenceFeatures, [DerivedFuturePartComponent](../objects/DerivedFuturePartComponent.md).SolidBodies, [DerivedFuturePartComponent](../objects/DerivedFuturePartComponent.md).SurfaceBodies, [DerivedFuturePartComponentProxy](../objects/DerivedFuturePartComponentProxy.md).SolidBodies, [DerivedFuturePartComponentProxy](../objects/DerivedFuturePartComponentProxy.md).SurfaceBodies, [DerivedPartComponent](../objects/DerivedPartComponent.md).SolidBodies, [DerivedPartComponent](../objects/DerivedPartComponent.md).SurfaceBodies, [DerivedPartComponentProxy](../objects/DerivedPartComponentProxy.md).SolidBodies, [DerivedPartComponentProxy](../objects/DerivedPartComponentProxy.md).SurfaceBodies, [ShrinkwrapComponent](../objects/ShrinkwrapComponent.md).ReferenceFeatures, [ShrinkwrapComponentProxy](../objects/ShrinkwrapComponentProxy.md).ReferenceFeatures

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferenceFeature](../objects/ReferenceFeature.md)

