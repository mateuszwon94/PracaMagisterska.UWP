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
using Microsoft.Graphics.Canvas.UI;
using Microsoft.Graphics.Canvas.UI.Xaml;

namespace PracaMagisterska {

	public sealed partial class GamePage : Page {
		public GamePage() {
			this.InitializeComponent();
		}

		protected override void OnNavigatedFrom(NavigationEventArgs e) {
			SourceCodeTexBox.PlaceholderText = "Lekcja " + (int?)e?.Parameter + ".";
		}

		public void Compile() {
			
		}
	}
}
