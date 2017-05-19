using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Text;
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
			InitializeComponent();

			ITextDocument doc = SourceCodeTexBox.Document;
			ITextRange range = doc.GetRange(2, 3);
			range.CharacterFormat.ForegroundColor = Colors.Red;
			SourceCodeTexBox.Document.ApplyDisplayUpdates();
		}

		protected override void OnNavigatedFrom(NavigationEventArgs e) {
			SourceCodeTexBox.PlaceholderText = "Lekcja " + (int?)e?.Parameter + ".";
		}

		public void Compile() {
			
		}

		private void SourceCodeTexBox_OnTextChanged(object sender, RoutedEventArgs e) {
			ITextDocument document = SourceCodeTexBox.Document;

			document.GetText(TextGetOptions.UseCrlf, out string plainText);
			document.GetText(TextGetOptions.FormatRtf, out string rtfText);

			int idx = -1;
			while ( true ) {
				idx = plainText.IndexOf("for", idx == -1 ? 0 : idx);

				if ( idx == -1 ) break;

				ITextRange range = document.GetRange(idx, idx + 3);
				if ( range.CharacterFormat.ForegroundColor != Colors.Blue )
					range.CharacterFormat.ForegroundColor = Colors.Blue;

				document.ApplyDisplayUpdates();
			}

			idx = -1;
			while ( true ) {
				idx = plainText.IndexOf("if", idx == -1 ? 0 : idx);

				if (idx == -1) break;

				ITextRange range = document.GetRange(idx, idx + 2);
				if ( range.CharacterFormat.ForegroundColor != Colors.Red )
					range.CharacterFormat.ForegroundColor = Colors.Red;

				document.ApplyDisplayUpdates();
			}

			SourceCodeTexBlock.Text = plainText + "\n\n" + rtfText;

			//SourceCodeTexBox.Document.SetText(TextSetOptions.FormatRtf, newRtfText);
		

			/*{\colortbl;\red0\green0\blue0;\red255\green0\blue0; }
			This line is the default color\line
				\cf2
				This line is red\line
				\cf1
				This line is the default color
			}*/
		}
	}
}
