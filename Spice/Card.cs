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
			canvas.DrawRoundRect (new SKRect (rect.Left - offset, rect.Top - offset, rect.Right - offset, rect.Bottom - offset), rounded, paint);

			// Draw dark shadow
			paint.Color = Colors.DarkShadow;
			canvas.DrawRoundRect (new SKRect (rect.Left + offset, rect.Top + offset, rect.Right + offset, rect.Bottom + offset), rounded, paint);

			// Draw filled shape
			paint.Color = Colors.ShapeBackground;
			paint.ImageFilter = null;
			canvas.DrawRoundRect (rect, rounded, paint);
		}
	}
}
