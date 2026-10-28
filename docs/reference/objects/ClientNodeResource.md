# ClientNodeResource

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.BrowserPanes.ClientNodeResources.Item[…]`

```csharp
interface ClientNodeResource
{
    // Properties
    object Application { get; }
    string ClientId { get; }
    string DisabledIconName { get; set; }
    string ExpandedDisabledIconName { get; set; }
    string ExpandedInvisibleIconName { get; set; }
    string ExpandedSuppressedIconName { get; set; }
    string GroundedDisabledIconName { get; set; }
    string GroundedIconName { get; set; }
    string GroundedInvisibleIconName { get; set; }
    string GroundedSuppressedIconName { get; set; }
    string IconName { get; set; }
    int Id { get; }
    string InvisibleIconName { get; set; }
    Document Parent { get; }
    string SuppressedIconName { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

11 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ClientBrowserNodeDefinition](../objects/ClientBrowserNodeDefinition.md).ExpandedIcon, [ClientBrowserNodeDefinition](../objects/ClientBrowserNodeDefinition.md).Icon, [ClientNodeResources](../objects/ClientNodeResources.md).AddNodeResource, [ClientNodeResources](../objects/ClientNodeResources.md).Item, [ClientNodeResources](../objects/ClientNodeResources.md).ItemById, [NativeBrowserNodeDefinition](../objects/NativeBrowserNodeDefinition.md).OverrideExpandedIcon, [NativeBrowserNodeDefinition](../objects/NativeBrowserNodeDefinition.md).OverrideIcon, [NativeBrowserNodeDefinition](../objects/NativeBrowserNodeDefinition.md).OverrideStateIcon

**Referenced types:** [Document](../objects/Document.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

