# IRxBSplineCurve2d

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface IRxBSplineCurve2d
{
    // Properties
    IRxCurve2dEvaluator Evaluator { get; }
    IRxPoint2d PoleAtIndex[uint nIndex] { get; set; }
    // Methods
    void GetBSplineData(uint nPoles, uint nKnots, uint nWeights, out double pPoles, out double pKnots, out double pWeights);
    void GetBSplineInfo(out uint pnOrder, out uint pnNumPoles, out uint pnNumKnots, out SByte pIsRational, out SByte pIsPeriodic, out SByte pIsClosed);
    void PutBSplineInfoAndData(uint nOrder, uint nPoles, uint nKnots, uint nWeights, SByte bIsPeriodic, ref double pPoles, ref double pKnots, out double pWeights);
}
```

