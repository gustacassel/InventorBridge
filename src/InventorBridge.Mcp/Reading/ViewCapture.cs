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
    public static class ViewCapture
    {
        public static byte[] CapturePng(Application application, int width, int height, CaptureOrientation orientation, bool fit)
        {
            var view = application.ActiveView
                ?? throw new InvalidOperationException("There is no active view: open or create a document first.");

            if (orientation != CaptureOrientation.Current)
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
