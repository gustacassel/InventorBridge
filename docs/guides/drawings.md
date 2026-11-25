# Drawings

> Detailing a part or an assembly: sheet from the template's format, views, breaks, sections, details, dimensions tied to edges, hole, chamfer and bend notes, center marks, flat patterns, weld symbols, parts list, balloons, saving the drawing alone.

Status: every step below ran on Inventor 2024.4 (2026-11-16), while detailing a 30-part assembly, a 1200 mm bar with holes and chamfers, and a bent sheet metal part, on A3 sheets; the guide tests compile the scripts.

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

Sketched symbols have not been run through these tools yet: look them up with `api_lookup` first.

## The order that works

1. Look for an existing drawing of the model first (same name and `.idw`, or in the vault with `vault_search`). If there is one, ask whether to revise it or start over: a revision keeps its sheet, title block and history. Otherwise create the drawing file from the drawing template (`CreateDocument`) next to the model, with the same name and `.idw`.
2. If the template only has an empty default sheet, add a sheet from one of its sheet formats, which carry the border and the title block, and delete the empty one.
3. Place the views: a base view, projected views, an isometric view, then breaks, sections, details and the flat pattern. Check the layout with `screenshot` (`zoomTo: "sheet"`).
4. Center marks, dimensions from the edges of the views, then hole, chamfer and bend notes and weld symbols. Move texts that overlap a section line or another note (`Text.Origin`, `Position`).
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

## Breaks

A long part keeps its scale with a break. `BreakOperations.Add` takes two points on the sheet, the start and the end of the part removed. `view.ModelToSheetSpace` turns a model point into that sheet point, and it follows the breaks already in the view, so place each break from model coordinates. Set the view's final scale first: the gap scales with the view.

```csharp
var drawing = (DrawingDocument)ActiveDocument;
DrawingView view = drawing.ActiveSheet.DrawingViews[1];
Point2d AtModelX(double millimeters) => view.ModelToSheetSpace(Geometry.CreatePoint(Mm(millimeters), Mm(30), Mm(6)));

// Remove 120..540 mm and 660..1080 mm of a 1200 mm bar along X: both ends and the middle stay.
view.BreakOperations.Add(BreakOrientationEnum.kHorizontalBreakOrientation, AtModelX(120), AtModelX(540),
    BreakStyleEnum.kStructuralBreakStyle, 5, Mm(5), 1, false);
view.BreakOperations.Add(BreakOrientationEnum.kHorizontalBreakOrientation, AtModelX(660), AtModelX(1080),
    BreakStyleEnum.kStructuralBreakStyle, 5, Mm(5), 1, false);
return $"{view.BreakOperations.Count} breaks, view now {view.Width * 10:0} mm wide";
```

`BreakOperations.Add` is the method on 2024; `AddBySketch` came in 2026 and `AddWithOptions` in 2027.

A dimension between the two end lines of a broken view shows the full length.

## Sections and details

- A section line is a sketch on the parent view: `view.Sketches.Add()`, `Edit()`, a line in the sketch's space (`sketch.SheetToSketchSpace`), `ExitEdit()`. Draw it past the part on both sides.
- `AddSectionView` places the section aligned with its parent; the name is the label letter. `AddDetailView` takes the fence center on the sheet and, for a circular fence, its radius on the sheet in cm.
- The template's style writes the labels, "A-A ( 1 : 1 )" and "B ( 1 : 1 )".

```csharp
var drawing = (DrawingDocument)ActiveDocument;
Sheet sheet = drawing.ActiveSheet;
DrawingView view = sheet.DrawingViews[1];
Point2d AtModel(double x, double y) => view.ModelToSheetSpace(Geometry.CreatePoint(Mm(x), Mm(y), 0));

// Section A-A across the part at x = 600 mm.
DrawingSketch line = view.Sketches.Add();
line.Edit();
line.SketchLines.AddByTwoPoints(line.SheetToSketchSpace(AtModel(600, 80)), line.SheetToSketchSpace(AtModel(600, -20)));
line.ExitEdit();
SectionDrawingView section = sheet.DrawingViews.AddSectionView(view, line, Geometry.CreatePoint2d(Mm(345), Mm(220)),
    DrawingViewStyleEnum.kFromBaseDrawingViewStyle, 1.0, true, "A");

// Detail B at 1:1, a circle of 22 mm on the sheet around the right end.
DetailDrawingView detail = sheet.DrawingViews.AddDetailView(view, Geometry.CreatePoint2d(Mm(345), Mm(130)),
    DrawingViewStyleEnum.kFromBaseDrawingViewStyle, true, AtModel(1170, 30), Mm(22), Type.Missing, 1.0, true, "B");
return $"{section.Name}: {section.Width * 10:0} x {section.Height * 10:0} mm; {detail.Name}: {detail.Width * 10:0} x {detail.Height * 10:0} mm";
```

## Sheet metal: the flat pattern

The flat pattern view is a base view of the sheet metal part with `SheetMetalFoldedModel` set to false. The part must have a flat pattern already (`SheetMetalComponentDefinition.HasFlatPattern`; `Unfold()` makes one).

```csharp
var drawing = (DrawingDocument)ActiveDocument;
Sheet sheet = drawing.ActiveSheet;
Document model = App.Documents.ItemByName[System.IO.Path.ChangeExtension(drawing.FullFileName, ".ipt")];

NameValueMap options = Objects.CreateNameValueMap();
options.Add("SheetMetalFoldedModel", false);
DrawingView flat = sheet.DrawingViews.AddBaseView((_Document)model, Geometry.CreatePoint2d(Mm(130), Mm(110)), 0.5,
    ViewOrientationTypeEnum.kDefaultViewOrientation, DrawingViewStyleEnum.kHiddenLineRemovedDrawingViewStyle,
    AdditionalOptions: options);
return $"flat pattern {flat.IsFlatPatternView}: {flat.Width / flat.Scale * 10:0} x {flat.Height / flat.Scale * 10:0} mm";
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

## Center marks

`SetAutomatedCenterlineSettings` does what the Automated Centerlines dialog does: center marks on the holes seen end on, center lines on the ones seen from the side. It returns what it added. For a single hole, `Sheet.Centermarks.Add(sheet.CreateGeometryIntent(circle))`.

```csharp
var drawing = (DrawingDocument)ActiveDocument;
var lines = new List<string>();
foreach (DrawingView view in drawing.ActiveSheet.DrawingViews)
{
    view.GetAutomatedCenterlineSettings(out AutomatedCenterlineSettings settings);
    settings.ApplyToHoles = true;
    settings.ProjectionNormalAxis = true;
    settings.ProjectionParallelAxis = false;
    ObjectsEnumerator added = view.SetAutomatedCenterlineSettings(settings);
    lines.Add($"{view.Name}: {added?.Count ?? 0} added");
}

return string.Join("\n", lines);
```

## Hole, thread and chamfer notes

- `HoleThreadNotes.Add(position, circle)` takes the hole's circle in a view where the hole is seen end on. Inventor writes the note from the hole feature: "Ø13 THRU", "M10x1.5 - 6H". It works on hole features; a circle cut by an extrusion has no hole data.
- The count of like holes ("(4x)") is not in the default note. Turn the default format off, set the quantity format, and add `<QuantityNote/>` inside the last `StyleOverride`, or the count comes out in another font size. Other spellings (`<QTYNOTE>`, `<Quantity/>`) end up as plain text in the note.
- `ChamferNotes.Add(position, chamferLine, adjacentLine)` takes the slanted line of the chamfer and a line that meets it, and writes "5 X 45°".
- In a note's `Text.Text`, Ø reads as "n": the symbol is the letter n in the AIGDT font.

```csharp
var drawing = (DrawingDocument)ActiveDocument;
Sheet sheet = drawing.ActiveSheet;
DrawingView view = sheet.DrawingViews[1];

DrawingCurve hole = view.get_DrawingCurves(Type.Missing).Cast<DrawingCurve>()
    .Where(curve => curve.CurveType == CurveTypeEnum.kCircleCurve)
    .OrderByDescending(curve => curve.CenterPoint.Y).First();
HoleThreadNote note = sheet.DrawingNotes.HoleThreadNotes.Add(
    Geometry.CreatePoint2d(hole.CenterPoint.X + Mm(30), view.Center.Y + view.Height / 2 + Mm(8)), hole);

// "Ø13 THRU (4x)": the count inside the last style override, so it keeps the note's font size.
string format = note.FormattedHoleThreadNote;
if (format.Contains("kHoleDiameterHoleProperty"))
{
    note.UseDefaultFormat = false;
    note.FormattedQuantityNote = "(<Quantity/>x)";
    int end = format.LastIndexOf("</StyleOverride>");
    note.FormattedHoleThreadNote = end < 0 ? $"{format} <QuantityNote/>" : format.Insert(end, " <QuantityNote/>");
}

return note.Text.Text;
```

## Bend notes

On a flat pattern view, the bend lines are the curves whose `EdgeType` is `kBendUpEdge` or `kBendDownEdge`. `BendNotes.Add(bendLine)` writes direction, angle and radius in the template's language ("ABAIXO 90° R3" from a Portuguese template).

```csharp
var drawing = (DrawingDocument)ActiveDocument;
Sheet sheet = drawing.ActiveSheet;
DrawingView flat = sheet.DrawingViews.Cast<DrawingView>().First(view => view.IsFlatPatternView);

var notes = new List<string>();
foreach (DrawingCurve curve in flat.get_DrawingCurves(Type.Missing))
{
    if (curve.EdgeType == DrawingEdgeTypeEnum.kBendUpEdge || curve.EdgeType == DrawingEdgeTypeEnum.kBendDownEdge)
    {
        notes.Add(sheet.DrawingNotes.BendNotes.Add(curve).Text);
    }
}

return string.Join("\n", notes);
```

## Weld symbols

- `WeldingSymbols.CreateDefinitions()`, then `Add()` one definition per weld (two for a symbol on both sides).
- `WeldSymbolType` takes a `WeldSymbolTypeEnum` value (`kFilletWeldSymbolType`); the `WeldSymbolVariationTypeEnum` values are refused.
- Which fields a weld takes depends on its type and the drafting standard. Under ISO, a fillet's size goes in `SizeOrStrength` ("a5") and `Length` takes the weld length; `Leg1` and `Thickness` fail with `E_FAIL`. Under ANSI it is the other way: the size goes in `Leg1`, and `SizeOrStrength` fails.
- Reading is the same: a field the weld does not have throws. `inspect` on a drawing lists each sheet's weld symbols with the fields they have (type, size, length, contour, all around, tail).
- The leader goes like a balloon's: the symbol's position first, the edge's `GeometryIntent` last.

```csharp
var drawing = (DrawingDocument)ActiveDocument;
Sheet sheet = drawing.ActiveSheet;
DrawingView view = sheet.DrawingViews[1];
DrawingCurve bottom = view.get_DrawingCurves(Type.Missing).Cast<DrawingCurve>()
    .Where(curve => curve.CurveType == CurveTypeEnum.kLineSegmentCurve && Math.Abs(curve.StartPoint.Y - curve.EndPoint.Y) < 1e-6)
    .OrderBy(curve => curve.StartPoint.Y).First();

DrawingWeldingSymbolDefinitions definitions = sheet.WeldingSymbols.CreateDefinitions();
DrawingWeldingSymbolDefinition weld = definitions.Add();
weld.WeldSymbolOne.WeldSymbolType = (int)WeldSymbolTypeEnum.kFilletWeldSymbolType;
weld.WeldSymbolOne.SizeOrStrength = "a5";
weld.AllAroundSymbol = true;

ObjectCollection leader = Objects.CreateObjectCollection();
leader.Add(Geometry.CreatePoint2d(bottom.MidPoint.X - Mm(40), bottom.MidPoint.Y - Mm(20)));
leader.Add(sheet.CreateGeometryIntent(bottom, PointIntentEnum.kMidPointIntent));
sheet.WeldingSymbols.Add(leader, definitions);
return $"{sheet.WeldingSymbols.Count} weld symbols";
```

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
- Keep every balloon outside the outline of the views, those already in the drawing too: a balloon in the middle of a view is hard to see, and was the first thing a user asked to fix.
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
