# View

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.Views.Item[…]`

```csharp
interface View
{
    // Properties
    object Application { get; }
    bool AreTexturesOn { get; set; }
    Camera Camera { get; }
    string Caption { get; set; }
    DisplayModeEnum DisplayMode { get; set; }
    DisplaySeparateColorsTypeEnum DisplaySeparateColorsType { get; set; } // since 2025
    Document Document { get; }
    int HWND { get; }
    int Height { get; set; }
    bool IsRayTracingPaused { get; set; }
    int Left { get; set; }
    bool NoiseReductionEnabled { get; set; }
    Document Parent { get; }
    bool RayTracing { get; set; }
    double RayTracingProgress { get; }
    RayTracingQualityEnum RayTracingQuality { get; set; }
    bool ShowAmbientShadows { get; set; }
    bool ShowGroundPlane { get; set; }
    bool ShowGroundReflections { get; set; }
    bool ShowGroundShadows { get; set; }
    bool ShowObjectShadows { get; set; }
    int Top { get; set; }
    ObjectTypeEnum Type { get; }
    ViewFrame ViewFrame { get; }
    ViewTab ViewTab { get; }
    bool Visible { get; set; }
    int Width { get; set; }
    WindowsSizeEnum WindowState { get; set; }
    // Methods
    void Activate();
    void Close();
    void Fit(bool DoUpdate = true);
    void GetWindowExtents(out int Top, out int Left, out int Height, out int Width);
    void GoHome();
    void Move(ref int Top, ref int Left, ref int Height, ref int Width);
    void ResetFront();
    void SaveAsBitmap(string FullFileName, int Width, int Height);
    void SaveAsBitmapWithOptions(string FullFileName, int Width, int Height, NameValueMap Options);
    void SaveAsBitmapWithRayTracing(string FullFileName);
    void SetCurrentAsFront();
    void SetCurrentAsHome(bool FitToView = true);
    void SetCurrentAsTop();
    void StartRenderingRateRecord();
    void StopRenderingRateRecord(out int frames, out double ElapsedTime);
    void Update();
}
```

7 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).ActiveView, [ViewList](../objects/ViewList.md).Item, [Views](../objects/Views.md).Add, [Views](../objects/Views.md).Item, [ViewsEnumerator](../objects/ViewsEnumerator.md).Item

**Referenced types:** [Camera](../objects/Camera.md), [DisplayModeEnum](../enums/DisplayModeEnum.md), [DisplaySeparateColorsTypeEnum](../enums/DisplaySeparateColorsTypeEnum.md), [Document](../objects/Document.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RayTracingQualityEnum](../enums/RayTracingQualityEnum.md), [ViewFrame](../objects/ViewFrame.md), [ViewTab](../objects/ViewTab.md), [WindowsSizeEnum](../enums/WindowsSizeEnum.md)

