using System;
using ClassLibrary;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = args.Length > 0 ? args[0] : null;
            var helloStr = UtilityHelloWorld.HelloWorld(name);
            Console.WriteLine(helloStr);
        }
    }
}
