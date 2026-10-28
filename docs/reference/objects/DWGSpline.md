# DWGSpline

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition.Splines.Item[…]`

```csharp
interface DWGSpline
{
    // Properties
    object Application { get; }
    Point EndPoint { get; }
    string HandleID { get; }
    ImportedDWGComponent Parent { get; }
    DWGEntity ParentEntity { get; }
    Point StartPoint { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [DWGSplineProxy](../objects/DWGSplineProxy.md).NativeObject, [DWGSplinesEnumerator](../objects/DWGSplinesEnumerator.md).Item

**Referenced types:** [DWGEntity](../objects/DWGEntity.md), [ImportedDWGComponent](../objects/ImportedDWGComponent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

