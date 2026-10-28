# PromptMessageRestrictionsEnum

Inventor API enum · versions: 2024+ · [index](../index.md)

```csharp
enum PromptMessageRestrictionsEnum
{
    kNoRestrictions = 0,
    kDontAllowNeverAgain = 1,
    kDontAllowNoMoreThisSession = 2,
    kDontAllowOncePerOperation = 4, // since 2025
    kDontAllowButton1NeverAgain = 8,
    kDontAllowButton1NoMoreThisSession = 16,
    kDontAllowButton1OncePerOperation = 32, // since 2025
    kDontAllowButton2NeverAgain = 64,
    kDontAllowButton2NoMoreThisSession = 128,
    kDontAllowButton2OncePerOperation = 256, // since 2025
    kDontAllowButton3NeverAgain = 512,
    kDontAllowButton3NoMoreThisSession = 1024,
    kDontAllowButton3OncePerOperation = 2048, // since 2025
}
```

**Used by:** [PromptMessage](../objects/PromptMessage.md).Restrictions

