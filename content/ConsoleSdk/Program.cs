#if (csharpFeature_TopLevelProgram)
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
#else
namespace ConsoleSdk;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
#endif
