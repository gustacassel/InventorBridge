# PointToPointRipTypeDef

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface PointToPointRipTypeDef
{
    // Properties
    PartFeatureExtentDirectionEnum GapSide { get; set; }
    Parameter GapSize { get; }
    RipDefinition Parent { get; }
    object PointOne { get; set; }
    object PointTwo { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md), [RipDefinition](../objects/RipDefinition.md)

