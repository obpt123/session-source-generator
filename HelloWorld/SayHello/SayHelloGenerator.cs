using Microsoft.CodeAnalysis;
using System;

namespace SayHello
{
    [Generator]
    public class SayHelloGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            string source = $@"
using System;

public class Hello
{{
    public static void Say(string name)
    {{
        Console.WriteLine($""Hello {{name}}, I'm from source generator."");
    }}
}}
";
            // add the source code to the compilation
            context.AddSource("generatedSource.cs", source);
            // Code generation goes here
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            // No initialization required for this one
        }
    }
}
