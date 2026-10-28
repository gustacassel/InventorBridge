# DerivedPartEntities

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.DerivedFuturePartComponents.Item[…].Definition.Solids`

```csharp
interface DerivedPartEntities
{
    // Properties
    object Application { get; }
    int Count { get; }
    DerivedPartEntity Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DerivedFuturePartDefinition](../objects/DerivedFuturePartDefinition.md).Solids, [DerivedFuturePartDefinition](../objects/DerivedFuturePartDefinition.md).Surfaces, [DerivedPartCoordinateSystemDef](../objects/DerivedPartCoordinateSystemDef.md).Finishes, [DerivedPartCoordinateSystemDef](../objects/DerivedPartCoordinateSystemDef.md).Parameters, [DerivedPartCoordinateSystemDef](../objects/DerivedPartCoordinateSystemDef.md).Solids, [DerivedPartCoordinateSystemDef](../objects/DerivedPartCoordinateSystemDef.md).Surfaces, [DerivedPartCoordinateSystemDef](../objects/DerivedPartCoordinateSystemDef.md).iMateDefinitions, [DerivedPartDefinition](../objects/DerivedPartDefinition.md).Finishes, [DerivedPartDefinition](../objects/DerivedPartDefinition.md).Parameters, [DerivedPartDefinition](../objects/DerivedPartDefinition.md).Solids, [DerivedPartDefinition](../objects/DerivedPartDefinition.md).Surfaces, [DerivedPartDefinition](../objects/DerivedPartDefinition.md).iMateDefinitions, [DerivedPartTransformDef](../objects/DerivedPartTransformDef.md).Finishes, [DerivedPartTransformDef](../objects/DerivedPartTransformDef.md).Parameters, [DerivedPartTransformDef](../objects/DerivedPartTransformDef.md).Solids, [DerivedPartTransformDef](../objects/DerivedPartTransformDef.md).Surfaces, [DerivedPartTransformDef](../objects/DerivedPartTransformDef.md).iMateDefinitions, [DerivedPartUniformScaleDef](../objects/DerivedPartUniformScaleDef.md).Finishes, [DerivedPartUniformScaleDef](../objects/DerivedPartUniformScaleDef.md).Parameters, [DerivedPartUniformScaleDef](../objects/DerivedPartUniformScaleDef.md).SketchBlockDefinitions, [DerivedPartUniformScaleDef](../objects/DerivedPartUniformScaleDef.md).SketchBlocks, [DerivedPartUniformScaleDef](../objects/DerivedPartUniformScaleDef.md).Sketches, [DerivedPartUniformScaleDef](../objects/DerivedPartUniformScaleDef.md).Sketches3D, [DerivedPartUniformScaleDef](../objects/DerivedPartUniformScaleDef.md).Solids, [DerivedPartUniformScaleDef](../objects/DerivedPartUniformScaleDef.md).Surfaces, [DerivedPartUniformScaleDef](../objects/DerivedPartUniformScaleDef.md).WorkFeatures, [DerivedPartUniformScaleDef](../objects/DerivedPartUniformScaleDef.md).iMateDefinitions

**Referenced types:** [DerivedPartEntity](../objects/DerivedPartEntity.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

