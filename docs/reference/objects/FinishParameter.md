# FinishParameter

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).Parameters.FinishParameters.Item[…]`

```csharp
interface FinishParameter
{
    // Properties
    AttributeSets AttributeSets { get; }
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
    Tolerance Tolerance { get; }
    ObjectTypeEnum Type { get; }
    string Units { get; set; }
    object Value { get; set; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FinishParameters](../objects/FinishParameters.md).Item

**Referenced types:** [ActionTypeEnum](../enums/ActionTypeEnum.md), [AttributeSets](../objects/AttributeSets.md), [CustomPropertyFormat](../objects/CustomPropertyFormat.md), [ExpressionList](../objects/ExpressionList.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ModelValueTypeEnum](../enums/ModelValueTypeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ParameterDisplayFormatEnum](../enums/ParameterDisplayFormatEnum.md), [ParameterTypeEnum](../enums/ParameterTypeEnum.md), [Tolerance](../objects/Tolerance.md)

