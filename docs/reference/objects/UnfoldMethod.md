# UnfoldMethod

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Style](../objects/Style.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition → (SheetMetalComponentDefinition).UnfoldMethod`

```csharp
interface UnfoldMethod
{
    // Properties
    object Application { get; }
    BendAngleTypeEnum BendAngleType { get; set; }
    string Comments { get; set; }
    int EquationCount { get; }
    UnfoldMethodEquationTypeEnum EquationType { get; }
    bool InUse { get; }
    string InternalName { get; }
    string Name { get; set; }
    object Parent { get; }
    string SplineFactor { get; set; }
    StyleLocationEnum StyleLocation { get; }
    StyleTypeEnum StyleType { get; }
    ObjectTypeEnum Type { get; }
    UnfoldMethodTypeEnum UnfoldMethodType { get; }
    bool UpToDate { get; }
    string kFactor { get; set; }
    // Methods
    Style ConvertToLocal();
    Style Copy(string Name);
    void Delete();
    void DeleteEquation(int Index);
    void GetEquation(int Index, out string Equation, out string MinimumValue, out ComparisonTypeEnum MinimumCompareCondition, out string BoundedVariable, out string MaximumValue, out ComparisonTypeEnum MaximumCompareCondition);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SaveToGlobal();
    void SetEquation(int Index, UnfoldMethodEquationTypeEnum EquationType, string Equation, string MinimumValue = "0 deg", ComparisonTypeEnum MinimumCompareCondition = ComparisonTypeEnum.kLessThanOrEqualToComparisonType, string BoundedVariable = "Angle", string MaximumValue = "180 deg", ComparisonTypeEnum MaximumCompareCondition = ComparisonTypeEnum.kLessThanOrEqualToComparisonType);
    void UpdateFromGlobal();
    void WriteBendTableToFile(string FileName);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BendDefinition](../objects/BendDefinition.md).UnfoldMethod, [ContourFlangeDefinition](../objects/ContourFlangeDefinition.md).UnfoldMethod, [FlangeDefinition](../objects/FlangeDefinition.md).UnfoldMethod, [FoldDefinition](../objects/FoldDefinition.md).UnfoldMethod, [HemDefinition](../objects/HemDefinition.md).UnfoldMethod, [LoftedFlangeDefinition](../objects/LoftedFlangeDefinition.md).UnfoldMethod, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).UnfoldMethod, [SheetMetalStyle](../objects/SheetMetalStyle.md).UnfoldMethod, [UnfoldMethods](../objects/UnfoldMethods.md).AddBendTableFromFile, [UnfoldMethods](../objects/UnfoldMethods.md).AddEquationUnfoldMethod, [UnfoldMethods](../objects/UnfoldMethods.md).AddLinearUnfoldMethod, [UnfoldMethods](../objects/UnfoldMethods.md).Item

**Referenced types:** [BendAngleTypeEnum](../enums/BendAngleTypeEnum.md), [ComparisonTypeEnum](../enums/ComparisonTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Style](../objects/Style.md), [StyleLocationEnum](../enums/StyleLocationEnum.md), [StyleTypeEnum](../enums/StyleTypeEnum.md), [UnfoldMethodEquationTypeEnum](../enums/UnfoldMethodEquationTypeEnum.md), [UnfoldMethodTypeEnum](../enums/UnfoldMethodTypeEnum.md)

