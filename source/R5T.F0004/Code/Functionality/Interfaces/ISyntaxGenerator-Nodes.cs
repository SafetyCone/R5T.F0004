using System;
using System.Collections.Generic;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using SyntaxFactory = Microsoft.CodeAnalysis.CSharp.SyntaxFactory;


namespace R5T.F0004
{
    public partial interface ISyntaxGenerator
    {
        //public BaseListSyntax BaseListSyntax(IEnumerable<BaseTypeSyntax> baseTypes)
        //{
        //    var output = SyntaxFactory.BaseList(
        //        SyntaxFactory.SeparatedList()
        //}

        public BaseListSyntax BaseListSyntax(BaseTypeSyntax baseType)
        {
            var output = SyntaxFactory.BaseList(
                SyntaxFactory.SingletonSeparatedList(baseType));

            return output;
        }

        public CompilationUnitSyntax CompilationUnit()
        {
            var output = SyntaxFactory.CompilationUnit();
            return output;
        }

        public ClassDeclarationSyntax Class(string name)
        {
            var output = SyntaxFactory.ClassDeclaration(name);
            return output;
        }

        public IdentifierNameSyntax IdentifierName(string name)
        {
            var output = SyntaxFactory.IdentifierName(name);
            return output;
        }

        public IdentifierNameSyntax Name(string name)
        {
            var output = this.IdentifierName(name);
            return output;
        }

        public NameEqualsSyntax NameEquals(string destinationName)
        {
            var output = SyntaxFactory.NameEquals(destinationName);
            return output;
        }

        public NamespaceDeclarationSyntax Namespace(string namespaceName)
        {
            var name = this.IdentifierName(namespaceName);

            var output = SyntaxFactory.NamespaceDeclaration(name);
            return output;
        }

        public SimpleBaseTypeSyntax SimpleBaseType(string name)
        {
            var type = this.IdentifierName(name);

            var output = this.SimpleBaseType(type);
            return output;
        }

        public SimpleBaseTypeSyntax SimpleBaseType(IdentifierNameSyntax identifierName)
        {
            var output = SyntaxFactory.SimpleBaseType(identifierName);
            return output;
        }

        public UsingDirectiveSyntax Using(NameSyntax name)
        {
            var output = SyntaxFactory.UsingDirective(name)
                .NormalizeWhitespace();

            return output;
        }

        public UsingDirectiveSyntax Using(string namespaceName)
        {
            var name = this.Name(namespaceName);

            var output = this.Using(name);
            return output;
        }

        public UsingDirectiveSyntax Using(
            string destinationName,
            string sourceNameExpression)
        {
            var nameEqualsSyntax = this.NameEquals(destinationName);

            var nameSyntax = this.Name(sourceNameExpression);

            var output = SyntaxFactory.UsingDirective(nameEqualsSyntax, nameSyntax)
                .NormalizeWhitespace();

            return output;
        }
    }
}
