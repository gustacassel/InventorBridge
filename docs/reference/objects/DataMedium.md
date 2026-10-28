# DataMedium

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientObjects.CreateDataMedium(…)`

```csharp
interface DataMedium
{
    // Properties
    string FileName { get; set; }
    object IDataObject { get; set; }
    MediumTypeEnum MediumType { get; set; }
    object Stream { get; set; }
    string String { get; set; }
}
```

**Returned by:** [TransientObjects](../objects/TransientObjects.md).CreateDataMedium

**Referenced types:** [MediumTypeEnum](../enums/MediumTypeEnum.md)

