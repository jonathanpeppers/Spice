#nullable enable
using Android.App;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Widget;
using AndroidX.AppCompat.App;
using SkiaSharp;

namespace Spice.Sample.Droid
{
	[Activity (Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
	public class MainActivity : AppCompatActivity
	{
		protected override void OnCreate (Bundle? savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.activity_main);

			var layout = FindViewById<RelativeLayout> (Resource.Id.cardLayout);
			if (layout != null) {
				if (layout.Parent is RelativeLayout parent) {
					parent.Background = new ColorDrawable (ToColor (Colors.MainBackground));
				}

				layout.AddView (new CardView (this));

				var heart = new IconView (this) { Path = Svgs.Heart };
				var @params = new RelativeLayout.LayoutParams (150, 150);
				@params.AddRule (LayoutRules.CenterInParent);
				heart.LayoutParameters = @params;
				layout.AddView (heart);
			}
		}

		Color ToColor (SKColor color) => new Color (color.Red, color.Green, color.Blue, color.Alpha);
	}
}
