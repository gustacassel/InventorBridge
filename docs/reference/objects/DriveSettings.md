# DriveSettings

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.Constraints.Item[…].DriveSettings`

```csharp
interface DriveSettings
{
    // Properties
    object Application { get; }
    bool CollisionDetection { get; set; }
    bool DriveAdaptivity { get; set; }
    DriveTypeEnum DriveType { get; set; }
    string EndValue { get; set; }
    int FrameRate { get; set; }
    bool IsInitialized { get; }
    object Parent { get; }
    double PauseDelay { get; set; }
    int RepetitionCount { get; set; }
    bool RepetitionStartEndStart { get; set; }
    string StartValue { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetIncrement(out IncrementTypeEnum IncrementType, out string Increment);
    void GoToEnd();
    void GoToStart();
    void PlayForward();
    void PlayReverse();
    void SetIncrement(IncrementTypeEnum IncrementType, string Increment);
    void StartAVIRecording(string FullFileName, string Compressor = "", int CompressionQuality = 75, object MoreOptions = Missing);
    void StartWMVRecording(string FullFileName, int NetworkBandwidth = 250, int ImageWidth = 176, int ImageHeight = 144, bool AddMarkers = false, object MoreOptions = Missing);
    void StepForward();
    void StepReverse();
    void StopRecording();
    // Events
    event OnCollision();
}
```

**Returned by:** [AngleConstraint](../objects/AngleConstraint.md).DriveSettings, [AngleConstraintProxy](../objects/AngleConstraintProxy.md).DriveSettings, [AssemblyConstraint](../objects/AssemblyConstraint.md).DriveSettings, [AssemblyJoint](../objects/AssemblyJoint.md).DriveSettings, [AssemblyJointProxy](../objects/AssemblyJointProxy.md).DriveSettings, [AssemblySymmetryConstraint](../objects/AssemblySymmetryConstraint.md).DriveSettings, [AssemblySymmetryConstraintProxy](../objects/AssemblySymmetryConstraintProxy.md).DriveSettings, [FlushConstraint](../objects/FlushConstraint.md).DriveSettings, [FlushConstraintProxy](../objects/FlushConstraintProxy.md).DriveSettings, [InsertConstraint](../objects/InsertConstraint.md).DriveSettings, [InsertConstraintProxy](../objects/InsertConstraintProxy.md).DriveSettings, [MateConstraint](../objects/MateConstraint.md).DriveSettings, [MateConstraintProxy](../objects/MateConstraintProxy.md).DriveSettings, [RotateRotateConstraint](../objects/RotateRotateConstraint.md).DriveSettings, [RotateRotateConstraintProxy](../objects/RotateRotateConstraintProxy.md).DriveSettings, [RotateTranslateConstraint](../objects/RotateTranslateConstraint.md).DriveSettings, [RotateTranslateConstraintProxy](../objects/RotateTranslateConstraintProxy.md).DriveSettings, [TangentConstraint](../objects/TangentConstraint.md).DriveSettings, [TangentConstraintProxy](../objects/TangentConstraintProxy.md).DriveSettings, [TransitionalConstraint](../objects/TransitionalConstraint.md).DriveSettings, [TransitionalConstraintProxy](../objects/TransitionalConstraintProxy.md).DriveSettings, [TranslateTranslateConstraint](../objects/TranslateTranslateConstraint.md).DriveSettings, [TranslateTranslateConstraintProxy](../objects/TranslateTranslateConstraintProxy.md).DriveSettings

**Referenced types:** [DriveTypeEnum](../enums/DriveTypeEnum.md), [IncrementTypeEnum](../enums/IncrementTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

