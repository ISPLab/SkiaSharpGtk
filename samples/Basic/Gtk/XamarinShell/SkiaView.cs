using System;

using Xamarin.Forms;
using SkiaSharp;
using System.IO;

namespace XamarinShell
{
	public class SkiaView : Xamarin.Forms.ContentView
	{
		public SkiaView()
		{

			var area = CreatDrowArea();
			Xamarin.Forms.Image image = new Xamarin.Forms.Image();
			var res = area.Encode();
			Stream stream = new System.IO.MemoryStream();
			stream = res.AsStream();
			image.Source = Xamarin.Forms.ImageSource.FromStream(()=>stream);
			this.Content = image;
			this.WidthRequest = 100;
			this.HeightRequest = 100;
			/*Cairo.Surface surface = new Cairo.ImageSurface(
					image.Encode().Data,
					Cairo.Format.Argb32,
					image.Width, image.Height,
					4 * image.Width * image.Height);

			surface.MarkDirty();
			cr.SetSourceSurface(surface, 0, 0);
			cr.Paint();*/

			/*SKCanvasView canvasView = new SKCanvasView();
			canvasView.PaintSurface += OnCanvasViewPaintSurface;


			Xamarin.Forms.Image image = new Xamarin.Forms.Image();*/
		}

		public SKImage CreatDrowArea()
		{

			try
			{
				using (var skSurface = SKSurface.Create(100, 100, SKColorType.Rgba1010102, SKAlphaType.Premul))
				{
					var canvas = skSurface.Canvas;
					var paint = new SKPaint
					{
						StrokeWidth = 4,
						Color = new SKColor(0, 132, 132, 255)
					};
					var rect = new SKRect(10, 10, 80, 80);
					canvas.DrawRect(rect, paint);
					return skSurface.Snapshot();
				}
			}
			catch (Exception ex)
			{

			}
			return null;
			
		}
	}
}

