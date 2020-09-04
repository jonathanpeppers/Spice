#nullable enable
using Android.Content;
using Android.Opengl;
using SkiaSharp;
using SkiaSharp.Views.Android;

namespace Spice.Sample.Droid
{
	class IconView : SKGLTextureView
	{
		public IconView (Context c) : base (c)
		{
			RenderMode = Rendermode.WhenDirty;
		}

		SKPath? path;

		public SKPath? Path {
			get => path;
			set { Invalidate (); path = value; }
		}

		protected override void OnPaintSurface (SKPaintGLSurfaceEventArgs e)
		{
			base.OnPaintSurface (e);

			var canvas = e.Surface.Canvas;
			canvas.Clear (Colors.MainBackground);
			if (path != null) {
				Icon.Draw (canvas, new SKRect (0, 0, Width, Height), path);
			}
		}
	}
}
