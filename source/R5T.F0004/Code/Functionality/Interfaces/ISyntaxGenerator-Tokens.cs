using System;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;


using SyntaxFactory = Microsoft.CodeAnalysis.CSharp.SyntaxFactory;


namespace R5T.F0004
{
    public partial interface ISyntaxGenerator
    {
        public SyntaxToken Abstract()
        {
            var output = SyntaxFactory.Token(SyntaxKind.AbstractKeyword);
            return output;
        }

        public SyntaxToken Async()
        {
            var output = SyntaxFactory.Token(SyntaxKind.AsyncKeyword);
            return output;
        }

        public SyntaxToken Const()
        {
            var output = SyntaxFactory.Token(SyntaxKind.ConstKeyword);
            return output;
        }

        public SyntaxToken Extern()
        {
            var output = SyntaxFactory.Token(SyntaxKind.ExternKeyword);
            return output;
        }

        public SyntaxToken Internal()
        {
            var output = SyntaxFactory.Token(SyntaxKind.InternalKeyword);
            return output;
        }

        public SyntaxToken Override()
        {
            var output = SyntaxFactory.Token(SyntaxKind.OverrideKeyword);
            return output;
        }

        public SyntaxToken Partial()
        {
            var output = SyntaxFactory.Token(SyntaxKind.PartialKeyword);
            return output;
        }

        public SyntaxToken Private()
        {
            var output = SyntaxFactory.Token(SyntaxKind.PrivateKeyword);
            return output;
        }

        public SyntaxToken Protected()
        {
            var output = SyntaxFactory.Token(SyntaxKind.ProtectedKeyword);
            return output;
        }

        public SyntaxToken Public()
        {
            var output = SyntaxFactory.Token(SyntaxKind.PublicKeyword);
            return output;
        }

        public SyntaxToken ReadOnly()
        {
            var output = SyntaxFactory.Token(SyntaxKind.ReadOnlyKeyword);
            return output;
        }

        public SyntaxToken Sealed()
        {
            var output = SyntaxFactory.Token(SyntaxKind.SealedKeyword);
            return output;
        }

        public SyntaxToken Static()
        {
            var output = SyntaxFactory.Token(SyntaxKind.StaticKeyword);
            return output;
        }

        public SyntaxToken Unsafe()
        {
            var output = SyntaxFactory.Token(SyntaxKind.UnsafeKeyword);
            return output;
        }

        public SyntaxToken Virtual()
        {
            var output = SyntaxFactory.Token(SyntaxKind.VirtualKeyword);
            return output;
        }

        public SyntaxToken Volatile()
        {
            var output = SyntaxFactory.Token(SyntaxKind.VolatileKeyword);
            return output;
        }
    }
}
