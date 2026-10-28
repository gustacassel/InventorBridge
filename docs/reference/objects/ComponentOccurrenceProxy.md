# ComponentOccurrenceProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ComponentOccurrence](../objects/ComponentOccurrence.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Occurrences.Item[…] → (ComponentOccurrenceProxy)`

```csharp
interface ComponentOccurrenceProxy
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
    ComponentOccurrence ContainingOccurrence { get; }
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
    ComponentOccurrence NativeObject { get; }
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

**Referenced types:** [ActionTypeEnum](../enums/ActionTypeEnum.md), [AppearanceSourceTypeEnum](../enums/AppearanceSourceTypeEnum.md), [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md), [AssemblyConstraintsEnumerator](../objects/AssemblyConstraintsEnumerator.md), [AssemblyJointsEnumerator](../objects/AssemblyJointsEnumerator.md), [Asset](../objects/Asset.md), [AttributeSets](../objects/AttributeSets.md), [BOMStructureEnum](../enums/BOMStructureEnum.md), [Box](../objects/Box.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ComponentOccurrencesEnumerator](../objects/ComponentOccurrencesEnumerator.md), [DisplayModeEnum](../enums/DisplayModeEnum.md), [DisplayModeSourceTypeEnum](../enums/DisplayModeSourceTypeEnum.md), [DocumentDescriptor](../objects/DocumentDescriptor.md), [DocumentTypeEnum](../enums/DocumentTypeEnum.md), [ExitTypeEnum](../enums/ExitTypeEnum.md), [ImportedComponent](../objects/ImportedComponent.md), [MassProperties](../objects/MassProperties.md), [Matrix](../objects/Matrix.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [OccurrencePatternElement](../objects/OccurrencePatternElement.md), [OrientedBox](../objects/OrientedBox.md), [Point](../objects/Point.md), [PropertySets](../objects/PropertySets.md), [SurfaceBodies](../objects/SurfaceBodies.md), [iMateDefinitionsEnumerator](../objects/iMateDefinitionsEnumerator.md)

