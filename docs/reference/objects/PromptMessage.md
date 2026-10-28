# PromptMessage

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**How to get it:** `Application.PromptsOptions.PromptMessages.Item[…]`

```csharp
interface PromptMessage
{
    // Properties
    object Application { get; } // since 2025
    bool BuiltIn { get; } // since 2025
    int Buttons { get; } // since 2025
    int DefaultAnswer { get; set; } // since 2025
    string DisplayedPromptText { get; } // since 2025
    int Icon { get; } // since 2025
    string Id { get; } // since 2025
    string PromptText { get; } // since 2025
    PromptMessageRestrictionsEnum Restrictions { get; set; } // since 2025
    string Title { get; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
    // Methods
    void Delete(); // since 2025
    int Display(object PromptStrings = Missing); // since 2025
}
```

**Returned by:** [PromptMessages](../objects/PromptMessages.md).Add, [PromptMessages](../objects/PromptMessages.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PromptMessageRestrictionsEnum](../enums/PromptMessageRestrictionsEnum.md)

