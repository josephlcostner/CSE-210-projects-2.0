using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
namespace List
{
    public class ListingActivity
    {
        public void Run3()
        {
            

            Console.WriteLine("Welcome to the Listing Activity.");
            Console.ReadLine();


            
            for (int i = 1; i > 0; i--)
            {

            List<string> prompts2 = new List<string>
            {
              "Who are the people that you appreciate?",
              "What are personal strengths of yours?",
              "Who are people that you have helped this week?",
              "When have you felt the Holy Ghost this month?",
              "Who are some of your personal heros?"  
            };
            Random random = new Random();
            int randomIndex = random.Next(0, prompts2.Count);
            string randomPrompt = prompts2[randomIndex];
            Console.WriteLine(randomPrompt);
            Thread.Sleep(10000);

            List<string> inputsList = new List<string>();
            string input = "";
             do
                {
                    input = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(input))
                    {
                        inputsList.Add(input);
                    }
                }
                while (!string.IsNullOrWhiteSpace(input));

                
                {
                    foreach (string item in inputsList)
                    {
                        Console.WriteLine($"{item}");
                    }
                }
            
            

            
                 Console.Write("-");
            Thread.Sleep(1000);
            Console.Write("/");
            Thread.Sleep(1000);
            Console.Write("|");
            Thread.Sleep(1000);
            Console.Write("\\");
            Thread.Sleep(1000);
            Console.Write("-");

              Console.WriteLine("Do you like PB & J's?");
            String answerNow = Console.ReadLine();

            if (answerNow == "yes")
                {
                    Console.WriteLine("Welcome to the club, we've been waiting for you!");
                } 
            else if (answerNow == "no")
                {
                    Console.WriteLine("What is wrong with you!");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
                Thread.Sleep(5000);
            Console.Clear();

            
            
           
            
            Console.WriteLine("Good Job.");
        }
    }
}
}