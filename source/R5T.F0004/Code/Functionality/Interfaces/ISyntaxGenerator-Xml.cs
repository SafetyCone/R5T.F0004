using System;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using SyntaxFactory = Microsoft.CodeAnalysis.CSharp.SyntaxFactory;


namespace R5T.F0004
{
    public partial interface ISyntaxGenerator
    {
        public XmlElementSyntax XmlSummaryElementOnly()
        {
            var output = SyntaxFactory.XmlSummaryElement();
            return output;
        }

        public SyntaxToken XmlTextLiteral(string text)
        {
            var output = SyntaxFactory.XmlTextLiteral(text);
            return output;
        }
    }
}
