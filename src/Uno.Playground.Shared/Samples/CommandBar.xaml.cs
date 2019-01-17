using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Uno.UI.Demo.Samples
{
	public sealed partial class CommandBar : UserControl
	{
		public CommandBar()
		{
			this.InitializeComponent();
		}

		private bool _isFavorite = false;

		private void Favorite_Click(object sender, RoutedEventArgs e)
		{
			_isFavorite = !_isFavorite;

			var appBarButton = sender as AppBarButton;
			appBarButton.Icon = new BitmapIcon
			{
				UriSource = _isFavorite
					? new Uri("ms-appx:///Assets/Icons/star_full.png")
					: new Uri("ms-appx:///Assets/Icons/star_empty.png")
			};
		}
	}
}
