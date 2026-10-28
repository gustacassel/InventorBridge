# Matrix2d

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateMatrix2d(…)`

```csharp
interface Matrix2d
{
    // Properties
    double Cell[int Row, int Col] { get; set; }
    double Determinant { get; }
    Vector2d Translation { get; }
    // Methods
    Matrix2d Copy();
    void GetCoordinateSystem(out Point2d Origin, out Vector2d XAxis, out Vector2d YAxis);
    void GetMatrixData(out double[] Cells);
    void Invert();
    bool IsEqualTo(Matrix2d Matrix2d, double Tolerance = 0);
    void PostMultiplyBy(Matrix2d Matrix2d);
    void PreMultiplyBy(Matrix2d Matrix2d);
    void PutMatrixData(out double[] Cells);
    void SetCoordinateSystem(Point2d Origin, Vector2d XAxis, Vector2d YAxis);
    void SetToAlignCoordinateSystems(Point2d FromOrigin, Vector2d FromXAxis, Vector2d FromYAxis, Point2d ToOrigin, Vector2d ToXAxis, Vector2d ToYAxis);
    void SetToIdentity();
    void SetToRotateTo(Vector2d From, Vector2d To);
    void SetToRotation(double Angle, Point2d Center);
    void SetTranslation(Vector2d Translation, bool ResetRotation = false);
    void TransformBy(Matrix2d Matrix2d);
}
```

**Returned by:** [AutoCADBlock](../objects/AutoCADBlock.md).Transformation, [Matrix2d](../objects/Matrix2d.md).Copy, [SketchBlock](../objects/SketchBlock.md).Transformation, [SketchBlockProxy](../objects/SketchBlockProxy.md).Transformation, [SketchedSymbol](../objects/SketchedSymbol.md).Transformation, [TitleBlock](../objects/TitleBlock.md).Transformation, [TransientGeometry](../objects/TransientGeometry.md).CreateMatrix2d

**Referenced types:** [Point2d](../objects/Point2d.md), [Vector2d](../objects/Vector2d.md)

