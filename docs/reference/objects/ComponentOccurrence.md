# ComponentOccurrence

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Occurrences.Item[…]`

```csharp
interface ComponentOccurrence
{
    // Properties
    string ActiveDesignViewRepresentation { get; }
    string ActiveModelState { get; set; }
    string ActivePositionalRepresentation { get; set; }
    bool Adaptive { get; set; }
    Asset Appearance { get; set; }
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    object Application { get; }
    string AssociativeForeignFilename { get; }
    AttributeSets AttributeSets { get; }
    BOMStructureEnum BOMStructure { get; set; }
    AssemblyConstraintsEnumerator Constraints { get; }
    bool ContactSet { get; set; }
    ComponentDefinition ContextDefinition { get; }
    ComponentDefinition Definition { get; }
    DocumentTypeEnum DefinitionDocumentType { get; }
    ActionTypeEnum DisabledActionTypes { get; set; }
    bool Enabled { get; set; }
    bool Excluded { get; set; }
    bool Flexible { get; set; }
    bool Grounded { get; set; }
    bool HasAssociativeImportedComponent { get; }
    bool HasBodyOverride { get; }
    ImportedComponent ImportedComponent { get; }
    bool IsAssociativeToDesignViewRepresentation { get; set; }
    bool IsAssociativelyImported { get; }
    bool IsPatternElement { get; }
    bool IsSubstituteOccurrence { get; }
    bool IsiAssemblyMember { get; }
    bool IsiPartMember { get; }
    AssemblyJointsEnumerator Joints { get; }
    MassProperties MassProperties { get; }
    string Name { get; set; }
    ComponentOccurrencesEnumerator OccurrencePath { get; }
    PropertySets OccurrencePropertySets { get; }
    bool OccurrencePropertySetsEnabled { get; set; }
    OrientedBox OrientedMinimumRangeBox { get; }
    double OverrideOpacity { get; set; }
    AssemblyComponentDefinition Parent { get; }
    ComponentOccurrence ParentOccurrence { get; }
    OccurrencePatternElement PatternElement { get; }
    Box PreciseRangeBox { get; }
    Box RangeBox { get; }
    DocumentDescriptor ReferencedDocumentDescriptor { get; }
    bool ShowDegreesOfFreedom { get; set; }
    ComponentOccurrencesEnumerator SubOccurrences { get; }
    bool Suppressed { get; }
    SurfaceBodies SurfaceBodies { get; }
    Matrix Transformation { get; set; }
    bool Transparent { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    iMateDefinitionsEnumerator iMateDefinitions { get; }
    // Methods
    void ChangeRowOfiAssemblyMember(object NewRow, object Options = Missing);
    void ChangeRowOfiPartMember(object NewRow, object CustomInput = Missing);
    void CreateGeometryProxy(object Geometry, out object Result);
    void Delete();
    void Delete2(bool SkipDocumentSave = false);
    void Edit();
    void ExitEdit(ExitTypeEnum ExitTo);
    void GetDegreesOfFreedom(out int TranslationDegreesCount, out ObjectsEnumerator TranslationDegreesVectors, out int RotationDegreesCount, out ObjectsEnumerator RotationDegreesVectors, out Point DOFCenter);
    DisplayModeEnum GetDisplayMode(out DisplayModeSourceTypeEnum DisplayModeSourceType);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void Replace(string FileName, bool ReplaceAll);
    void Replace2(string FileName, bool ReplaceAll, object SaveEdits = Missing, object KeepAdaptivity = Missing);
    void SetDesignViewRepresentation(string Representation, string Reserved = "", bool Associative = false);
    void SetDisplayMode(DisplayModeSourceTypeEnum DisplayModeSourceType, object DisplayMode = Missing);
    void SetTransformWithoutConstraints(Matrix Matrix);
    void ShowRelationships();
    void Suppress(bool SkipDocumentSave = false);
    void Unsuppress();
}
```

21 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AngleConstraint](../objects/AngleConstraint.md).AffectedOccurrenceOne, [AngleConstraint](../objects/AngleConstraint.md).AffectedOccurrenceTwo, [AngleConstraint](../objects/AngleConstraint.md).OccurrenceOne, [AngleConstraint](../objects/AngleConstraint.md).OccurrenceTwo, [AngleConstraintProxy](../objects/AngleConstraintProxy.md).AffectedOccurrenceOne, [AngleConstraintProxy](../objects/AngleConstraintProxy.md).AffectedOccurrenceTwo, [AngleConstraintProxy](../objects/AngleConstraintProxy.md).ContainingOccurrence, [AngleConstraintProxy](../objects/AngleConstraintProxy.md).OccurrenceOne, [AngleConstraintProxy](../objects/AngleConstraintProxy.md).OccurrenceTwo, [AngleiMateDefinitionProxy](../objects/AngleiMateDefinitionProxy.md).ContainingOccurrence, [AngularModelDimensionProxy](../objects/AngularModelDimensionProxy.md).ContainingOccurrence, [AnnotationPlaneProxy](../objects/AnnotationPlaneProxy.md).ContainingOccurrence, [ArcLengthDimConstraintProxy](../objects/ArcLengthDimConstraintProxy.md).ContainingOccurrence, [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).ActiveOccurrence, [AssemblyConstraint](../objects/AssemblyConstraint.md).AffectedOccurrenceOne, [AssemblyConstraint](../objects/AssemblyConstraint.md).AffectedOccurrenceTwo, [AssemblyConstraint](../objects/AssemblyConstraint.md).OccurrenceOne, [AssemblyConstraint](../objects/AssemblyConstraint.md).OccurrenceTwo, [AssemblyJoint](../objects/AssemblyJoint.md).AffectedOccurrenceOne, [AssemblyJoint](../objects/AssemblyJoint.md).AffectedOccurrenceTwo, [AssemblyJoint](../objects/AssemblyJoint.md).OccurrenceOne, [AssemblyJoint](../objects/AssemblyJoint.md).OccurrenceTwo, [AssemblyJointProxy](../objects/AssemblyJointProxy.md).AffectedOccurrenceOne, [AssemblyJointProxy](../objects/AssemblyJointProxy.md).AffectedOccurrenceTwo, [AssemblyJointProxy](../objects/AssemblyJointProxy.md).ContainingOccurrence, [AssemblyJointProxy](../objects/AssemblyJointProxy.md).OccurrenceOne, [AssemblyJointProxy](../objects/AssemblyJointProxy.md).OccurrenceTwo, [AssemblySymmetryConstraint](../objects/AssemblySymmetryConstraint.md).AffectedOccurrenceOne, [AssemblySymmetryConstraint](../objects/AssemblySymmetryConstraint.md).AffectedOccurrenceTwo, [AssemblySymmetryConstraint](../objects/AssemblySymmetryConstraint.md).OccurrenceOne, [AssemblySymmetryConstraint](../objects/AssemblySymmetryConstraint.md).OccurrenceTwo, [AssemblySymmetryConstraintProxy](../objects/AssemblySymmetryConstraintProxy.md).AffectedOccurrenceOne, [AssemblySymmetryConstraintProxy](../objects/AssemblySymmetryConstraintProxy.md).AffectedOccurrenceTwo, [AssemblySymmetryConstraintProxy](../objects/AssemblySymmetryConstraintProxy.md).ContainingOccurrence, [AssemblySymmetryConstraintProxy](../objects/AssemblySymmetryConstraintProxy.md).OccurrenceOne, [AssemblySymmetryConstraintProxy](../objects/AssemblySymmetryConstraintProxy.md).OccurrenceTwo, [BendConstraintProxy](../objects/BendConstraintProxy.md).ContainingOccurrence, [BendPartFeatureProxy](../objects/BendPartFeatureProxy.md).ContainingOccurrence, [BossFeatureProxy](../objects/BossFeatureProxy.md).ContainingOccurrence, [BoundaryPatchFeatureProxy](../objects/BoundaryPatchFeatureProxy.md).ContainingOccurrence and 322 more (see `members.tsv`)

**Referenced types:** [ActionTypeEnum](../enums/ActionTypeEnum.md), [AppearanceSourceTypeEnum](../enums/AppearanceSourceTypeEnum.md), [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md), [AssemblyConstraintsEnumerator](../objects/AssemblyConstraintsEnumerator.md), [AssemblyJointsEnumerator](../objects/AssemblyJointsEnumerator.md), [Asset](../objects/Asset.md), [AttributeSets](../objects/AttributeSets.md), [BOMStructureEnum](../enums/BOMStructureEnum.md), [Box](../objects/Box.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrencesEnumerator](../objects/ComponentOccurrencesEnumerator.md), [DisplayModeEnum](../enums/DisplayModeEnum.md), [DisplayModeSourceTypeEnum](../enums/DisplayModeSourceTypeEnum.md), [DocumentDescriptor](../objects/DocumentDescriptor.md), [DocumentTypeEnum](../enums/DocumentTypeEnum.md), [ExitTypeEnum](../enums/ExitTypeEnum.md), [ImportedComponent](../objects/ImportedComponent.md), [MassProperties](../objects/MassProperties.md), [Matrix](../objects/Matrix.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [OccurrencePatternElement](../objects/OccurrencePatternElement.md), [OrientedBox](../objects/OrientedBox.md), [Point](../objects/Point.md), [PropertySets](../objects/PropertySets.md), [SurfaceBodies](../objects/SurfaceBodies.md), [iMateDefinitionsEnumerator](../objects/iMateDefinitionsEnumerator.md)

