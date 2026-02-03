using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Reflection;
using System.Runtime.CompilerServices;


class Product
{
    static void Main()
    {
    
    List<List<string>> ListOfProduce = new List<List<string>>();
    List<List<int>> listOfPrices = new List<List<int>>();
    string userInput;
  
    Console.WriteLine("Please enter an item, type exit to quit: ");

    while (true)
        {
            Console.Write("Enter item: ");
            userInput = Console.ReadLine();

            if (userInput.ToUpper() == "EXIT")
            {
                break;
            }
            else if (userInput == "")
            {
                string Produce = userInput.Substring(2).Trim();
                if (!string.IsNullOrEmpty(Produce))
                {
                    ListOfProduce.Add(Produce);
                    Console.WriteLine($"{Produce}");
                    string 
                }
                
            }
        }
    
    }
    
}
