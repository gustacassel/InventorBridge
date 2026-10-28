# InventorVBAProject

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.VBAProjects.Item[…]`

```csharp
interface InventorVBAProject
{
    // Properties
    InventorVBAComponents InventorVBAComponents { get; }
    string Name { get; set; }
    Application Parent { get; }
    VBAProjectTypeEnum ProjectType { get; }
    bool Saved { get; }
    ObjectTypeEnum Type { get; }
    object VBProject { get; }
    // Methods
    void Close();
    void Save();
    void SaveAs(string FullFileName);
}
```

**Returned by:** [AssemblyDocument](../objects/AssemblyDocument.md).VBAProject, [Document](../objects/Document.md).VBAProject, [DrawingDocument](../objects/DrawingDocument.md).VBAProject, [InventorVBAComponent](../objects/InventorVBAComponent.md).Parent, [InventorVBAComponents](../objects/InventorVBAComponents.md).Parent, [InventorVBAProjects](../objects/InventorVBAProjects.md).Add, [InventorVBAProjects](../objects/InventorVBAProjects.md).Item, [PartDocument](../objects/PartDocument.md).VBAProject, [PresentationDocument](../objects/PresentationDocument.md).VBAProject

**Referenced types:** [Application](../objects/Application.md), [InventorVBAComponents](../objects/InventorVBAComponents.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [VBAProjectTypeEnum](../enums/VBAProjectTypeEnum.md)

