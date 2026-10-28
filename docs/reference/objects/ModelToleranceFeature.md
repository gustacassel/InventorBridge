# ModelToleranceFeature

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelToleranceFeatures.Item[…]`

```csharp
interface ModelToleranceFeature
{
    // Properties
    FaceCollection AllFaces { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    string ClientId { get; }
    ModelToleranceFeatureConstrainedStatusEnum ConstrainedStatus { get; set; }
    HealthStatusEnum HealthStatus { get; }
    string Name { get; set; }
    ComponentDefinition Parent { get; }
    ModelToleranceFeature ParentToleranceFeature { get; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

5 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AngularModelDimension](../objects/AngularModelDimension.md).OwnedByToleranceFeature, [AngularModelDimension](../objects/AngularModelDimension.md).TopToleranceFeature, [AngularModelDimensionProxy](../objects/AngularModelDimensionProxy.md).OwnedByToleranceFeature, [AngularModelDimensionProxy](../objects/AngularModelDimensionProxy.md).TopToleranceFeature, [DiameterModelDimension](../objects/DiameterModelDimension.md).OwnedByToleranceFeature, [DiameterModelDimension](../objects/DiameterModelDimension.md).TopToleranceFeature, [DiameterModelDimensionProxy](../objects/DiameterModelDimensionProxy.md).OwnedByToleranceFeature, [DiameterModelDimensionProxy](../objects/DiameterModelDimensionProxy.md).TopToleranceFeature, [LinearModelDimension](../objects/LinearModelDimension.md).OwnedByToleranceFeature, [LinearModelDimension](../objects/LinearModelDimension.md).TopToleranceFeature, [LinearModelDimensionProxy](../objects/LinearModelDimensionProxy.md).OwnedByToleranceFeature, [LinearModelDimensionProxy](../objects/LinearModelDimensionProxy.md).TopToleranceFeature, [ModelAnnotation](../objects/ModelAnnotation.md).OwnedByToleranceFeature, [ModelAnnotation](../objects/ModelAnnotation.md).TopToleranceFeature, [ModelCompositeAnnotation](../objects/ModelCompositeAnnotation.md).OwnedByToleranceFeature, [ModelCompositeAnnotation](../objects/ModelCompositeAnnotation.md).TopToleranceFeature, [ModelCompositeAnnotationProxy](../objects/ModelCompositeAnnotationProxy.md).OwnedByToleranceFeature, [ModelCompositeAnnotationProxy](../objects/ModelCompositeAnnotationProxy.md).TopToleranceFeature, [ModelDatumIdentifier](../objects/ModelDatumIdentifier.md).OwnedByToleranceFeature, [ModelDatumIdentifier](../objects/ModelDatumIdentifier.md).TopToleranceFeature, [ModelDatumIdentifierProxy](../objects/ModelDatumIdentifierProxy.md).OwnedByToleranceFeature, [ModelDatumIdentifierProxy](../objects/ModelDatumIdentifierProxy.md).TopToleranceFeature, [ModelDatumTarget](../objects/ModelDatumTarget.md).OwnedByToleranceFeature, [ModelDatumTarget](../objects/ModelDatumTarget.md).TopToleranceFeature, [ModelDatumTargetProxy](../objects/ModelDatumTargetProxy.md).OwnedByToleranceFeature, [ModelDatumTargetProxy](../objects/ModelDatumTargetProxy.md).TopToleranceFeature, [ModelDimension](../objects/ModelDimension.md).OwnedByToleranceFeature, [ModelDimension](../objects/ModelDimension.md).TopToleranceFeature, [ModelFeatureControlFrame](../objects/ModelFeatureControlFrame.md).OwnedByToleranceFeature, [ModelFeatureControlFrame](../objects/ModelFeatureControlFrame.md).TopToleranceFeature, [ModelFeatureControlFrameProxy](../objects/ModelFeatureControlFrameProxy.md).OwnedByToleranceFeature, [ModelFeatureControlFrameProxy](../objects/ModelFeatureControlFrameProxy.md).TopToleranceFeature, [ModelGeneralNote](../objects/ModelGeneralNote.md).OwnedByToleranceFeature, [ModelGeneralNote](../objects/ModelGeneralNote.md).TopToleranceFeature, [ModelGeneralNoteProxy](../objects/ModelGeneralNoteProxy.md).OwnedByToleranceFeature, [ModelGeneralNoteProxy](../objects/ModelGeneralNoteProxy.md).TopToleranceFeature, [ModelHoleThreadNote](../objects/ModelHoleThreadNote.md).OwnedByToleranceFeature, [ModelHoleThreadNote](../objects/ModelHoleThreadNote.md).TopToleranceFeature, [ModelHoleThreadNoteProxy](../objects/ModelHoleThreadNoteProxy.md).OwnedByToleranceFeature, [ModelHoleThreadNoteProxy](../objects/ModelHoleThreadNoteProxy.md).TopToleranceFeature and 22 more (see `members.tsv`)

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [FaceCollection](../objects/FaceCollection.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ModelToleranceFeatureConstrainedStatusEnum](../enums/ModelToleranceFeatureConstrainedStatusEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

