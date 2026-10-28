# BOMQuantity

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.BOMQuantity`

```csharp
interface BOMQuantity
{
    // Properties
    object Application { get; }
    string BaseUnits { get; set; }
    ComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    string UnitQuantity { get; }
    // Methods
    void GetBaseQuantity(out BOMQuantityTypeEnum QuantityType, out object Quantity = Missing);
    double GetEvaluatedBaseQuantity(out BOMQuantityTypeEnum QuantityType);
    void SetBaseQuantity(BOMQuantityTypeEnum QuantityType, object Quantity = Missing);
}
```

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).BOMQuantity, [ComponentDefinition](../objects/ComponentDefinition.md).BOMQuantity, [FlatPattern](../objects/FlatPattern.md).BOMQuantity, [PartComponentDefinition](../objects/PartComponentDefinition.md).BOMQuantity, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).BOMQuantity, [VirtualComponentDefinition](../objects/VirtualComponentDefinition.md).BOMQuantity, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).BOMQuantity, [WeldsComponentDefinition](../objects/WeldsComponentDefinition.md).BOMQuantity

**Referenced types:** [BOMQuantityTypeEnum](../enums/BOMQuantityTypeEnum.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

