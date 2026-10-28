# DWGPolyline2D

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition.Polylines2D.Item[…]`

```csharp
interface DWGPolyline2D
{
    // Properties
    object Application { get; }
    string HandleID { get; }
    ImportedDWGComponent Parent { get; }
    DWGEntity ParentEntity { get; }
    DWGEntitySegmentsEnumerator Segments { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DWGPolyline2DProxy](../objects/DWGPolyline2DProxy.md).NativeObject, [DWGPolylines2DEnumerator](../objects/DWGPolylines2DEnumerator.md).Item

**Referenced types:** [DWGEntity](../objects/DWGEntity.md), [DWGEntitySegmentsEnumerator](../objects/DWGEntitySegmentsEnumerator.md), [ImportedDWGComponent](../objects/ImportedDWGComponent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

