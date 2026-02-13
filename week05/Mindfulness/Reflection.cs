using System;

namespace Choice
{
    public class Reflection
    {
        public void Run2()
        {

            
            {



            Console.WriteLine("Welcome to the reflection activity.");
            Console.ReadLine();
            for (int i = 1; i > 0; i--)
            {
            List<string> prompts = new List<string>
            {
                "Think of a time when you stood up for something else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need",
                "Think of a time when you did something truly selfless"

            };
            Random random = new Random();
            int randomIndex = random.Next(0, prompts.Count);
            string randomPrompt = prompts[randomIndex];
            Console.WriteLine(randomPrompt);

              List<string> prompts2 = new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"  
            };
            Random random1 = new Random();
            int randomIndex1 = random1.Next(0, prompts2.Count);
            string randomPrompt1 = prompts2[randomIndex1];
            Console.WriteLine(randomPrompt1);
            Thread.Sleep(10000);

            
            
           
                {
            
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("1");
            Thread.Sleep(1000);
              Console.WriteLine("Do you like butterbeer?");
            String answerNow = Console.ReadLine();

            if (answerNow == "yes")
                {
                    Console.WriteLine("Better be... Griffindor!!!!");
                } 
            else if (answerNow == "no")
                {
                    Console.WriteLine("Slytherin");
                }
                else
                {
                    Console.WriteLine("Very difficult...");
                }
                Thread.Sleep(5000);
            Console.Clear();
                }
                Console.Clear();
                Console.Write("Good Job.");
            }
            }
        }
    }
}
            
                
        
    


