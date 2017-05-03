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

		private void Lesson1Button_OnClick(object sender, RoutedEventArgs e) {
			Frame.Navigate(typeof(GamePage));
			NavigatedToSourceCodePage?.Invoke(this, new NavigatedToSourceCodePageEventArgs(1));
		}

		public event EventHandler<NavigatedToSourceCodePageEventArgs> NavigatedToSourceCodePage;
	}
}
