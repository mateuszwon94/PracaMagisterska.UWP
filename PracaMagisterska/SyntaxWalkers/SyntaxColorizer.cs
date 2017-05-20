using System;
using Windows.UI.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace PracaMagisterska.SyntaxWalkers {
	public class SyntaxColorizer : CSharpSyntaxWalker {
		public SyntaxColorizer(ITextDocument document) : base(SyntaxWalkerDepth.StructuredTrivia) {
			Document = document;
		}

		public override void VisitToken(SyntaxToken token) {
			base.VisitToken(token);

			if ( token.IsKeyword() || token.IsContextualKeyword() ) {
				//token.
			}
		}

		public void Visit() {
			SyntaxTree tree = CSharpSyntaxTree.ParseText(Code);
			base.Visit(tree.GetRoot());
		}

		public string Code {
			get {
				if ( string.IsNullOrEmpty(code_) ) 
					Document.GetText(TextGetOptions.UseLf, out code_);

				return code_;
			}
		}

		public ITextDocument Document { get; private set; }

		private string code_;
	}
}