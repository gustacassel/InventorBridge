# AnnotationPlane

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.AnnotationPlanes.Item[…]`

```csharp
interface AnnotationPlane
{
    // Properties
    ModelAnnotationsEnumerator Annotations { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    AnnotationPlaneDefinition Definition { get; }
    ComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AngularModelDimensionDefinition](../objects/AngularModelDimensionDefinition.md).AnnotationPlane, [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md).Parent, [AnnotationPlaneProxy](../objects/AnnotationPlaneProxy.md).NativeObject, [AnnotationPlanes](../objects/AnnotationPlanes.md).Item, [DiameterModelDimensionDefinition](../objects/DiameterModelDimensionDefinition.md).AnnotationPlane, [LinearModelDimensionDefinition](../objects/LinearModelDimensionDefinition.md).AnnotationPlane, [ModelDatumIdentifierDefinition](../objects/ModelDatumIdentifierDefinition.md).AnnotationPlane, [ModelDatumTarget](../objects/ModelDatumTarget.md).AnnotationPlane, [ModelDatumTargetProxy](../objects/ModelDatumTargetProxy.md).AnnotationPlane, [ModelDimensionDefinition](../objects/ModelDimensionDefinition.md).AnnotationPlane, [ModelFeatureControlFrameDefinition](../objects/ModelFeatureControlFrameDefinition.md).AnnotationPlane, [ModelGeneralNoteDefinition](../objects/ModelGeneralNoteDefinition.md).AnnotationPlane, [ModelHoleThreadNoteDefinition](../objects/ModelHoleThreadNoteDefinition.md).AnnotationPlane, [ModelLeaderNoteDefinition](../objects/ModelLeaderNoteDefinition.md).AnnotationPlane, [ModelSurfaceTextureSymbolDefinition](../objects/ModelSurfaceTextureSymbolDefinition.md).AnnotationPlane, [ModelWeldingSymbolDefinitions](../objects/ModelWeldingSymbolDefinitions.md).AnnotationPlane, [RadiusModelDimensionDefinition](../objects/RadiusModelDimensionDefinition.md).AnnotationPlane

**Referenced types:** [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md), [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ModelAnnotationsEnumerator](../objects/ModelAnnotationsEnumerator.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

