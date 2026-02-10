using System;
using System.Timers;
using static System.Console;
using System.Threading;

    class Breath
{
    static int countdownTime = 30;
    private static Count timer;
    
    static void Main(string[] args)
    {
        StartCountdown();
        Console.WriteLine("Welcome to the breathing activity.");
        Console.ReadLine();
    }
    static void StartCountdown()
    {
        timer = new Count(1000);
        
        timer.AutoReset = true;
        timer.Enabled = true;

        while ()
    }

}
