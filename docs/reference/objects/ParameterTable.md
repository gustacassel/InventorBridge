# ParameterTable

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).Parameters.ParameterTables.Item[…]`

```csharp
interface ParameterTable
{
    // Properties
    AttributeSets AttributeSets { get; }
    string FileName { get; set; }
    bool Linked { get; }
    object Parent { get; }
    ReferencedOLEFileDescriptor ReferencedFileDescriptor { get; }
    string StartCell { get; set; }
    TableParameters TableParameters { get; }
    ObjectTypeEnum Type { get; }
    object WorkSheet { get; }
    // Methods
    void Delete();
    void Export(string FileName, FileFormatEnum FileFormat, object Options = Missing);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [ParameterTables](../objects/ParameterTables.md).AddExcelTable, [ParameterTables](../objects/ParameterTables.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [FileFormatEnum](../enums/FileFormatEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferencedOLEFileDescriptor](../objects/ReferencedOLEFileDescriptor.md), [TableParameters](../objects/TableParameters.md)

