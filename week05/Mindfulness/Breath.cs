using System;
using System.Timers;
using static System.Console;
using System.Threading;

namespace BreathingExcersise
{
    public class Breath
    {
        public void Run()
        {
            
        
             int countdownTime = 5;
            
            {
        Console.WriteLine("Welcome to the breathing activity.");
        Console.ReadLine();
    
    

    while (countdownTime > 0)
                {
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Console.Clear();
            Console.WriteLine("Breath in...");
            Thread.Sleep(5);
            Console.WriteLine("Breath out...");
            Thread.Sleep(5);
                }
    Console.Clear();
    Console.WriteLine("Good Job.");
            }
        }
    }
}

