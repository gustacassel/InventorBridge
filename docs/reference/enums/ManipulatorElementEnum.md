# ManipulatorElementEnum

Inventor API enum · versions: 2024+ · [index](../index.md)

```csharp
enum ManipulatorElementEnum
{
    kAllManipulatorElements = 0,
    kManipulatorOriginTranslationElement = 1,
    kManipulatorXTranslationElement = 2,
    kManipulatorYTranslationElement = 4,
    kManipulatorZTranslationElement = 8,
    kManipulatorXYTranslationElement = 16,
    kManipulatorXZTranslationElement = 32,
    kManipulatorYZTranslationElement = 64,
    kManipulatorXRotationElement = 128,
    kManipulatorYRotationElement = 256,
    kManipulatorZRotationElement = 512,
    kManipulatorOriginScaleElement = 1024,
    kManipulatorXScaleElement = 2048,
    kManipulatorYScaleElement = 4096,
    kManipulatorZScaleElement = 8192,
    kManipulatorXYScaleElement = 16384,
    kManipulatorXZScaleElement = 32768,
    kManipulatorYZScaleElement = 65536,
}
```

**Used by:** [ManipulatorEvents](../objects/ManipulatorEvents.md).ApplyDrag, [ManipulatorEvents](../objects/ManipulatorEvents.md).OnDrag, [ManipulatorEvents](../objects/ManipulatorEvents.md).OnEndDrag, [ManipulatorEvents](../objects/ManipulatorEvents.md).OnManipulatorElementSelectionChange, [ManipulatorEvents](../objects/ManipulatorEvents.md).OnStartDrag, [ManipulatorEvents](../objects/ManipulatorEvents.md).SelectedElement, [ManipulatorEvents](../objects/ManipulatorEvents.md).SetAppearance

