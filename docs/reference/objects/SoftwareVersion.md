# SoftwareVersion

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.SoftwareVersion`

```csharp
interface SoftwareVersion
{
    // Properties
    int BetaVersion { get; }
    int BuildIdentifier { get; }
    string DisplayName { get; }
    string DisplayVersion { get; }
    bool Is64BitVersion { get; }
    bool IsEducationVersion { get; }
    int Major { get; }
    int Minor { get; }
    bool NotProduction { get; }
    ProductEditionEnum ProductEdition { get; }
    string ProductName { get; }
    int ServicePack { get; }
    ObjectTypeEnum Type { get; }
}
```

4 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).SoftwareVersion, [ApprenticeServer](../objects/ApprenticeServer.md).SoftwareVersion, [ApprenticeServerComponent](../objects/ApprenticeServerComponent.md).SoftwareVersion, [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md).SoftwareVersionCreated, [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md).SoftwareVersionSaved, [ApprenticeServerDrawingDocument](../objects/ApprenticeServerDrawingDocument.md).SoftwareVersionCreated, [ApprenticeServerDrawingDocument](../objects/ApprenticeServerDrawingDocument.md).SoftwareVersionSaved, [AssemblyDocument](../objects/AssemblyDocument.md).SoftwareVersionCreated, [AssemblyDocument](../objects/AssemblyDocument.md).SoftwareVersionSaved, [Document](../objects/Document.md).SoftwareVersionCreated, [Document](../objects/Document.md).SoftwareVersionSaved, [DrawingDocument](../objects/DrawingDocument.md).SoftwareVersionCreated, [DrawingDocument](../objects/DrawingDocument.md).SoftwareVersionSaved, [File](../objects/File.md).SoftwareVersionCreated, [File](../objects/File.md).SoftwareVersionSaved, [FileManager](../objects/FileManager.md).SoftwareVersionSaved, [InventorServer](../objects/InventorServer.md).SoftwareVersion, [PartDocument](../objects/PartDocument.md).SoftwareVersionCreated, [PartDocument](../objects/PartDocument.md).SoftwareVersionSaved, [PresentationDocument](../objects/PresentationDocument.md).SoftwareVersionCreated, [PresentationDocument](../objects/PresentationDocument.md).SoftwareVersionSaved

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ProductEditionEnum](../enums/ProductEditionEnum.md)

