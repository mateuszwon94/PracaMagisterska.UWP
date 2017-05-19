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
using PracaMagisterska.EventArgs;

namespace PracaMagisterska {
	public sealed partial class MenuPage : Page {
		public MenuPage() {
			InitializeComponent();
		}

		private void HamburgerButton_OnClick(object sender, RoutedEventArgs e) =>
			HamburgerSplitView.IsPaneOpen = !HamburgerSplitView.IsPaneOpen;

		private void HamburgerListBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e) {
			if ( HamburgerSplitView.IsPaneOpen ) HamburgerSplitView.IsPaneOpen = false;

			if ( PlayListBoxItem.IsSelected ) {
				MainFrame.Navigate(typeof(GameMenuPage));
				if ( MainFrame.Content is GameMenuPage gameMenuPage )
					gameMenuPage.NavigatedToSourceCodePage += GameMenuPageOnNavigatedToSourceCodePage;
			} else if ( SettingsListBoxItem.IsSelected ) {
				//MainFrame.Navigate(typeof(SettingsPage));
			} else if ( CreditsListBoxItem.IsSelected ) {
				MainFrame.Navigate(typeof(CreditsPage));
			}
		}

		private void GameMenuPageOnNavigatedToSourceCodePage(object sender, NavigatedToSourceCodePageEventArgs e) {
			PlayListBoxItem.IsSelected = false;
		}

		private void GameListBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e) {
			if ( MainFrame.Content is GamePage gamePage ) {
				if ( CompileBoxItem.IsSelected ) {
					CompileBoxItem.IsSelected = false;
				} else if ( RunListBoxItem.IsSelected ) {
					RunListBoxItem.IsSelected = false;
				}
			}
		}

		private void MainFrame_OnNavigated(object sender, NavigationEventArgs e) {
			if ( GameSeparator != null ) GameSeparator.Visibility = Visibility.Collapsed;
			if ( GameListBox != null )   GameListBox.Visibility = Visibility.Collapsed;


			if ( e.Content is GamePage ) {
				GameSeparator.Visibility = Visibility.Visible;
				GameListBox.Visibility = Visibility.Visible;
			}
		}
	}
}
