---
presentation:
    theme: night.css
---

<!-- slide -->
#  Source Generator

<!-- slide -->

1. Source Generator简介

1. 存在的意义

1. Demo演示

1. 实际应用场景

1. 开发注意事项

<!-- slide -->
## 1. Source Generator简介


<!-- slide -->

> **Source Generators is a C# compiler feature that lets C# developers inspect user code as it is being compiled and generates new C# source files on the fly that are added to the user's compilation.**

> *Source Generator是一项 C# 编译器功能，使 C# 开发人员能够在编译用户代码时进行检查，并动态生成新的 C# 源文件，以添加到用户的编译中***

<!-- slide -->
<img src="https://docs.microsoft.com/zh-cn/dotnet/csharp/roslyn-sdk/media/source-generators/source-generator-visualization.png">

<!-- slide -->
## 2. 存在的意义
<!-- slide -->
- Code Smith
- T4
- Dynamic code
- Expression
- IL Emit
<!-- slide -->
## 3. Demo演示

<!-- slide -->
- Hello, World
- Singleton Pattern

<!-- slide -->
## 4. 实际应用场景
<!-- slide -->
- ### Singleton Pattern
- ### Auto Constructor
- ### Convert To
- ### Log Message
- ### Others ...

<!-- slide -->
## 5. 开发注意事项
1. 开发态的引用
    - net standard 2.0 
    - Microsoft.CodeAnalysis.CSharp (3.9.0)
    - Microsoft.CodeAnalysis.Analyzers(3.0.0)
1. 开发Source Generator
    - partial
    - 泛型类
    - 继承类
    - 命名空间
1. 如何调试
    - OutputItemType="Analyzer"
    - Launcher
    - Show generated code
    - Unit test  
<!-- slide -->
学习链接


- [Source&nbsp;Generators](https://github.com/dotnet/roslyn/blob/main/docs/features/source-generators.md)

- [Source&nbsp;Generators&nbsp;Overview](https://docs.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/source-generators-overview)

- [Introducing&nbsp;C#&nbsp;Source&nbsp;Generators](https://devblogs.microsoft.com/dotnet/introducing-c-source-generators/)

- [Source&nbsp;Generators&nbsp;in&nbsp;.NET&nbsp;5&nbsp;with&nbsp;ReSharper](https://blog.jetbrains.com/dotnet/2020/11/12/source-generators-in-net-5-with-resharper/)


- [C#&nbsp;Source&nbsp;Generators](https://channel9.msdn.com/Shows/On-NET/C-Source-Generators)

- [C#&nbsp;Source&nbsp;Generators&nbsp;In&nbsp;Action](https://www.youtube.com/watch?v=052xutD86uI)

<!-- slide -->
# Thank You