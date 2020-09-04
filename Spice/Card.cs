using SkiaSharp;

namespace Spice
{
	public static class Card
	{
		const float offset = 12;
		const float blur = 16;
		static readonly SKSize rounded = new SKSize (32f, 32f);
		static readonly SKImageFilter blurEffect = SKImageFilter.CreateBlur (blur, blur);
		static readonly SKPaint paint = new SKPaint { IsAntialias = true };

		public static void Draw (SKCanvas canvas, SKRect rect)
		{
			// Draw light shadow
			paint.Style = SKPaintStyle.Fill;
			paint.Color = Colors.LightShadow;
			paint.ImageFilter = blurEffect;
			canvas.Translate (-offset, -offset);
			canvas.DrawRoundRect (rect, rounded, paint);

			// Draw dark shadow
			paint.Color = Colors.DarkShadow;
			canvas.Translate (offset * 2, offset * 2);
			canvas.DrawRoundRect (rect, rounded, paint);

			// Draw filled shape
			canvas.Translate (-offset, -offset);
			paint.Color = Colors.ShapeBackground;
			paint.ImageFilter = null;
			canvas.DrawRoundRect (rect, rounded, paint);

			// Translate to center a (90, 112.5) heart SVG
			canvas.Translate (rect.Left + (rect.Width - 90) / 2f, rect.Top + (rect.Height - 112.5f) / 2f);

			// Draw heart shadow
			canvas.Translate (offset, offset);
			paint.Color = SKColors.Magenta.WithAlpha (0x33);
			paint.ImageFilter = blurEffect;
			canvas.DrawPath (Svgs.Heart, paint);

			// Draw heart
			canvas.Translate (-offset, -offset);
			paint.Color = SKColors.Magenta;
			paint.Style = SKPaintStyle.Stroke;
			paint.StrokeWidth = 10;
			paint.ImageFilter = null;
			canvas.DrawPath (Svgs.Heart, paint);
		}
	}
}
