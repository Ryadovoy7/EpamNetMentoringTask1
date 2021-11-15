using System;

namespace ClassLibrary
{
    public class UtilityHelloWorld
    {
        public static string HelloWorld (string name) => $"{System.DateTime.Now} Hello, {name}!";
    }
}
