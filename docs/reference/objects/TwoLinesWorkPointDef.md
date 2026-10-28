# TwoLinesWorkPointDef

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface TwoLinesWorkPointDef
{
    // Properties
    object Application { get; }
    object Line1 { get; }
    object Line2 { get; }
    WorkPoint Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetData(out object Line1, out object Line2);
}
```

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [WorkPoint](../objects/WorkPoint.md)

