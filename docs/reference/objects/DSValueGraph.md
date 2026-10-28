# DSValueGraph

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.SimulationManager.DynamicSimulations.Item[…].DSLoads.Item[…].Definition.Magnitude.Graph`

```csharp
interface DSValueGraph
{
    // Properties
    object Application { get; }
    int PointCount { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetSegmentInterpolationType(int SegmentIndex, out DSGraphInterpolationTypeEnum InterpolationType, out NameValueMap AdditionalInfo);
    void GetValueArray(out double[] TimeValueArray);
    void SetSegmentInterpolationType(int SegmentIndex, DSGraphInterpolationTypeEnum InterpolationType, NameValueMap AdditionalInfo);
    void SetValueUsingArray(ref double[] TimeValueArray, DSGraphInterpolationTypeEnum InterpolationType = DSGraphInterpolationTypeEnum.kLinearRampInterpolationType);
}
```

**Returned by:** [DSValue](../objects/DSValue.md).Graph

**Referenced types:** [DSGraphInterpolationTypeEnum](../enums/DSGraphInterpolationTypeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

