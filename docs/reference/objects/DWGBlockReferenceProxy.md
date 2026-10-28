# DWGBlockReferenceProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface DWGBlockReferenceProxy
{
    // Properties
    object Application { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    DWGBlockDefinition Definition { get; }
    string HandleID { get; }
    DWGBlockReference NativeObject { get; }
    ImportedDWGComponent Parent { get; }
    DWGEntity ParentEntity { get; }
    Matrix Transformation { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    object GetObject(object ObjectInDefinition);
}
```

**Referenced types:** [ComponentOccurrence](../objects/ComponentOccurrence.md), [DWGBlockDefinition](../objects/DWGBlockDefinition.md), [DWGBlockReference](../objects/DWGBlockReference.md), [DWGEntity](../objects/DWGEntity.md), [ImportedDWGComponent](../objects/ImportedDWGComponent.md), [Matrix](../objects/Matrix.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

