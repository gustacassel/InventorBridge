# ThemeManager

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ThemeManager`

```csharp
interface ThemeManager
{
    // Properties
    Theme ActiveTheme { get; }
    Application Application { get; }
    Application Parent { get; }
    ThemesEnumerator Themes { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    Color GetComponentThemeColor(string ComponentName);
}
```

**Returned by:** [Application](../objects/Application.md).ThemeManager

**Referenced types:** [Application](../objects/Application.md), [Color](../objects/Color.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Theme](../objects/Theme.md), [ThemesEnumerator](../objects/ThemesEnumerator.md)

