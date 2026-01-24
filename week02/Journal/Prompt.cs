using System;

    namespace Prompt{
        public static class PromptGenerator
    {
        private static readonly string[] _prompts =
    
        {
            "Who was the most interesting person you interacted with today?",
            "How did I see thhe hand of the Lord in my life today?",
            "What was the best part of my day?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do all over again today, what would it be?"
        };
        private static readonly Random _random = new Random();
        public static string GetRandomPrompt()
        {
            int index = _random.Next(_prompts.Length);
            return _prompts[index];
        }
    
    
    
        
    }
}