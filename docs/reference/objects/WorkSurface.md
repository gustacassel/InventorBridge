# WorkSurface

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.WorkSurfaces.Item[…]`

```csharp
interface WorkSurface
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Exported { get; set; }
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

**Returned by:** [WorkSurfaceProxy](../objects/WorkSurfaceProxy.md).NativeObject, [WorkSurfaces](../objects/WorkSurfaces.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SurfaceBodies](../objects/SurfaceBodies.md)

