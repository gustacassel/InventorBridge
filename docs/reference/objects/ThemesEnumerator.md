# ThemesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ThemeManager.Themes`

```csharp
interface ThemesEnumerator
{
    // Properties
    Application Application { get; }
    int Count { get; }
    Theme Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ThemeManager](../objects/ThemeManager.md).Themes

**Referenced types:** [Application](../objects/Application.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Theme](../objects/Theme.md)

