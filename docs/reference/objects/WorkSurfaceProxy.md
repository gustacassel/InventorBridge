# WorkSurfaceProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [WorkSurface](../objects/WorkSurface.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.WorkSurfaces.Item[…] → (WorkSurfaceProxy)`

```csharp
interface WorkSurfaceProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool Exported { get; set; }
    WorkSurface NativeObject { get; }
    ComponentDefinition Parent { get; }
    SurfaceBodies SurfaceBodies { get; }
    bool Translucent { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

5 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SurfaceBodies](../objects/SurfaceBodies.md), [WorkSurface](../objects/WorkSurface.md)

