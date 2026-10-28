# FactoryOptions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.iPartFactory.FactoryOptions`

```csharp
interface FactoryOptions
{
    // Properties
    object Application { get; }
    bool IsPartNumberIndexed { get; set; }
    int MemberNameIndexDigits { get; set; }
    int MemberNameIndexInitialValue { get; set; }
    string MemberNameIndexSeparator { get; set; }
    int MemberNameIndexStepValue { get; set; }
    FactoryOptionsMemberNameTypeEnum MemberNameType { get; set; }
    string MemberNameValue { get; set; }
    int PartNumberIndexDigits { get; set; }
    int PartNumberIndexInitialValue { get; set; }
    string PartNumberIndexSeparator { get; set; }
    int PartNumberIndexStepValue { get; set; }
    FactoryOptionsPartNumberTypeEnum PartNumberType { get; set; }
    string PartNumberValue { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void ApplyToAllMembers();
}
```

**Returned by:** [iAssemblyFactory](../objects/iAssemblyFactory.md).FactoryOptions, [iPartFactory](../objects/iPartFactory.md).FactoryOptions

**Referenced types:** [FactoryOptionsMemberNameTypeEnum](../enums/FactoryOptionsMemberNameTypeEnum.md), [FactoryOptionsPartNumberTypeEnum](../enums/FactoryOptionsPartNumberTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

