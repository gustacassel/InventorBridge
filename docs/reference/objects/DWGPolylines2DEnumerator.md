# DWGPolylines2DEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition.Polylines2D`

```csharp
interface DWGPolylines2DEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    DWGPolyline2D Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DWGBlockDefinition](../objects/DWGBlockDefinition.md).Polylines2D, [DWGBlockDefinitionProxy](../objects/DWGBlockDefinitionProxy.md).Polylines2D

**Referenced types:** [DWGPolyline2D](../objects/DWGPolyline2D.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

