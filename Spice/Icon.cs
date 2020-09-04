using SkiaSharp;

namespace Spice
{
	public static class Icon
	{
		public static void Draw (SKCanvas canvas, SKRect rect, SKPath path)
		{
			Skia.Paint.Style = SKPaintStyle.Fill;

			// Translate to center a (90, 112.5) heart SVG
			canvas.Translate (rect.Left + (rect.Width - 90) / 2f, rect.Top + (rect.Height - 112.5f) / 2f);

			// Draw heart shadow
			canvas.Translate (Constants.ShadowOffset, Constants.ShadowOffset);
			Skia.Paint.Color = SKColors.Magenta.WithAlpha (0x33);
			Skia.Paint.ImageFilter = Effects.BlurEffect;
			canvas.DrawPath (path, Skia.Paint);

			// Draw heart
			canvas.Translate (-Constants.ShadowOffset, -Constants.ShadowOffset);
			Skia.Paint.Color = SKColors.Magenta;
			Skia.Paint.Style = SKPaintStyle.Stroke;
			Skia.Paint.StrokeWidth = 10;
			Skia.Paint.ImageFilter = null;
			canvas.DrawPath (path, Skia.Paint);
		}
	}
}
