# AssemblyWorkAxisDef

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface AssemblyWorkAxisDef
{
    // Properties
    object Application { get; }
    UnitVector Axis { get; }
    AssemblyConstraintsEnumerator Constraints { get; }
    Point OriginPoint { get; }
    WorkAxis Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetData(out Point OriginPoint, out UnitVector Axis);
    void PutData(Point OriginPoint, UnitVector Axis);
}
```

**Referenced types:** [AssemblyConstraintsEnumerator](../objects/AssemblyConstraintsEnumerator.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [UnitVector](../objects/UnitVector.md), [WorkAxis](../objects/WorkAxis.md)

