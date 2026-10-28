# ModelToleranceFeatureProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ModelToleranceFeature](../objects/ModelToleranceFeature.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelToleranceFeatures.Item[…] → (ModelToleranceFeatureProxy)`

```csharp
interface ModelToleranceFeatureProxy
{
    // Properties
    FaceCollection AllFaces { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    string ClientId { get; }
    ModelToleranceFeatureConstrainedStatusEnum ConstrainedStatus { get; set; }
    ComponentOccurrence ContainingOccurrence { get; }
    HealthStatusEnum HealthStatus { get; }
    string Name { get; set; }
    ModelToleranceFeature NativeObject { get; }
    ComponentDefinition Parent { get; }
    ModelToleranceFeature ParentToleranceFeature { get; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

5 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [FaceCollection](../objects/FaceCollection.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ModelToleranceFeature](../objects/ModelToleranceFeature.md), [ModelToleranceFeatureConstrainedStatusEnum](../enums/ModelToleranceFeatureConstrainedStatusEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

