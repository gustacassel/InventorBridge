# iFeatureOptions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.iFeatureOptions`

```csharp
interface iFeatureOptions
{
    // Properties
    object Application { get; }
    string RootPath { get; set; }
    string SheetMetalPunchesRootPath { get; set; }
    ObjectTypeEnum Type { get; }
    bool UseKey1AsBrowserNameColumn { get; set; }
    string UserRootPath { get; set; }
    string Viewer { get; set; }
    string ViewerArguments { get; set; }
}
```

**Returned by:** [Application](../objects/Application.md).iFeatureOptions, [InventorServer](../objects/InventorServer.md).iFeatureOptions

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

