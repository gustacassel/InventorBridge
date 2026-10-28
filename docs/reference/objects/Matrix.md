# Matrix

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateMatrix(…)`

```csharp
interface Matrix
{
    // Properties
    double Cell[int Row, int Col] { get; set; }
    double Determinant { get; }
    Vector Translation { get; }
    // Methods
    Matrix Copy();
    void GetCoordinateSystem(out Point Origin, out Vector XAxis, out Vector YAxis, out Vector ZAxis);
    void GetMatrixData(out double[] Cells);
    void Invert();
    bool IsEqualTo(Matrix Matrix, double Tolerance = 0);
    void PostMultiplyBy(Matrix Matrix);
    void PreMultiplyBy(Matrix Matrix);
    void PutMatrixData(out double[] Cells);
    void SetCoordinateSystem(Point Origin, Vector XAxis, Vector YAxis, Vector ZAxis);
    void SetToAlignCoordinateSystems(Point FromOrigin, Vector FromXAxis, Vector FromYAxis, Vector FromZAxis, Point ToOrigin, Vector ToXAxis, Vector ToYAxis, Vector ToZAxis);
    void SetToIdentity();
    void SetToRotateTo(Vector From, Vector To, Vector Axis = Missing);
    void SetToRotation(double Angle, Vector Axis, Point Center);
    void SetTranslation(Vector Translation, bool ResetRotation = false);
    void TransformBy(Matrix Matrix);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md).Transformation, [Camera](../objects/Camera.md).ModelToViewTransformation, [ComponentOccurrence](../objects/ComponentOccurrence.md).Transformation, [ComponentOccurrenceProxy](../objects/ComponentOccurrenceProxy.md).Transformation, [DWGBlockReference](../objects/DWGBlockReference.md).Transformation, [DWGBlockReferenceProxy](../objects/DWGBlockReferenceProxy.md).Transformation, [DetailDrawingView](../objects/DetailDrawingView.md).DrawingViewToModelTransform, [DetailDrawingView](../objects/DetailDrawingView.md).DrawingViewToSheetTransform, [DetailDrawingView](../objects/DetailDrawingView.md).ModelToDrawingViewTransform, [DetailDrawingView](../objects/DetailDrawingView.md).ModelToSheetTransform, [DetailDrawingView](../objects/DetailDrawingView.md).SheetToDrawingViewTransform, [DetailDrawingView](../objects/DetailDrawingView.md).SheetToModelTransform, [DrawingView](../objects/DrawingView.md).DrawingViewToModelTransform, [DrawingView](../objects/DrawingView.md).DrawingViewToSheetTransform, [DrawingView](../objects/DrawingView.md).ModelToDrawingViewTransform, [DrawingView](../objects/DrawingView.md).ModelToSheetTransform, [DrawingView](../objects/DrawingView.md).SheetToDrawingViewTransform, [DrawingView](../objects/DrawingView.md).SheetToModelTransform, [FeaturePatternElement](../objects/FeaturePatternElement.md).Transform, [FeaturePatternElementProxy](../objects/FeaturePatternElementProxy.md).Transform, [FreeMoveDefinition](../objects/FreeMoveDefinition.md).Transformation, [GraphicsNode](../objects/GraphicsNode.md).Transformation, [GraphicsNodeProxy](../objects/GraphicsNodeProxy.md).Transformation, [ImportedDWGComponentDefinition](../objects/ImportedDWGComponentDefinition.md).Transformation, [ManipulatorEvents](../objects/ManipulatorEvents.md).Transform, [Matrix](../objects/Matrix.md).Copy, [MoveFeature](../objects/MoveFeature.md).Transformation, [MoveFeatureProxy](../objects/MoveFeatureProxy.md).Transformation, [PlanarSketch](../objects/PlanarSketch.md).ModelToSketchTransform, [PlanarSketch](../objects/PlanarSketch.md).SketchToModelTransform, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).ModelToSketchTransform, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).SketchToModelTransform, [PointCloud](../objects/PointCloud.md).Transform, [PointCloudProxy](../objects/PointCloudProxy.md).Transform, [PresentationComponent](../objects/PresentationComponent.md).Transformation, [SectionDrawingView](../objects/SectionDrawingView.md).DrawingViewToModelTransform, [SectionDrawingView](../objects/SectionDrawingView.md).DrawingViewToSheetTransform, [SectionDrawingView](../objects/SectionDrawingView.md).ModelToDrawingViewTransform, [SectionDrawingView](../objects/SectionDrawingView.md).ModelToSheetTransform, [SectionDrawingView](../objects/SectionDrawingView.md).SheetToDrawingViewTransform and 11 more (see `members.tsv`)

**Referenced types:** [Point](../objects/Point.md), [Vector](../objects/Vector.md)

