# ModelAnnotations

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations`

```csharp
interface ModelAnnotations
{
    // Properties
    object Application { get; }
    int Count { get; }
    ModelAnnotation Item[object Index] { get; }
    ModelCompositeAnnotations ModelCompositeAnnotations { get; }
    ModelDatumIdentifiers ModelDatumIdentifiers { get; }
    ModelDatums ModelDatums { get; }
    ModelDimensions ModelDimensions { get; }
    ModelFeatureControlFrames ModelFeatureControlFrames { get; }
    ModelGeneralNotes ModelGeneralNotes { get; }
    ModelHoleThreadNotes ModelHoleThreadNotes { get; }
    ModelLeaderNotes ModelLeaderNotes { get; }
    ModelSurfaceTextureSymbols ModelSurfaceTextureSymbols { get; }
    ModelWeldingSymbols ModelWeldingSymbols { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    AnnotationPlaneDefinitionsEnumerator CreateAnnotationPlaneDefinitionUsingIntents(ObjectTypeEnum AnnotationType, GeometryIntent IntentOne, object IntentTwo = Missing, object IntentThree = Missing, object XAxis = Missing);
    AnnotationPlaneDefinition CreateAnnotationPlaneDefinitionUsingPlane(object Plane, object XAxisDirection = Missing);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).ModelAnnotations, [FlatPattern](../objects/FlatPattern.md).ModelAnnotations, [PartComponentDefinition](../objects/PartComponentDefinition.md).ModelAnnotations, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).ModelAnnotations, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).ModelAnnotations

**Referenced types:** [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md), [AnnotationPlaneDefinitionsEnumerator](../objects/AnnotationPlaneDefinitionsEnumerator.md), [GeometryIntent](../objects/GeometryIntent.md), [ModelAnnotation](../objects/ModelAnnotation.md), [ModelCompositeAnnotations](../objects/ModelCompositeAnnotations.md), [ModelDatumIdentifiers](../objects/ModelDatumIdentifiers.md), [ModelDatums](../objects/ModelDatums.md), [ModelDimensions](../objects/ModelDimensions.md), [ModelFeatureControlFrames](../objects/ModelFeatureControlFrames.md), [ModelGeneralNotes](../objects/ModelGeneralNotes.md), [ModelHoleThreadNotes](../objects/ModelHoleThreadNotes.md), [ModelLeaderNotes](../objects/ModelLeaderNotes.md), [ModelSurfaceTextureSymbols](../objects/ModelSurfaceTextureSymbols.md), [ModelWeldingSymbols](../objects/ModelWeldingSymbols.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

