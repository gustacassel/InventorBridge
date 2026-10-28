# iFeatureParameterInput

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [iFeatureInput](../objects/iFeatureInput.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.iFeatures.Item[…].iFeatureDefinition.iFeatureInputs.Item[…] → (iFeatureParameterInput)`

```csharp
interface iFeatureParameterInput
{
    // Properties
    object Application { get; }
    string DefaultExpression { get; }
    iFeatureEntityInputTypeEnum EntityType { get; }
    string Expression { get; set; }
    bool IsPunchToolDepth { get; }
    int LimitListCount { get; }
    iFeatureParamLimitTypeEnum LimitType { get; }
    string Name { get; }
    Parameter Parameter { get; }
    string Prompt { get; }
    ObjectTypeEnum Type { get; }
    double Value { get; set; }
    // Methods
    string LimitListExpressions(int Index);
    void LimitRangeExpressions(out string LeftLimitValue, out string LeftRangeSpec, out string RightRangeSpec, out string RightLimitValue);
}
```

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [iFeatureEntityInputTypeEnum](../enums/iFeatureEntityInputTypeEnum.md), [iFeatureParamLimitTypeEnum](../enums/iFeatureParamLimitTypeEnum.md)

