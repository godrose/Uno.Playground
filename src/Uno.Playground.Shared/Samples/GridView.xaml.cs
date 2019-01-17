using System.Linq;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236  

namespace Uno.UI.Demo.Samples
{
	public sealed partial class GridView : UserControl
	{
		public GridView()
		{
			this.InitializeComponent();
			
			gridView.ItemsSource = Enumerable
				.Range(0, 1000)
				.ToArray();
		}
	}
}
