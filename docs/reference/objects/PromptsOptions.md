# PromptsOptions

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**How to get it:** `Application.PromptsOptions`

```csharp
interface PromptsOptions
{
    // Properties
    object Application { get; } // since 2025
    bool DoNotShowMessagesForPreexistingProblems { get; set; } // since 2025
    PromptMessages PromptMessages { get; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
}
```

**Returned by:** [Application](../objects/Application.md).PromptsOptions

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PromptMessages](../objects/PromptMessages.md)

