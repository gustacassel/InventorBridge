# Parameters

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).Parameters`

```csharp
interface Parameters
{
    // Properties
    int AngularDimensionPrecision { get; set; }
    string AngularStandardTolerance[int Precision] { get; set; }
    int Count { get; }
    CustomParameterGroups CustomParameterGroups { get; }
    DerivedParameterTables DerivedParameterTables { get; }
    DimensionDisplayTypeEnum DimensionDisplayType { get; set; }
    bool DisplayParameterAsExpression { get; set; }
    bool ExportStandardTolerances { get; set; }
    FinishParameters FinishParameters { get; }
    Parameter Item[object Index] { get; }
    int LinearDimensionPrecision { get; set; }
    string LinearStandardTolerance[int Precision] { get; set; }
    ModelParameters ModelParameters { get; }
    ParameterTables ParameterTables { get; }
    ReferenceParameters ReferenceParameters { get; }
    ObjectTypeEnum Type { get; }
    bool UseStandardTolerances { get; set; }
    UserParameters UserParameters { get; }
    // Methods
    void ExportToXML(string FileName, object Options = Missing); // since 2026
    object GetValueFromExpression(string Expression, object UnitsSpecifier);
    void ImportFromXML(string FileName); // since 2026
    bool IsExpressionValid(string Expression, object UnitsSpecifier);
    void SetAllToMax();
    void SetAllToMedian();
    void SetAllToMin();
    void SetAllToNominal();
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).Parameters, [DrawingDocument](../objects/DrawingDocument.md).Parameters, [FlatPattern](../objects/FlatPattern.md).Parameters, [PartComponentDefinition](../objects/PartComponentDefinition.md).Parameters, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).Parameters, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).Parameters

**Referenced types:** [CustomParameterGroups](../objects/CustomParameterGroups.md), [DerivedParameterTables](../objects/DerivedParameterTables.md), [DimensionDisplayTypeEnum](../enums/DimensionDisplayTypeEnum.md), [FinishParameters](../objects/FinishParameters.md), [ModelParameters](../objects/ModelParameters.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [ParameterTables](../objects/ParameterTables.md), [ReferenceParameters](../objects/ReferenceParameters.md), [UserParameters](../objects/UserParameters.md)

