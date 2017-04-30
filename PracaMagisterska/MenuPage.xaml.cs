using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace PracaMagisterska {
	public sealed partial class MenuPage : Page {
		public MenuPage() {
			this.InitializeComponent();
		}

		private void HamburgerButton_OnClick(object sender, RoutedEventArgs e) =>
			HamburgerSplitView.IsPaneOpen = !HamburgerSplitView.IsPaneOpen;

		private void HamburgerListBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e) {
			if ( HamburgerSplitView.IsPaneOpen ) HamburgerSplitView.IsPaneOpen = false;

			if ( PlayListBoxItem.IsSelected ) {
				MainFrame.Navigate(typeof(GamePage));
			} else if ( SettingsListBoxItem.IsSelected ) {
				//MainFrame.Navigate(typeof(SettingsPage));
			} else if ( CreditsListBoxItem.IsSelected ) {
				MainFrame.Navigate(typeof(CreditsPage));
			}
		}
	}
}
