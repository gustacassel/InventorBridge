# DWGLine

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition.Lines.Item[…]`

```csharp
interface DWGLine
{
    // Properties
    object Application { get; }
    UnitVector Direction { get; }
    Point EndPoint { get; }
    string HandleID { get; }
    ImportedDWGComponent Parent { get; }
    DWGEntity ParentEntity { get; }
    Point StartPoint { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [DWGLineProxy](../objects/DWGLineProxy.md).NativeObject, [DWGLinesEnumerator](../objects/DWGLinesEnumerator.md).Item

**Referenced types:** [DWGEntity](../objects/DWGEntity.md), [ImportedDWGComponent](../objects/ImportedDWGComponent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [UnitVector](../objects/UnitVector.md)

