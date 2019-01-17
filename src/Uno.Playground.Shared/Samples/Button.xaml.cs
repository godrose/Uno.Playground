using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Uno.UI.Demo.Samples
{
    public sealed partial class Button : UserControl
    {
        public Button()
        {
            this.InitializeComponent();
        }

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			var button = sender as Windows.UI.Xaml.Controls.Button;
			var count = button.Tag as int? ?? 0;
			count++;
			button.Tag = count;
			button.Content = $"Clicked {count}"; 
		}
	}
}
