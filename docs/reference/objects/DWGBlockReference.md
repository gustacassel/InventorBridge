# DWGBlockReference

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent).ModelSpaceDefinition.BlockReferences.Item[…]`

```csharp
interface DWGBlockReference
{
    // Properties
    object Application { get; }
    DWGBlockDefinition Definition { get; }
    string HandleID { get; }
    ImportedDWGComponent Parent { get; }
    DWGEntity ParentEntity { get; }
    Matrix Transformation { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    object GetObject(object ObjectInDefinition);
}
```

**Returned by:** [DWGBlockReferenceProxy](../objects/DWGBlockReferenceProxy.md).NativeObject, [DWGBlockReferencesEnumerator](../objects/DWGBlockReferencesEnumerator.md).Item

**Referenced types:** [DWGBlockDefinition](../objects/DWGBlockDefinition.md), [DWGEntity](../objects/DWGEntity.md), [ImportedDWGComponent](../objects/ImportedDWGComponent.md), [Matrix](../objects/Matrix.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

