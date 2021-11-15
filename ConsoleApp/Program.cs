using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ClassLibrary.UtilityHelloWorld.HelloWorld(args.Length > 0 ? args[0] : null));
        }
    }
}
