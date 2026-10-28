# DerivedParameter

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Parameter](../objects/Parameter.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).Parameters.Item[…] → (DerivedParameter)`

```csharp
interface DerivedParameter
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
    Parameter ReferencedEntity { get; }
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

**Returned by:** [DerivedParameters](../objects/DerivedParameters.md).Item

**Referenced types:** [ActionTypeEnum](../enums/ActionTypeEnum.md), [AttributeSets](../objects/AttributeSets.md), [CustomPropertyFormat](../objects/CustomPropertyFormat.md), [ExpressionList](../objects/ExpressionList.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ModelValueTypeEnum](../enums/ModelValueTypeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [ParameterDisplayFormatEnum](../enums/ParameterDisplayFormatEnum.md), [ParameterTypeEnum](../enums/ParameterTypeEnum.md), [Tolerance](../objects/Tolerance.md)

