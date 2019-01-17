﻿using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Uno.UI.Demo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SamplePage : Page
    {
        public SamplePage()
        {
            this.InitializeComponent();
        }

		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			base.OnNavigatedTo(e);

			var sampleType = e.Parameter as Type;
			var sampleInstance = Activator.CreateInstance(sampleType) as UserControl;
			var sampleTitle = sampleType.Name;
			
			SampleContent.Content = sampleInstance;
			SampleTitle.Content = sampleTitle;
		}
	}
}
