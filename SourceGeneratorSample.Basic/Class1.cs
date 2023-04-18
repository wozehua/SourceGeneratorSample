namespace SourceGeneratorSample.Basic;


/// <summary>
/// ISourceGenerator 要引用 microsoft.codeanalysis.common
/// 表示一个源代码生成器，生成一个类型，自带一个打招呼的方法。
/// </summary>
/// <remarks>
/// 备注，summary东西太多可以写在备注中。
/// </remarks>
[Generator(LanguageNames.CSharp)]
public sealed class GreetingGenerator : ISourceGenerator
{
    //inheritdoc 文档注释,给类型成员提供文字信息。
    //inheritdoc 这个使用的是基类派生下来的文档注释。
    /// <inheritdoc/>
    public void Execute(GeneratorExecutionContext context)
    {
        context.AddSource("Greeting.g.cs",
    $$"""
    public static class Greeting
    {
        public static void SayHelloTo(string name)=>Console.WriteLine($"Hello,{name}{{nameof(context   )}}");
    }
    """);
    }

    /// <inheritdoc/>
    public void Initialize(GeneratorInitializationContext context)
    {
        
    }
}

