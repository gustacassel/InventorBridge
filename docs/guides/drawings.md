# Drawings

> Detailing a part or an assembly: sheet from the template's format, views, dimensions tied to edges, parts list, balloons, saving the drawing alone.

Status: every step below ran on Inventor 2024.4 (2026-11-16) while detailing a 30-part assembly on an A3 sheet; the guide tests compile the scripts.

## What a detail drawing usually has

General drafting practice, also what 583 production drawings of one manufacturer showed. A company guide, when there is one, says what that company does differently.

- One sheet, the smallest standard size that fits the views at a standard scale (1:1, 1:2, 1:2.5, 1:5, 1:10...).
- A base view showing the most characteristic shape, projected views only as needed (two or three), and often an isometric view that helps reading but carries no dimensions.
- Hidden lines removed by default. A section view, rather than hidden lines, for holes, chamfers or walls inside the part.
- View labels only on sections and details, with their scale ("A-A (1 : 2)").
- Only the dimensions manufacturing needs, each size once: diameters on round features, a hole note with its count ("Ø11 (2x)"), chamfers by a note ("2 X 45°"), center marks on holes. Sizes that come from the stock (sheet thickness, tube diameter and wall) as reference dimensions in parentheses.
- Sheet metal: a view of the flat pattern, with bend notes giving the direction, angle and radius of each bend.
- Assemblies: a parts list and a balloon for every item, overall dimensions, and weld symbols on welded assemblies. Hidden fasteners go on their bolt's balloon, stacked.
- Long parts: a view with a break, the full length dimensioned across it.
- Short notes, in capitals, above the title block.

Not yet run through these tools, so look the methods up with `api_lookup` first: section and detail views (`DrawingViews.AddSectionView`, `AddDetailView`), breaks (`DrawingView.BreakOperations`), hole and bend notes (`DrawingNotes.HoleThreadNotes`, `BendNotes`), center marks (`Sheet.Centermarks`), a flat pattern view (`AddBaseView` options), weld symbols and sketched symbols.

## The order that works

1. Create the drawing file from the drawing template (`CreateDocument`) next to the model, with the same name and `.idw`.
2. If the template only has an empty default sheet, add a sheet from one of its sheet formats, which carry the border and the title block, and delete the empty one.
3. Place the views: a base view, projected views, an isometric view. Check the layout with `screenshot` (`zoomTo: "sheet"`).
4. Dimensions, from the edges of the views.
5. Parts list (assemblies), then balloons.
6. Save the drawing alone, then `inspect` (no detached dimensions) and `check`.

One script per step: each step is easy to check on a screenshot and to undo with `undo_last`.

## Sheet and template

The title block usually fills in by itself from the model's iProperties (description, part number, designer, scale). Read the template first:

```csharp
var drawing = (DrawingDocument)ActiveDocument;
var lines = new List<string>();
foreach (Sheet sheet in drawing.Sheets)
{
    lines.Add($"{sheet.Name}: {sheet.Size}, border {sheet.Border?.Name}, title block {sheet.TitleBlock?.Name}");
}

lines.Add("formats: " + string.Join(", ", drawing.SheetFormats.Cast<SheetFormat>().Select(format => format.Name)));
return string.Join("\n", lines);
```

A sheet from a format, replacing the empty default sheet:

```csharp
var drawing = (DrawingDocument)ActiveDocument;
Sheet empty = drawing.Sheets[1];
Sheet sheet = drawing.Sheets.AddUsingSheetFormat(drawing.SheetFormats["A3"], null, "A3");
sheet.Activate();
empty.Delete();
return $"{sheet.Name}: {sheet.Width * 10} x {sheet.Height * 10} mm";
```

## Views

- Positions and sizes on a sheet are in cm from its lower left corner; `Mm()` converts. `DrawingView.Width` and `Height` give the view's size on the sheet, so `Width / Scale` is the model's size.
- Which named orientation shows which side depends on how the model was built. Do not guess: place a base view in each candidate orientation, read its size, delete it, and keep the one that shows what you want (the length along the sheet, for example).
- `AddProjectedView` keeps the projected view aligned with its base. An isometric view is clearer as a base view of its own (`kIsoTopRightViewOrientation`) than as a diagonal projection.
- Keep views inside the border with a margin; parts that stick out (bolt heads) count in the view's size.

```csharp
var drawing = (DrawingDocument)ActiveDocument;
Sheet sheet = drawing.ActiveSheet;
Document model = App.Documents.ItemByName[System.IO.Path.ChangeExtension(drawing.FullFileName, ".iam")];

DrawingView main = sheet.DrawingViews.AddBaseView((_Document)model, Geometry.CreatePoint2d(Mm(150), Mm(225)), 0.2,
    ViewOrientationTypeEnum.kRightViewOrientation, DrawingViewStyleEnum.kHiddenLineRemovedDrawingViewStyle);
DrawingView side = sheet.DrawingViews.AddProjectedView(main, Geometry.CreatePoint2d(Mm(318), Mm(225)),
    DrawingViewStyleEnum.kFromBaseDrawingViewStyle);
DrawingView iso = sheet.DrawingViews.AddBaseView((_Document)model, Geometry.CreatePoint2d(Mm(118), Mm(100)), 0.2,
    ViewOrientationTypeEnum.kIsoTopRightViewOrientation, DrawingViewStyleEnum.kHiddenLineRemovedDrawingViewStyle);

return $"main {main.Width / main.Scale * 10:0} x {main.Height / main.Scale * 10:0} mm of model";
```

## Dimensions tied to edges

A dimension attached to the drawing's curves follows the model when it changes. `DrawingCurves` with an occurrence returns only that component's curves in the view (in C#, `view.get_DrawingCurves(occurrence)`; without one, pass `Type.Missing`). For an overall size, take the extreme straight lines:

```csharp
var drawing = (DrawingDocument)ActiveDocument;
Sheet sheet = drawing.ActiveSheet;
DrawingView view = sheet.DrawingViews[1];

var vertical = new List<DrawingCurve>();
foreach (DrawingCurve curve in view.get_DrawingCurves(Type.Missing))
{
    if (curve.CurveType == CurveTypeEnum.kLineSegmentCurve && Math.Abs(curve.StartPoint.X - curve.EndPoint.X) < 1e-6)
    {
        vertical.Add(curve);
    }
}

DrawingCurve left = vertical.OrderBy(curve => curve.StartPoint.X).First();
DrawingCurve right = vertical.OrderBy(curve => curve.StartPoint.X).Last();
var textPoint = Geometry.CreatePoint2d(view.Center.X, view.Center.Y + view.Height / 2 + Mm(10));
LinearGeneralDimension length = sheet.DrawingDimensions.GeneralDimensions.AddLinear(textPoint,
    sheet.CreateGeometryIntent(left), sheet.CreateGeometryIntent(right), DimensionTypeEnum.kHorizontalDimensionType);
return $"{length.Text.Text}, attached {length.Attached}";
```

For a nested component, pass the occurrence from `Occurrences.AllLeafOccurrences` (a proxy), not the one inside the subassembly's own document.

## Parts list

`PartsLists.Add(view, point)` places it; then sort by the drawing's column title (the template's language), renumber, and move it by its `RangeBox` to sit above the title block:

```csharp
var drawing = (DrawingDocument)ActiveDocument;
Sheet sheet = drawing.ActiveSheet;
PartsList list = sheet.PartsLists.Add(sheet.DrawingViews[1], Geometry.CreatePoint2d(Mm(400), Mm(160)));

string firstColumn = list.PartsListColumns[2].Title;
list.Sort2(firstColumn, true, SortByString: false);
list.Renumber();

Box2d titleBlock = sheet.TitleBlock.RangeBox;
Box2d box = list.RangeBox;
list.Position = Geometry.CreatePoint2d(list.Position.X + (titleBlock.MaxPoint.X - box.MaxPoint.X),
    list.Position.Y + (titleBlock.MaxPoint.Y - box.MinPoint.Y));
return $"{list.PartsListRows.Count} rows";
```

## Balloons

- `Balloons.Add` takes an `ObjectCollection`: the balloon's position (`Point2d`) first, then a `GeometryIntent` on a curve of the component. A balloon placed on a component's curve gets that component's item number.
- In a hidden-line-removed view, small parts behind others (washers, nuts) have no visible curve. Stack them on a visible neighbor's balloon: `balloon.BalloonValueSets.Add(row.ReferencedRows[1])` with the parts list row's drawing BOM row. A `PartsListRow` or a `BOMRow` is refused with `E_INVALIDARG`.
- A stacked balloon grows downward, one balloon per extra item: leave that room.
- Balloons placed in a column beside the view, ordered by the height of the point they point to, keep leaders from crossing. Anchor each leader on the component's point farthest from the view's center: the space beyond it is usually empty.

```csharp
var drawing = (DrawingDocument)ActiveDocument;
Sheet sheet = drawing.ActiveSheet;
DrawingView iso = sheet.DrawingViews[3];
var assembly = (AssemblyDocument)iso.ReferencedDocumentDescriptor.ReferencedDocument;
ComponentOccurrence occurrence = assembly.ComponentDefinition.Occurrences[1];

DrawingCurve edge = null;
foreach (DrawingCurve curve in iso.get_DrawingCurves(occurrence))
{
    if (curve.CurveType == CurveTypeEnum.kLineSegmentCurve)
    {
        edge = curve;
        break;
    }
}

ObjectCollection leader = Objects.CreateObjectCollection();
leader.Add(Geometry.CreatePoint2d(Mm(30), Mm(60)));
leader.Add(sheet.CreateGeometryIntent(edge, PointIntentEnum.kMidPointIntent));
Balloon balloon = sheet.Balloons.Add(leader);

// Stack the parts list's first row on the same balloon.
PartsListRow row = sheet.PartsLists[1].PartsListRows[1];
balloon.BalloonValueSets.Add(row.ReferencedRows[1]);
return $"attached {balloon.Attached}, values {balloon.BalloonValueSets.Count}";
```

## Saving

Save the drawing alone with `Save2(false)`: its argument says whether to save the referenced documents that have unsaved changes too. Models opened from a vault are often read-only, and marked changed only because Inventor updated them on open.

```csharp
var drawing = (DrawingDocument)ActiveDocument;
drawing.Save2(false);
return drawing.FullFileName;
```

Then `inspect` lists sheets, views, parts lists, balloons and how many dimensions are detached, and `check` looks for detached dimensions and balloons and missing references.
