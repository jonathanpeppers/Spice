using System;
using Android.Content;
using SkiaSharp;
using SkiaSharp.Views.Android;

namespace Spice.Sample.Droid
{
	class MainView : SKGLSurfaceView
	{
		static readonly SKColor background = SKColors.Red;

		public MainView (Context c) : base (c) { }

		protected override void OnPaintSurface (SKPaintGLSurfaceEventArgs e)
		{
			base.OnPaintSurface (e);

			var canvas = e.Surface.Canvas;
			canvas.Clear (background);
			Xamagon.Draw (canvas, Math.Min (Width, Height));
		}
	}
}
