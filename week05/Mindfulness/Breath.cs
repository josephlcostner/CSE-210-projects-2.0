using System;
using System.Timers;
using static System.Console;
using System.Threading;

namespace BreathingExcersise
{
     class Breath
    {
        int countdownTime = 5;
        public void Run()
        {
            
        
             
            
            {
        Console.WriteLine("Welcome to the breathing activity.");
        StartCountdown();
        Console.ReadLine();
        static void StartCountdown()
                {
                    
                }
    
    

    while (countdownTime > 0)
                {
            
            Console.WriteLine("Breath in...");
            Thread.Sleep(5000);
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Console.Clear();
            Console.WriteLine("Breath out...");
            Thread.Sleep(5000);
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Console.Clear();
                }
    Console.Clear();
    Console.WriteLine("Good Job.");
            }
        }
    }
}

