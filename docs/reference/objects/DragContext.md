# DragContext

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CommandManager.CreateDragContext(…)`

```csharp
interface DragContext
{
    // Methods
    void CancelDrag();
    void Drag(Point ModelPosition);
    void EndDrag();
    void StartDrag(Point ModelPosition);
    bool TryMove(Matrix NewPosition);
}
```

**Returned by:** [CommandManager](../objects/CommandManager.md).CreateDragContext

**Referenced types:** [Matrix](../objects/Matrix.md), [Point](../objects/Point.md)

