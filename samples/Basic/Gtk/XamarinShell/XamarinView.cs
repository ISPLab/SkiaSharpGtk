using System;

using Xamarin.Forms;

namespace XamarinShell
{
	public class XamarinView : ContentPage
	{
		public XamarinView()
		{
			
			Content = new ContentWithSkiaView();
		}
	}
}

