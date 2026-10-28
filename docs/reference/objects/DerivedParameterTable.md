# DerivedParameterTable

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).Parameters.DerivedParameterTables.Item[…]`

```csharp
interface DerivedParameterTable
{
    // Properties
    AttributeSets AttributeSets { get; }
    DerivedParameters DerivedParameters { get; }
    bool HasReferenceComponent { get; }
    ObjectCollection LinkedParameters { get; set; }
    object Parent { get; }
    ReferenceComponent ReferenceComponent { get; }
    DocumentDescriptor ReferencedDocumentDescriptor { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [DerivedParameterTables](../objects/DerivedParameterTables.md).Add, [DerivedParameterTables](../objects/DerivedParameterTables.md).Add2, [DerivedParameterTables](../objects/DerivedParameterTables.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [DerivedParameters](../objects/DerivedParameters.md), [DocumentDescriptor](../objects/DocumentDescriptor.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferenceComponent](../objects/ReferenceComponent.md)

