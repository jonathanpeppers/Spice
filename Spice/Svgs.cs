using System;
using SkiaSharp;

namespace Spice
{
	public static class Svgs
	{
		static readonly Lazy<SKPath> heart = new Lazy<SKPath> (() => SKPath.ParseSvgPathData ("M45,23.9L45,23.9c0,0,18.1-22.3,37.3-5.4c11.3,9.9,9.7,25.4-2,37.1L45,89.7L9.7,55.6C-2,43.9-3.6,28.4,7.7,18.5  C26.9,1.6,45,23.9,45,23.9L45,23.9z"));

		public static SKPath Heart => heart.Value;
	}
}
