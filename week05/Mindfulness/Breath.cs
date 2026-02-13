using System;
using System.Timers;
using static System.Console;
using System.Threading;
using System.Data;

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
                
            }
        
        
             
            
            
        
    
    

   
    Console.Clear();
    Console.WriteLine("Good Job.");
            }
        }
    }


