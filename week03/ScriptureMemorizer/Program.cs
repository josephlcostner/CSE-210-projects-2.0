using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        string scriptureQuote = File.ReadAllText("Scriptures.cs");
        Console.WriteLine(scriptureQuote);
    }
    
}