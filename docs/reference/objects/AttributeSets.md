# AttributeSets

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.AttributeSets`

```csharp
interface AttributeSets
{
    // Properties
    int Count { get; }
    DataIO DataIO { get; }
    AttributeSet Item[object Index] { get; }
    bool NameIsUsed[string AttributeSetName] { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    AttributeSet Add(string AttributeSetName, bool CopyWithOwner = false);
    AttributeSet AddTransient(string AttributeSetName, bool CopyWithOwner = false);
    bool ParentAvailable(out object Parent, out object Context = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AliasFreeformFeature](../objects/AliasFreeformFeature.md).AttributeSets, [AliasFreeformFeatureProxy](../objects/AliasFreeformFeatureProxy.md).AttributeSets, [AngleConstraint](../objects/AngleConstraint.md).AttributeSets, [AngleConstraintProxy](../objects/AngleConstraintProxy.md).AttributeSets, [AngleiMateDefinition](../objects/AngleiMateDefinition.md).AttributeSets, [AngleiMateDefinitionProxy](../objects/AngleiMateDefinitionProxy.md).AttributeSets, [AngularGeneralDimension](../objects/AngularGeneralDimension.md).AttributeSets, [AngularModelDimension](../objects/AngularModelDimension.md).AttributeSets, [AngularModelDimensionProxy](../objects/AngularModelDimensionProxy.md).AttributeSets, [AnnotationPlane](../objects/AnnotationPlane.md).AttributeSets, [AnnotationPlaneProxy](../objects/AnnotationPlaneProxy.md).AttributeSets, [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md).AttributeSets, [ApprenticeServerDrawingDocument](../objects/ApprenticeServerDrawingDocument.md).AttributeSets, [ArcLengthDimConstraint](../objects/ArcLengthDimConstraint.md).AttributeSets, [ArcLengthDimConstraintProxy](../objects/ArcLengthDimConstraintProxy.md).AttributeSets, [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).AttributeSets, [AssemblyConstraint](../objects/AssemblyConstraint.md).AttributeSets, [AssemblyDocument](../objects/AssemblyDocument.md).AttributeSets, [AssemblyJoint](../objects/AssemblyJoint.md).AttributeSets, [AssemblyJointProxy](../objects/AssemblyJointProxy.md).AttributeSets, [AssemblySymmetryConstraint](../objects/AssemblySymmetryConstraint.md).AttributeSets, [AssemblySymmetryConstraintProxy](../objects/AssemblySymmetryConstraintProxy.md).AttributeSets, [AutoCADBlock](../objects/AutoCADBlock.md).AttributeSets, [AutoCADBlockDefinition](../objects/AutoCADBlockDefinition.md).AttributeSets, [BOMRow](../objects/BOMRow.md).AttributeSets, [Balloon](../objects/Balloon.md).AttributeSets, [BaselineDimensionSet](../objects/BaselineDimensionSet.md).AttributeSets, [BendConstraint](../objects/BendConstraint.md).AttributeSets, [BendConstraintProxy](../objects/BendConstraintProxy.md).AttributeSets, [BendFeature](../objects/BendFeature.md).AttributeSets, [BendFeatureProxy](../objects/BendFeatureProxy.md).AttributeSets, [BendNote](../objects/BendNote.md).AttributeSets, [BendPartFeature](../objects/BendPartFeature.md).AttributeSets, [BendPartFeatureProxy](../objects/BendPartFeatureProxy.md).AttributeSets, [BorderDefinition](../objects/BorderDefinition.md).AttributeSets, [BossFeature](../objects/BossFeature.md).AttributeSets, [BossFeatureProxy](../objects/BossFeatureProxy.md).AttributeSets, [BoundaryPatchFeature](../objects/BoundaryPatchFeature.md).AttributeSets, [BoundaryPatchFeatureProxy](../objects/BoundaryPatchFeatureProxy.md).AttributeSets, [BreakOperation](../objects/BreakOperation.md).AttributeSets and 535 more (see `members.tsv`)

**Referenced types:** [AttributeSet](../objects/AttributeSet.md), [DataIO](../objects/DataIO.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

