# Theme

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ThemeManager.Themes.Item[…]`

```csharp
interface Theme
{
    // Properties
    Application Application { get; }
    string Name { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Activate();
}
```

**Returned by:** [ThemeManager](../objects/ThemeManager.md).ActiveTheme, [ThemesEnumerator](../objects/ThemesEnumerator.md).Item

**Referenced types:** [Application](../objects/Application.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

