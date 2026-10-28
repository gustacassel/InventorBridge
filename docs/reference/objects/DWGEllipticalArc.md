# DWGEllipticalArc

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition.EllipticalArcs.Item[…]`

```csharp
interface DWGEllipticalArc
{
    // Properties
    object Application { get; }
    Point Center { get; }
    string HandleID { get; }
    UnitVector Normal { get; }
    ImportedDWGComponent Parent { get; }
    DWGEntity ParentEntity { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [DWGEllipticalArcProxy](../objects/DWGEllipticalArcProxy.md).NativeObject, [DWGEllipticalArcsEnumerator](../objects/DWGEllipticalArcsEnumerator.md).Item

**Referenced types:** [DWGEntity](../objects/DWGEntity.md), [ImportedDWGComponent](../objects/ImportedDWGComponent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [UnitVector](../objects/UnitVector.md)

