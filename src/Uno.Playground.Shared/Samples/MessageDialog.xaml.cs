using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Uno.UI.Demo.Samples
{
	public sealed partial class MessageDialog : UserControl
	{
		public MessageDialog()
		{
			this.InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			var messageDialog = new Windows.UI.Popups.MessageDialog("Hello world!");
			messageDialog.ShowAsync();
		}

		private void Button_Click2(object sender, RoutedEventArgs e)
		{
			var messageDialog = new Windows.UI.Popups.MessageDialog("This is a very important message.", "Notice");
			messageDialog.ShowAsync();
		}

		private void Button_Click3(object sender, RoutedEventArgs e)
		{
			var messageDialog = new Windows.UI.Popups.MessageDialog("What is the answer to Life, The Universe and Everything?", "Ultimate Question")
			{
				//CancelCommandIndex = 0,
				Commands =
				{
					new Windows.UI.Popups.UICommand("42"),
					new Windows.UI.Popups.UICommand("Not 42"),
				}
			};
			messageDialog.ShowAsync();
		}
	}
}
