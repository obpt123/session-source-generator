using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SingletonPattern
{
    [Generator]
    public class SingletonGenerator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {

            context.RegisterForSyntaxNotifications(() => new SingletonPatternSyntaxReceiver());
        }

        public void Execute(GeneratorExecutionContext context)
        {
            if (!(context.SyntaxReceiver is SingletonPatternSyntaxReceiver receiver))
                return;
            //System.Diagnostics.Debugger.Launch();
            var compilation = context.Compilation;
            foreach (var classSyntax in receiver.CandidateClasses)
            {
                var semanticModel = compilation.GetSemanticModel(classSyntax.SyntaxTree);
                var classSymbol = semanticModel.GetDeclaredSymbol(classSyntax);
                if (HasSingletonAttribute(classSymbol))
                {
                    var code = BuildCSharpCode(classSymbol);
                    context.AddSource($"{classSymbol.Name}.cs", code);
                }
            }

        }
        private bool HasSingletonAttribute(INamedTypeSymbol classSymbol)
        {
            return classSymbol.GetAttributes()
             .Any(x => x.AttributeClass?.Name == nameof(SingletonAttribute));
        }
        private string BuildCSharpCode(INamedTypeSymbol classSymbol)
        {

            string namespaceName = classSymbol.ContainingNamespace.ToDisplayString();
            string className = classSymbol.Name;

            return $@"
using System;
namespace {namespaceName}
{{
    partial class {className}
    {{
        private static readonly Lazy<{className}> LazyInstance = new Lazy<{className}>(() => new {className}(), true);

        private {classSymbol.Name}() {{ }}

        public static {className} Instance => LazyInstance.Value;

    }}
}}";
        }

        private class SingletonPatternSyntaxReceiver : ISyntaxReceiver
        {
            public IList<ClassDeclarationSyntax> CandidateClasses { get; } = new List<ClassDeclarationSyntax>();

            public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
            {
                if (syntaxNode is ClassDeclarationSyntax classDeclarationSyntax &&
                    !classDeclarationSyntax.Modifiers.Any(SyntaxKind.StaticKeyword) &&
                    classDeclarationSyntax.AttributeLists.Any())
                {
                    CandidateClasses.Add(classDeclarationSyntax);
                }
            }
        }
    }



}
