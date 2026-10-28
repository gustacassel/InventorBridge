# Camera

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.Views.Item[…].Camera`

```csharp
interface Camera
{
    // Properties
    bool Animating { set; }
    bool DumpingNodeCount { set; }
    Point Eye { get; set; }
    Matrix ModelToViewTransformation { get; }
    object Parent { get; }
    bool Perspective { get; set; }
    double PerspectiveAngle { get; set; }
    object SceneObject { get; set; }
    Point Target { get; set; }
    ObjectTypeEnum Type { get; }
    UnitVector UpVector { get; set; }
    ViewOrientationTypeEnum ViewOrientationType { get; set; }
    // Methods
    void Apply();
    void ApplyWithoutTransition();
    void ComputeWithMouseInput(Point2d FromPoint, Point2d ToPoint, int WheelDelta, ViewOperationTypeEnum ViewOperation);
    IPictureDisp CreateImage(int Width, int Height, object topColor = Missing, object bottomColor = Missing);
    IPictureDisp CreateImageWithOptions(int Width, int Height, NameValueMap Options);
    void Fit();
    void GetExtents(out double Width, out double Height);
    Point2d ModelToViewSpace(Point ModelCoordinate);
    void SaveAsBitmap(string FullFileName, int Width, int Height, object topColor = Missing, object bottomColor = Missing);
    void SaveAsBitmapWithOptions(string FullFileName, int Width, int Height, NameValueMap Options); // since 2026
    void SetExtents(double Width, double Height);
    Point ViewToModelSpace(Point2d ViewCoordinate);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ClientView](../objects/ClientView.md).Camera, [DesignViewRepresentation](../objects/DesignViewRepresentation.md).Camera, [DetailDrawingView](../objects/DetailDrawingView.md).Camera, [DrawingView](../objects/DrawingView.md).Camera, [PresentationSnapshotView](../objects/PresentationSnapshotView.md).SavedCamera, [SectionDrawingView](../objects/SectionDrawingView.md).Camera, [TransientObjects](../objects/TransientObjects.md).CreateCamera, [View](../objects/View.md).Camera

**Referenced types:** [IPictureDisp](../objects/IPictureDisp.md), [Matrix](../objects/Matrix.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [Point2d](../objects/Point2d.md), [UnitVector](../objects/UnitVector.md), [ViewOperationTypeEnum](../enums/ViewOperationTypeEnum.md), [ViewOrientationTypeEnum](../enums/ViewOrientationTypeEnum.md)

