using System;
using Gtk;
using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;
using XamarinShell;

namespace SkiaSharpXamarinSample
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			
			
			Gtk.Application.Init();
			Forms.Init();
			var app = new App();
			var window = new FormsWindow();
			window.LoadApplication(app);
			window.SetApplicationTitle("Window from Xamarin Platform GTK");
			window.ShowAll();
			Gtk.Application.Run();



/*
			Application.Init();
			Xamarin.Forms.Ini
			MainWindow win = new MainWindow();
			win.Show();
			Application.Run();*/
		}
	}
}

