using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Uno.UI.Demo.Samples
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Form : Page
    {
        public Form()
        {
            this.InitializeComponent();
        }

		private async void OnCheckValues(object sender, RoutedEventArgs e)
		{
			var messageDialog = new Windows.UI.Popups.MessageDialog($"Check was pressed");
			await messageDialog.ShowAsync();
		}
	}
}
