using System;
using System.IO;
using Prompt;
class Program
{
    static void Main(string[] args)
    {
         
        
         string choice = "";
         while (choice != "5")
         {
        Console.WriteLine("Hello World! This is the Journal Project.");
          Console.WriteLine("1.Write");  
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Save");
            Console.WriteLine("4.Load");
            Console.WriteLine("5.Quit");

            Console.WriteLine($"Please input a number from 1-5 to continue with your journal: ");
            
            
            choice = Console.ReadLine();
           
         
        

        if (choice == "1")
            {
            string randomPrompt = PromptGenerator.GetRandomPrompt();
            Console.WriteLine(randomPrompt);
            Console.Write("> ");
            Console.ReadLine();
            }
        else if (choice == "2")
        {
            Console.Write(">");
            Console.ReadLine();
        }
        else if (choice == "3")
        {
            string dataToSave = "";
            File.WriteAllText("Journal.txt", dataToSave);
        
        }
        else if (choice == "4")
        {
            if (File.Exists("Journal.txt"))
                {
                    string loadedData = File.ReadAllText("Journal.txt");
                    Console.WriteLine("Loaded:" + loadedData);
                }
        }
        else if (choice == "5")
        {
            break;
        }
        else 
            {
           Console.WriteLine("This is not a correct number.") ;
            }
        }
    }
}
     

