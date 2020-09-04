using SkiaSharp;

namespace Spice
{
	public class Effects
	{
		const float blur = 16;

		public static readonly SKImageFilter BlurEffect = SKImageFilter.CreateBlur (blur, blur);
	}
}
