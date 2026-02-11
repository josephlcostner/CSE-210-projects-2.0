using System;

namespace List
{
    public class ListingActivity
    {
        public void Run3()
        {
            int countdownTime2 = 30;

            Console.WriteLine("Welcome to the Listing Activity.");
            Console.ReadLine();

            while (countdownTime2 > 0)
            {
                 Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Console.Clear();

            List<string> prompts2 = new List<string>
            {
              "Who are the people that you appreciate?",
              "What are personal strengths of yours?",
              "Who are people that you have helped this week?",
              "When have you felt the Holy Ghost this month?",
              "Who are some of your personal heros?"  
            };
            }
        }
    }
}