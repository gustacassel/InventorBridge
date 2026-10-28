# PromptMessages

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**How to get it:** `Application.PromptsOptions.PromptMessages`

```csharp
interface PromptMessages
{
    // Properties
    object Application { get; } // since 2025
    int Count { get; } // since 2025
    PromptMessage Item[object Index] { get; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
    // Methods
    PromptMessage Add(string Id, string PromptText, int Buttons, int Icon, object Title = Missing, object DisplayedPromptText = Missing, object DefaultAnswer = Missing, object Restrictions = Missing, ref object PromptSettings = Missing); // since 2025
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PromptsOptions](../objects/PromptsOptions.md).PromptMessages

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PromptMessage](../objects/PromptMessage.md)

