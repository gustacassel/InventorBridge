# ReferencedOpaqueFileDescriptor

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.ReferencedOpaqueFileDescriptors.Item[…]`

```csharp
interface ReferencedOpaqueFileDescriptor
{
    // Properties
    object Application { get; }
    string FullFileName { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

**Returned by:** [ReferencedOpaqueFileDescriptors](../objects/ReferencedOpaqueFileDescriptors.md).Add, [ReferencedOpaqueFileDescriptors](../objects/ReferencedOpaqueFileDescriptors.md).Item, [ReferencedOpaqueFileDescriptors](../objects/ReferencedOpaqueFileDescriptors.md).ItemByName

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

