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

			// Translate to center a 100x150 heart SVG
			canvas.Translate (rect.Left + (rect.Width - 100) / 2f, rect.Top + (rect.Height - 150) / 2f);
			paint.Color = SKColors.SlateGray;
			paint.ImageFilter = blurEffect;
			canvas.DrawPath (Svgs.Heart, paint);
			paint.ImageFilter = null;
			canvas.DrawPath (Svgs.Heart, paint);
		}
	}
}
