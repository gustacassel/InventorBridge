# DSLoadDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.SimulationManager.DynamicSimulations.Item[…].DSLoads.Item[…].Definition`

```csharp
interface DSLoadDefinition
{
    // Properties
    object Application { get; }
    object DirectionEntity { get; set; }
    Color GlyphColor { get; set; }
    double GlyphScale { get; set; }
    bool IsAssociativeLoadDirection { get; set; }
    bool IsDefinedByVectorComponents { get; set; }
    bool IsDirectionEntityNaturalDirection { get; set; }
    bool IsDisplayed { get; set; }
    bool IsSuppressed { get; set; }
    Point Location { get; }
    object LocationEntity { get; set; }
    DSValue Magnitude { get; }
    DSLoad Parent { get; }
    ObjectTypeEnum Type { get; }
    Vector Vector { get; }
    DSValue VectorXComponent { get; }
    DSValue VectorYComponent { get; }
    DSValue VectorZComponent { get; }
    // Methods
    DSLoadDefinition Copy();
    void SetByMagnitudeAndDirection(object Magnitude, object DirectionEntity, bool NaturalEntityDirection);
    void SetByVector(object XComponent, object YComponent, object ZComponent);
}
```

**Returned by:** [DSLoad](../objects/DSLoad.md).Definition, [DSLoadDefinition](../objects/DSLoadDefinition.md).Copy

**Referenced types:** [Color](../objects/Color.md), [DSLoad](../objects/DSLoad.md), [DSValue](../objects/DSValue.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [Vector](../objects/Vector.md)

