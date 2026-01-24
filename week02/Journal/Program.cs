using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Prompt;
using System.Text;
using System.Collections.Generic;
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
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            Console.WriteLine(dateText);
            
            string randomPrompt = PromptGenerator.GetRandomPrompt();
            Console.WriteLine(randomPrompt);
            
            Console.Write("> ");
            
            Console.ReadLine();
             string dataToSave = "";
            File.WriteAllText("Journal.txt", dataToSave);
            
            }
        else if (choice == "2")
        {
        StringBuilder sb = new StringBuilder();
        string result = sb.ToString();
        Console.WriteLine(result);
        }
        else if (choice == "3")
        {
            
        
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
           break;
            }
        }
    }
}
     

