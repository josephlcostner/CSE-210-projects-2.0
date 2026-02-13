using System;
using BreathingExcersise;
using Choice;
using List;


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
                return false;
            case "2":
            Reflection prompts = new Reflection();
            prompts.Run2();
                return false;
            case "3":
                ListingActivity list = new ListingActivity();
                list.Run3();
                return false;
            case "4":
                return false;
            default:
                return true;

        }
    }
}