using System;

using Microsoft.CodeAnalysis;


namespace R5T.F0004
{
    public partial interface ISyntaxGenerator
    {
        public SyntaxAnnotation Annotation()
        {
            var output = new SyntaxAnnotation();
            return output;
        }
    }
}
