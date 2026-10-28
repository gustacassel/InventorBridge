# ImportedRVTComponentDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ImportedRVTComponentDefinition
{
    // Properties
    object Application { get; }
    string FullFileName { get; }
    string Imported3DView { get; set; }
    ImportedAssemblyOrganizationTypeEnum ImportedAssemblyOrganizationType { get; set; }
    ImportedRevitLanguageTypeEnum ImportedLanguage { get; set; }
    ImportedComponent Parent { get; }
    bool ReferenceModel { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Referenced types:** [ImportedAssemblyOrganizationTypeEnum](../enums/ImportedAssemblyOrganizationTypeEnum.md), [ImportedComponent](../objects/ImportedComponent.md), [ImportedRevitLanguageTypeEnum](../enums/ImportedRevitLanguageTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

