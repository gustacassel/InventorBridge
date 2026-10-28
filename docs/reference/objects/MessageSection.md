# MessageSection

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ErrorManager.StartMessageSection(…)`

```csharp
interface MessageSection
{
    // Properties
    object Application { get; }
    bool HasErrors { get; }
    bool HasWarnings { get; }
    ErrorManager Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void AdoptMessages(string Message, bool Error, object Reserved = Missing);
    void ClearMessages();
    void End();
}
```

**Returned by:** [ErrorManager](../objects/ErrorManager.md).StartMessageSection

**Referenced types:** [ErrorManager](../objects/ErrorManager.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

