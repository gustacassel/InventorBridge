# DriveConstraintSettings

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface DriveConstraintSettings
{
    // Properties
    object Application { get; }
    bool CollisionDetection { get; set; }
    bool DriveAdaptivity { get; set; }
    string EndValue { get; set; }
    int FrameRate { get; set; }
    bool IsInitialized { get; }
    AssemblyConstraint Parent { get; }
    double PauseDelay { get; set; }
    int RepetitionCount { get; set; }
    bool RepetitionStartEndStart { get; set; }
    string StartValue { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetIncrement(out ConstraintIncrementTypeEnum IncrementType, out string Increment);
    void GoToEnd();
    void GoToStart();
    void PlayForward();
    void PlayReverse();
    void SetIncrement(ConstraintIncrementTypeEnum IncrementType, string Increment);
    void StartAVIRecording(string FullFileName, string Compressor = "", int CompressionQuality = 75, object MoreOptions = Missing);
    void StartWMVRecording(string FullFileName, int NetworkBandwidth = 250, int ImageWidth = 176, int ImageHeight = 144, bool AddMarkers = false, object MoreOptions = Missing);
    void StepForward();
    void StepReverse();
    void StopRecording();
    // Events
    event OnCollision();
}
```

**Referenced types:** [AssemblyConstraint](../objects/AssemblyConstraint.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

