﻿using System;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Animation;

namespace Uno.UI.Demo.Behaviors
{
	[Bindable]
	public static class DynamicAnimation
    {
#if !WINDOWS_UWP
		[Preserve]
#endif
		public static readonly DependencyProperty StoryboardProperty = DependencyProperty.RegisterAttached(
			"Storyboard", typeof(Storyboard), typeof(DependencyObject), new PropertyMetadata(default(Storyboard), OnStoryBoardChanged));

		private static void OnStoryBoardChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			(e.OldValue as Storyboard)?.Stop();
			if (e.NewValue is Storyboard storyboard)
			{
				foreach (var timeline in storyboard.Children)
				{
					Storyboard.SetTarget(timeline, d);
				}

				d.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
				{
					try
					{
						storyboard.Begin();
					}
					catch (Exception err)
					{
						Console.Error.WriteLine("Failed to start storyboard: " + err);
					}
				});
			}
		}

#if !WINDOWS_UWP
		[Preserve]
#endif
		public static Storyboard GetStoryboard(DependencyObject target)
			=> (Storyboard) target.GetValue(StoryboardProperty);

#if !WINDOWS_UWP
		[Preserve]
#endif
		public static void SetStoryboard(DependencyObject target, Storyboard value)
			=> target.SetValue(StoryboardProperty, value);
	}
}
