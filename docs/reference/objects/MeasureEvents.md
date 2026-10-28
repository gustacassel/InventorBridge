# MeasureEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CommandManager.CreateInteractionEvents(…).MeasureEvents`

```csharp
interface MeasureEvents
{
    // Properties
    Application Application { get; }
    bool Enabled { get; set; }
    InteractionEvents Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void ListParameters(object ScreenPosition = Missing, object Component = Missing, bool DisplayAllParameters = false, int HWND = 0);
    void Measure(MeasureTypeEnum MeasureType, object Options = Missing);
    void ShowDimensions();
    // Events
    event OnMeasure(MeasureTypeEnum MeasureType, double MeasuredValue, NameValueMap Context);
    event OnSelectParameter(Parameter Parameter, NameValueMap Context);
}
```

**Returned by:** [InteractionEvents](../objects/InteractionEvents.md).MeasureEvents

**Referenced types:** [Application](../objects/Application.md), [InteractionEvents](../objects/InteractionEvents.md), [MeasureTypeEnum](../enums/MeasureTypeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md)

