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
	public sealed partial class GameMenuPage : Page {
		public GameMenuPage() {
			this.InitializeComponent();
		}

		private void LessonButton_OnClick(object sender, RoutedEventArgs e) {
			if ( sender is Button button ) {
				int lessonNumber = -1;
				switch ( button.Name ) {
					case "Lesson1Button":
						lessonNumber = 1;
						break;
					case "Lesson2Button":
						lessonNumber = 2;
						break;
				}
				Frame.Navigate(typeof(GamePage), lessonNumber);
				NavigatedToSourceCodePage?.Invoke(this, new NavigatedToSourceCodePageEventArgs(lessonNumber));
			}
		}

		public event EventHandler<NavigatedToSourceCodePageEventArgs> NavigatedToSourceCodePage;
	}
}
