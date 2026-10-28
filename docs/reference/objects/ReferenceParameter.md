# ReferenceParameter

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Parameter](../objects/Parameter.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).Parameters.ReferenceParameters.Item[…]`

```csharp
interface ReferenceParameter
{
    // Properties
    AttributeSets AttributeSets { get; }
    bool BuiltIn { get; }
    string Comment { get; set; }
    CustomPropertyFormat CustomPropertyFormat { get; }
    ObjectCollection Dependents { get; }
    ActionTypeEnum DisabledActionTypes { get; set; }
    ParameterDisplayFormatEnum DisplayFormat { get; set; }
    ObjectCollection DrivenBy { get; }
    bool ExposedAsProperty { get; set; }
    string Expression { get; set; }
    ExpressionList ExpressionList { get; }
    HealthStatusEnum HealthStatus { get; }
    bool InUse { get; }
    bool IsKey { get; set; }
    double ModelValue { get; }
    ModelValueTypeEnum ModelValueType { get; set; }
    string Name { get; set; }
    ParameterTypeEnum ParameterType { get; }
    object Parent { get; }
    int Precision { get; set; }
    bool Renamed { get; }
    Tolerance Tolerance { get; }
    ObjectTypeEnum Type { get; }
    string Units { get; set; }
    object Value { get; set; }
    // Methods
    ModelParameter ConvertToModelParameter();
    UserParameter ConvertToUserParameter();
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelParameter](../objects/ModelParameter.md).ConvertToReferenceParameter, [ReferenceParameters](../objects/ReferenceParameters.md).AddByExpression, [ReferenceParameters](../objects/ReferenceParameters.md).AddByValue, [ReferenceParameters](../objects/ReferenceParameters.md).Item, [UserParameter](../objects/UserParameter.md).ConvertToReferenceParameter

**Referenced types:** [ActionTypeEnum](../enums/ActionTypeEnum.md), [AttributeSets](../objects/AttributeSets.md), [CustomPropertyFormat](../objects/CustomPropertyFormat.md), [ExpressionList](../objects/ExpressionList.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ModelParameter](../objects/ModelParameter.md), [ModelValueTypeEnum](../enums/ModelValueTypeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ParameterDisplayFormatEnum](../enums/ParameterDisplayFormatEnum.md), [ParameterTypeEnum](../enums/ParameterTypeEnum.md), [Tolerance](../objects/Tolerance.md), [UserParameter](../objects/UserParameter.md)

