using System;
using Uno.SourceGeneration;

namespace MyGenerator
{
    public class MyCustomSourceGenerator : SourceGenerator
    {
        public override void Execute(SourceGeneratorContext context)
        {
            var project = context.GetProjectInstance();

            context.AddCompilationUnit("Test", "namespace MyGeneratedCode { public class TestGeneration { } }");
        }
    }
}