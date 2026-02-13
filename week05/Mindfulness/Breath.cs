using System;
using System.Timers;
using static System.Console;
using System.Threading;
using System.Data;
using System.Runtime.CompilerServices;

namespace BreathingExcersise
{
     public class Breath
    {
        
        
        public void Run()
        {
            Console.WriteLine("Welcome to the breathing activity.");
        StartCountdown();
        Console.ReadLine();
        static void StartCountdown()
                {
                    
                }
            for (int i = 5; i > 0; i--)
            {
                 
            
            Console.WriteLine("Breath in...");
            Thread.Sleep(5000);
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("-");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Breath out...");
            Thread.Sleep(5000);
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("-");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Are you dead?!?");
            String answerNow = Console.ReadLine();

            if (answerNow == "yes")
                {
                    Console.WriteLine("Run! It's Frankenstein!!!!!!!!");
                } 
            else if (answerNow == "no")
                {
                    Console.WriteLine("That's a relief!");
                }

            
            }
        
        
             
            
            
        
    
    

   
    Console.Clear();
    Console.WriteLine("Good Job.");
            }
        }
    }


