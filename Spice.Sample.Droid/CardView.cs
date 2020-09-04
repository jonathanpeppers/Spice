using Android.Content;
using Android.Opengl;
using SkiaSharp;
using SkiaSharp.Views.Android;

namespace Spice.Sample.Droid
{
	class CardView : SKGLTextureView
	{
		public CardView (Context c) : base (c)
		{
			ClipToOutline = false;
			RenderMode = Rendermode.WhenDirty;
		}

		protected override void OnPaintSurface (SKPaintGLSurfaceEventArgs e)
		{
			base.OnPaintSurface (e);

			float spacing = 50;
			var canvas = e.Surface.Canvas;
			canvas.Clear (Colors.MainBackground);
			Card.Draw (canvas, new SKRect (spacing, spacing, Width - spacing, Height - spacing));
		}
	}
}
