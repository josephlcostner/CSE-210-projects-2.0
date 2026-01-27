using System;
using Scriptures;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        {
            string _quote = File.ReadAllText("Scriptures.cs");
        Console.WriteLine(_quote);
        }
        {
            string _quotes = File.ReadAllText("Scriptures.cs");
            Console.WriteLine(_quotes);
        }
    }
    
    
}