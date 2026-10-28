# WeldBead

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition → (WeldmentComponentDefinition).Welds.WeldBeads.Item[…]`

```csharp
interface WeldBead
{
    // Properties
    object Application { get; }
    Faces BeadFaces { get; }
    double BeadLength { get; }
    Faces EndFaces { get; }
    Faces FaceSetOne { get; }
    Faces FaceSetTwo { get; }
    string Name { get; set; }
    Faces SideFaces { get; }
    Point SymbolAttachPoint { get; }
    Point SymbolBreakPoint { get; }
    ObjectTypeEnum Type { get; }
    string WeldInfo { get; }
    // Methods
    void Delete(bool RetainConsumedSketches = false, bool RetainDependentFeaturesAndSketches = false, bool RetainDependentWorkFeatures = false);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [WeldBeads](../objects/WeldBeads.md).Item

**Referenced types:** [Faces](../objects/Faces.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

