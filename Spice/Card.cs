using SkiaSharp;

namespace Spice
{
	public static class Card
	{
		const float blur = 32;
		static readonly SKSize rounded = new SKSize (32f, 32f);
		static readonly SKImageFilter lightShadow = SKImageFilter.CreateDropShadow (-12, -12, blur, blur, Colors.DarkShadow);
		static readonly SKImageFilter darkShadow  = SKImageFilter.CreateDropShadow (12, 12, blur, blur, Colors.DarkShadow);
		//static readonly SKImageFilter shadow = SKImageFilter.CreateCompose (lightShadow, darkShadow);

		public static void Draw (SKCanvas canvas, SKRect rect)
		{
			using (var paint = new SKPaint ()) {
				paint.IsAntialias = true;

				// Draw filled shape
				paint.Color = Colors.ShapeBackground;
				paint.ImageFilter = lightShadow;
				canvas.DrawRoundRect (rect, rounded, paint);

				// Draw lined border
				paint.StrokeWidth = 1;
				paint.Style = SKPaintStyle.Stroke;
				paint.Color = Colors.Border;
				paint.ImageFilter = darkShadow;
				canvas.DrawRoundRect (rect, rounded, paint);
			}
		}
	}
}
