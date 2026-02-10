using System;

namespace Choice
{
    public class RandomPrompts
    {
        static void Main()
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
        }
    }
}

