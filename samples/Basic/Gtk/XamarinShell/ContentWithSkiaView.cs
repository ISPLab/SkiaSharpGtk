using System;

using Xamarin.Forms;

namespace XamarinShell
{
	public class ContentWithSkiaView : ContentView
	{
		public ContentWithSkiaView()
		{
			StackLayout stack = new StackLayout();
			var label = new Label { Text = "Text Label from Xamarin" };
			var t = label.GetType();
			stack.Children.Add(label);
			var ima = new SkiaView();
			stack.Children.Add(ima);
			Content = ima;
		}
	}
}

