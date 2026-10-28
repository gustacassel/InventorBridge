# ContentFamily

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ContentCenter.TreeViewTopNode.Families.Item[…]`

```csharp
interface ContentFamily
{
    // Properties
    ContentTableCell ActiveCell { get; }
    object Application { get; }
    string ContentIdentifier { get; }
    string Description { get; set; }
    ContentTableColumn DesignationColumn { get; }
    string DisplayName { get; set; }
    ContentFamilyTypeEnum FamilyType { get; }
    ContentTableColumn FileNameColumn { get; }
    string InternalName { get; }
    bool IsCustom { get; }
    bool IsModifiable { get; }
    string LibraryInternalName { get; }
    string LibraryName { get; }
    string Manufacturer { get; set; }
    string MemberDirectory { get; set; }
    string RevisionId { get; }
    string Standard { get; set; }
    string StandardOrganization { get; set; }
    string StandardRevision { get; set; }
    ContentTableColumns TableColumns { get; }
    ContentTableRows TableRows { get; }
    IPictureDisp Thumbnail { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    string CreateMember(object Row, out MemberManagerErrorsEnum FailureReason, out string FailureMessage, ContentMemberRefreshEnum Refresh = ContentMemberRefreshEnum.kUseDefaultRefreshSetting, bool Custom = false, string FileName = "", object CustomInput = Missing, object Options = Missing);
    void GetCustomData(string ClientId, string InternalName, out byte[] CustomData);
    bool HasCustomData(string ClientId, string InternalName);
    void Save();
}
```

8 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ContentFamiliesEnumerator](../objects/ContentFamiliesEnumerator.md).Item, [ContentTableCell](../objects/ContentTableCell.md).Parent, [ContentTableColumn](../objects/ContentTableColumn.md).Parent, [ContentTableRow](../objects/ContentTableRow.md).Parent

**Referenced types:** [ContentFamilyTypeEnum](../enums/ContentFamilyTypeEnum.md), [ContentMemberRefreshEnum](../enums/ContentMemberRefreshEnum.md), [ContentTableCell](../objects/ContentTableCell.md), [ContentTableColumn](../objects/ContentTableColumn.md), [ContentTableColumns](../objects/ContentTableColumns.md), [ContentTableRows](../objects/ContentTableRows.md), [IPictureDisp](../objects/IPictureDisp.md), [MemberManagerErrorsEnum](../enums/MemberManagerErrorsEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

