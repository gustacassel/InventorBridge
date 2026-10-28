# DWGPolyline

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition.Polylines.Item[…]`

```csharp
interface DWGPolyline
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

**Returned by:** [DWGPolylineProxy](../objects/DWGPolylineProxy.md).NativeObject, [DWGPolylinesEnumerator](../objects/DWGPolylinesEnumerator.md).Item

**Referenced types:** [DWGEntity](../objects/DWGEntity.md), [DWGEntitySegmentsEnumerator](../objects/DWGEntitySegmentsEnumerator.md), [ImportedDWGComponent](../objects/ImportedDWGComponent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

