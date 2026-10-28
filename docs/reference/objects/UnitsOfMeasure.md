# UnitsOfMeasure

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.UnitsOfMeasure`

```csharp
interface UnitsOfMeasure
{
    // Properties
    int AngleDisplayPrecision { get; set; }
    UnitsTypeEnum AngleUnits { get; set; }
    int LengthDisplayPrecision { get; set; }
    UnitsTypeEnum LengthUnits { get; set; }
    UnitsTypeEnum MassUnits { get; set; }
    object Parent { get; }
    UnitsTypeEnum TimeUnits { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    bool CompatibleUnits(string Expression1, object UnitsSpecifier1, string Expression2, object UnitsSpecifier2);
    double ConvertUnits(double Value, object InputUnitsSpecifier, object OutputUnitsSpecifier);
    string GetDatabaseUnitsFromExpression(string Expression, object UnitsSpecifier);
    ParametersEnumerator GetDrivingParameters(string Expression);
    string GetLocaleCorrectedExpression(string Expression, object UnitsSpecifier);
    string GetPreciseStringFromValue(double Value, object UnitsSpecifier);
    string GetStringFromType(UnitsTypeEnum UnitsType);
    string GetStringFromValue(double Value, object UnitsSpecifier);
    UnitsTypeEnum GetTypeFromString(string UnitsString);
    object GetValueFromExpression(string Expression, object UnitsSpecifier);
    bool IsExpressionValid(string Expression, object UnitsSpecifier);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).UnitsOfMeasure, [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md).UnitsOfMeasure, [ApprenticeServerDrawingDocument](../objects/ApprenticeServerDrawingDocument.md).UnitsOfMeasure, [AssemblyDocument](../objects/AssemblyDocument.md).UnitsOfMeasure, [Document](../objects/Document.md).UnitsOfMeasure, [DrawingDocument](../objects/DrawingDocument.md).UnitsOfMeasure, [InventorServer](../objects/InventorServer.md).UnitsOfMeasure, [PartDocument](../objects/PartDocument.md).UnitsOfMeasure, [PresentationDocument](../objects/PresentationDocument.md).UnitsOfMeasure

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ParametersEnumerator](../objects/ParametersEnumerator.md), [UnitsTypeEnum](../enums/UnitsTypeEnum.md)

