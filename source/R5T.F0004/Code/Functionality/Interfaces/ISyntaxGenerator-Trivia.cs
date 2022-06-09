using System;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using SyntaxFactory = Microsoft.CodeAnalysis.CSharp.SyntaxFactory;


namespace R5T.F0004
{
    public partial interface ISyntaxGenerator
    {
        //public SyntaxTrivia DocumentationCommentExterior(string text)
        //{
        //    var output = SyntaxFactory.DocumentationCommentTrivia.DocumentationCommentExterior(text);
        //    return output;
        //}

        public SyntaxTrivia EndOfLine(string endOfLineText)
        {
            var output = SyntaxFactory.EndOfLine(endOfLineText);
            return output;
        }

        /// <summary>
        /// Uses the <see cref="Environment.NewLine"/> value.
        /// </summary>
        public SyntaxTrivia EndOfLine_Environment()
        {
            var output = this.EndOfLine(Environment.NewLine);
            return output;
        }

        public SyntaxTrivia EndOfLine_Windows()
        {
            var output = this.EndOfLine(Instances.Strings.NewLine_Windows);
            return output;
        }

        public SyntaxTrivia EndOfLine_NonWindows()
        {
            var output = this.EndOfLine(Instances.Strings.NewLine_NonWindows);
            return output;
        }

        /// <summary>
        /// Chooses <see cref="EndOfLine_Environment()"/> as the default.
        /// </summary>
        public SyntaxTrivia EndOfLine()
        {
            var output = this.EndOfLine_Environment();
            return output;
        }

        /// <summary>
        /// Note, new line is the same as <see cref="EndOfLine()"/>.
        /// </summary>
        public SyntaxTrivia NewLine()
        {
            var output = this.EndOfLine();
            return output;
        }

        public SyntaxTrivia Space()
        {
            var output = SyntaxFactory.Space;
            return output;
        }

        public SyntaxTrivia Tab()
        {
            var output = SyntaxFactory.Tab;
            return output;
        }

        public SyntaxTrivia Trivia(StructuredTriviaSyntax structuredTrivia)
        {
            var output = SyntaxFactory.Trivia(structuredTrivia);
            return output;
        }
    }
}
