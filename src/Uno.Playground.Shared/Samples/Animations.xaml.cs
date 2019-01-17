﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Uno.UI.Demo.Samples
{
    public sealed partial class Animations : UserControl
    {
        public Animations()
        {
            this.InitializeComponent();
			VisualStateManager.GoToState(this, "NotAnimated", false);
        }

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			// Make sure we change state to allow for the button to work more than once.
			VisualStateManager.GoToState(this, "NotAnimated", false);
			VisualStateManager.GoToState(this, "Animated", true);
		}
	}
}
