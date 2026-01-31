using System;
using System.Net.Quic;
using Scriptures;
using System.Text.RegularExpressions;
using System.Diagnostics;
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
        
        string userinput = "";
        while (userinput != "quit")
        {
            if (userinput == "")
            {
               
            }
            else
            {
                break;
            }
        }
    }
    
    
}