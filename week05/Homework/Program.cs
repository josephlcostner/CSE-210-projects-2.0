using System;
namespace math_demo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Math math1 = new Math();
        math1.GetStudent("Samuel Bennett");
        math1.GetAssignment("Multiplication");
        Console.WriteLine(math1.GetSummary());

    }
}
