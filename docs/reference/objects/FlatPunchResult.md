# FlatPunchResult

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition → (SheetMetalComponentDefinition).FlatPattern.FlatPunchResults.Item[…]`

```csharp
interface FlatPunchResult
{
    // Properties
    double Angle { get; }
    object Application { get; }
    double Depth { get; }
    Faces Faces { get; }
    double FoldedAngle { get; }
    Point FoldedPosition { get; }
    bool HasDepth { get; }
    string InternalName { get; }
    bool IsDirectionUp { get; }
    bool IsPunchAfterStopNode { get; }
    bool IsPunchSuppressed { get; }
    FlatPattern Parent { get; }
    Point Position { get; }
    string PunchId { get; }
    Edges SketchRepresentationEdges { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [FlatPunchResults](../objects/FlatPunchResults.md).Item

**Referenced types:** [Edges](../objects/Edges.md), [Faces](../objects/Faces.md), [FlatPattern](../objects/FlatPattern.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

