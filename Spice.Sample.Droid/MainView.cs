using Android.Content;
using SkiaSharp;
using SkiaSharp.Views.Android;

namespace Spice.Sample.Droid
{
	class MainView : SKGLSurfaceView
	{
		public MainView (Context c) : base (c) { }

		protected override void OnPaintSurface (SKPaintGLSurfaceEventArgs e)
		{
			base.OnPaintSurface (e);

			float spacing = Width / 5;
			var canvas = e.Surface.Canvas;
			canvas.Clear (Colors.MainBackground);
			Card.Draw (canvas, new SKRect (spacing, spacing, Width - spacing, Height - spacing));
		}
	}
}
