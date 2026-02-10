using System;
using BreathingExcersise;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        bool showMenu = true;
        while (showMenu)
        {
            showMenu = MainMenu();
        }
    }
    private static bool MainMenu()
    {
        Console.Clear();
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");
        Console.Write("Please choose an option: ");

        switch (Console.ReadLine())
        {
            case "1":
                Breath breathing = new Breath();
                breathing.Run();
                return true;
            case "2":
                return true;
            case "3":
                return true;
            case "4":
                break;
            default:
                return true;

        }
    }
}