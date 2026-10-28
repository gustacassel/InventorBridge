# ImportedGenericComponentDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ImportedGenericComponentDefinition
{
    // Properties
    object Application { get; }
    string FullFileName { get; }
    IFCImportMethodEnum IFCImportMethod { get; set; } // since 2025
    bool ImportIFCGeometryAsMesh { get; set; } // since 2025
    bool ImportIFCPropertiesAsCustomProperties { get; set; } // since 2025
    bool ImportIFCPropertiesAsParameters { get; set; } // since 2025
    ImportUnitsTypeEnum ImportUnitsType { get; set; }
    ImportedAssemblyOrganizationTypeEnum ImportedAssemblyOrganizationType { get; set; }
    ImportedModelEntities ImportedModelEntities { get; }
    ImportedModelGeometryTypeEnum ImportedModelGeometryTypes { get; set; }
    ImportedSurfaceOrganizationTypeEnum ImportedSurfaceOrganizationType { get; set; }
    ImportedWorkGeometryTypeEnum ImportedWorkGeometryTypes { get; set; }
    ImportedComponent Parent { get; }
    bool ReferenceModel { get; set; }
    string SaveFileNamesPrefixOrSuffix { get; set; }
    bool SaveFileNamesWithPrefix { get; set; }
    string SaveFilesLocation { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    ImportedGenericComponentDefinition Copy();
    void ExcludeAll();
    void IncludeAll();
}
```

**Returned by:** [ImportedGenericComponentDefinition](../objects/ImportedGenericComponentDefinition.md).Copy

**Referenced types:** [IFCImportMethodEnum](../enums/IFCImportMethodEnum.md), [ImportUnitsTypeEnum](../enums/ImportUnitsTypeEnum.md), [ImportedAssemblyOrganizationTypeEnum](../enums/ImportedAssemblyOrganizationTypeEnum.md), [ImportedComponent](../objects/ImportedComponent.md), [ImportedModelEntities](../objects/ImportedModelEntities.md), [ImportedModelGeometryTypeEnum](../enums/ImportedModelGeometryTypeEnum.md), [ImportedSurfaceOrganizationTypeEnum](../enums/ImportedSurfaceOrganizationTypeEnum.md), [ImportedWorkGeometryTypeEnum](../enums/ImportedWorkGeometryTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

