using System.Runtime.InteropServices;
using Inventor;

namespace InventorBridge.Mcp.Reading
{
    /// <summary>Camera orientations the screenshot tool can switch to before capturing.</summary>
    public enum CaptureOrientation
    {
        Current,
        Iso,
        Front,
        Top,
        Right,
    }

    /// <summary>Captures the active Inventor view as a PNG.</summary>
    /// <remarks>
    /// Hiding work features and sketches, and zooming into part of a drawing sheet, last only for the capture: the
    /// user's visibility settings, camera and the document's unsaved-changes flag are put back afterwards.
    /// </remarks>
    public static class ViewCapture
    {
        private const double MillimetersPerCentimeter = 10.0;
        private const double ZoomMargin = 1.08;

        public static byte[] CapturePng(Application application, int width, int height, CaptureOrientation orientation,
            bool fit, bool hideHelpers, string? zoomTo, double[]? regionMm)
        {
            var view = application.ActiveView
                ?? throw new InvalidOperationException("There is no active view: open or create a document first.");
            var document = application.ActiveDocument;
            var restore = new List<Action>();

            try
            {
                if (zoomTo is not null || regionMm is not null)
                {
                    var drawing = document as DrawingDocument
                        ?? throw new InvalidOperationException("zoomTo and regionMm work on drawings: activate a drawing first.");
                    var region = regionMm is not null ? RegionFromMillimeters(regionMm) : RegionOf(drawing.ActiveSheet, zoomTo!);
                    SaveCamera(view, restore);
                    ZoomTo(view, region, (double)width / height);
                }
                else if (orientation != CaptureOrientation.Current)
                {
                    var camera = view.Camera;
                    camera.ViewOrientationType = ToInventorOrientation(orientation);
                    camera.Fit();
                    camera.Apply();
                }
                else if (fit)
                {
                    view.Fit();
                }

                if (hideHelpers && document is not null)
                {
                    HideHelpers(document, restore);
                }

                return SaveBitmap(view, width, height);
            }
            finally
            {
                for (var index = restore.Count - 1; index >= 0; index--)
                {
                    try
                    {
                        restore[index]();
                    }
                    catch (COMException)
                    {
                        // Best effort: the capture itself already succeeded or failed on its own.
                    }
                }
            }
        }

        private static byte[] SaveBitmap(View view, int width, int height)
        {
            var path = System.IO.Path.Combine(System.IO.Path.GetTempPath(), $"inventorbridge-{Guid.NewGuid():N}.png");
            try
            {
                view.SaveAsBitmap(path, width, height);
                return System.IO.File.ReadAllBytes(path);
            }
            finally
            {
                System.IO.File.Delete(path);
            }
        }

        /// <summary>
        /// Turns off work planes, axes and points, coordinate systems and sketches for the capture, and records how
        /// to turn back on what was on, then puts back the document's unsaved-changes flag.
        /// </summary>
        private static void HideHelpers(Document document, List<Action> restore)
        {
            var visibility = document switch
            {
                PartDocument part => part.ObjectVisibility,
                AssemblyDocument assembly => assembly.ObjectVisibility,
                _ => null,
            };

            if (visibility is null)
            {
                return;
            }

            var wasDirty = document.Dirty;
            restore.Add(() =>
            {
                if (!wasDirty && document.Dirty)
                {
                    document.Dirty = false;
                }
            });

            void Hide(Func<bool> get, Action<bool> set)
            {
                if (get())
                {
                    set(false);
                    restore.Add(() => set(true));
                }
            }

            Hide(() => visibility.OriginWorkPlanes, value => visibility.OriginWorkPlanes = value);
            Hide(() => visibility.OriginWorkAxes, value => visibility.OriginWorkAxes = value);
            Hide(() => visibility.OriginWorkPoints, value => visibility.OriginWorkPoints = value);
            Hide(() => visibility.UserWorkPlanes, value => visibility.UserWorkPlanes = value);
            Hide(() => visibility.UserWorkAxes, value => visibility.UserWorkAxes = value);
            Hide(() => visibility.UserWorkPoints, value => visibility.UserWorkPoints = value);
            Hide(() => visibility.UCSTriads, value => visibility.UCSTriads = value);
            Hide(() => visibility.UCSWorkPlanes, value => visibility.UCSWorkPlanes = value);
            Hide(() => visibility.UCSWorkAxes, value => visibility.UCSWorkAxes = value);
            Hide(() => visibility.UCSWorkPoints, value => visibility.UCSWorkPoints = value);
            Hide(() => visibility.Sketches, value => visibility.Sketches = value);
            Hide(() => visibility.Sketches3D, value => visibility.Sketches3D = value);
        }

        private static void SaveCamera(View view, List<Action> restore)
        {
            var camera = view.Camera;
            var eye = camera.Eye;
            var target = camera.Target;
            var up = camera.UpVector;
            camera.GetExtents(out var extentWidth, out var extentHeight);

            restore.Add(() =>
            {
                var back = view.Camera;
                back.Eye = eye;
                back.Target = target;
                back.UpVector = up;
                back.SetExtents(extentWidth, extentHeight);
                back.Apply();
            });
        }

        /// <summary>Points the camera at a sheet region (cm), keeping the image's aspect ratio, with a small margin.</summary>
        private static void ZoomTo(View view, (double MinX, double MinY, double MaxX, double MaxY) region, double aspect)
        {
            var camera = view.Camera;
            var geometry = view.Application is Application application ? application.TransientGeometry : null;
            var centerX = (region.MinX + region.MaxX) / 2;
            var centerY = (region.MinY + region.MaxY) / 2;
            var regionWidth = Math.Max(region.MaxX - region.MinX, 0.1) * ZoomMargin;
            var regionHeight = Math.Max(region.MaxY - region.MinY, 0.1) * ZoomMargin;

            if (regionWidth / regionHeight < aspect)
            {
                regionWidth = regionHeight * aspect;
            }
            else
            {
                regionHeight = regionWidth / aspect;
            }

            var eyeDistance = camera.Eye.Z - camera.Target.Z;
            camera.Target = geometry!.CreatePoint(centerX, centerY, 0);
            camera.Eye = geometry.CreatePoint(centerX, centerY, eyeDistance == 0 ? 1 : eyeDistance);
            camera.SetExtents(regionWidth, regionHeight);
            camera.Apply();
        }

        private static (double, double, double, double) RegionFromMillimeters(double[] regionMm)
        {
            if (regionMm.Length != 4 || regionMm[2] <= regionMm[0] || regionMm[3] <= regionMm[1])
            {
                throw new ArgumentException("regionMm needs four values on the sheet, in mm from its lower left corner: [minX, minY, maxX, maxY].");
            }

            return (regionMm[0] / MillimetersPerCentimeter, regionMm[1] / MillimetersPerCentimeter,
                regionMm[2] / MillimetersPerCentimeter, regionMm[3] / MillimetersPerCentimeter);
        }

        /// <summary>The region of the active sheet to zoom to: "sheet", "partsList", "titleBlock" or a view's name.</summary>
        private static (double, double, double, double) RegionOf(Sheet sheet, string target)
        {
            if (string.Equals(target, "sheet", StringComparison.OrdinalIgnoreCase))
            {
                return (0, 0, sheet.Width, sheet.Height);
            }

            if (string.Equals(target, "partsList", StringComparison.OrdinalIgnoreCase))
            {
                if (sheet.PartsLists.Count == 0)
                {
                    throw new InvalidOperationException($"Sheet {sheet.Name} has no parts list.");
                }

                return FromBox(sheet.PartsLists[1].RangeBox);
            }

            if (string.Equals(target, "titleBlock", StringComparison.OrdinalIgnoreCase))
            {
                return FromBox(sheet.TitleBlock?.RangeBox
                    ?? throw new InvalidOperationException($"Sheet {sheet.Name} has no title block."));
            }

            var names = new List<string>();
            foreach (DrawingView drawingView in sheet.DrawingViews)
            {
                if (string.Equals(drawingView.Name, target, StringComparison.OrdinalIgnoreCase))
                {
                    var center = drawingView.Center;
                    return (center.X - drawingView.Width / 2, center.Y - drawingView.Height / 2,
                        center.X + drawingView.Width / 2, center.Y + drawingView.Height / 2);
                }

                names.Add(drawingView.Name);
            }

            throw new InvalidOperationException(
                $"\"{target}\" is not on sheet {sheet.Name}. Use sheet, partsList, titleBlock or a view: {string.Join(", ", names)}.");
        }

        private static (double, double, double, double) FromBox(Box2d box)
        {
            return (box.MinPoint.X, box.MinPoint.Y, box.MaxPoint.X, box.MaxPoint.Y);
        }

        private static ViewOrientationTypeEnum ToInventorOrientation(CaptureOrientation orientation)
        {
            switch (orientation)
            {
                case CaptureOrientation.Front: return ViewOrientationTypeEnum.kFrontViewOrientation;
                case CaptureOrientation.Top: return ViewOrientationTypeEnum.kTopViewOrientation;
                case CaptureOrientation.Right: return ViewOrientationTypeEnum.kRightViewOrientation;
                default: return ViewOrientationTypeEnum.kIsoTopRightViewOrientation;
            }
        }
    }
}
