# ErrorManager

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ErrorManager`

```csharp
interface ErrorManager
{
    // Properties
    string AllMessages { get; }
    object Application { get; }
    bool HasErrors { get; }
    bool HasWarnings { get; }
    bool IsMessageSectionActive { get; }
    string LastMessage { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void AddMessage(string Message, bool Error, object Reserved = Missing);
    void Clear();
    ButtonTypeEnum Show(string Title, bool AllowAccept, bool AllowEdit);
    MessageSection StartMessageSection();
}
```

**Returned by:** [Application](../objects/Application.md).ErrorManager, [InventorServer](../objects/InventorServer.md).ErrorManager, [MessageSection](../objects/MessageSection.md).Parent

**Referenced types:** [ButtonTypeEnum](../enums/ButtonTypeEnum.md), [MessageSection](../objects/MessageSection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

