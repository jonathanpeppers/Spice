using SkiaSharp;

namespace Spice
{
	public static class Card
	{
		public static void Draw (SKCanvas canvas, SKRect rect)
		{
			// Draw light shadow
			Skia.Paint.Style = SKPaintStyle.Fill;
			Skia.Paint.Color = Colors.LightShadow;
			Skia.Paint.ImageFilter = Effects.BlurEffect;
			canvas.Translate (-Constants.ShadowOffset, -Constants.ShadowOffset);
			canvas.DrawRoundRect (rect, Constants.RoundedSize, Skia.Paint);

			// Draw dark shadow
			Skia.Paint.Color = Colors.DarkShadow;
			canvas.Translate (Constants.ShadowOffset * 2, Constants.ShadowOffset * 2);
			canvas.DrawRoundRect (rect, Constants.RoundedSize, Skia.Paint);

			// Draw filled shape
			canvas.Translate (-Constants.ShadowOffset, -Constants.ShadowOffset);
			Skia.Paint.Color = Colors.ShapeBackground;
			Skia.Paint.ImageFilter = null;
			canvas.DrawRoundRect (rect, Constants.RoundedSize, Skia.Paint);
		}
	}
}
