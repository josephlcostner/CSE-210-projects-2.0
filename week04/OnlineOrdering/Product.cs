using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Pipes;
using System.Reflection;
using System.Runtime.CompilerServices;


class Product
{
    static void Main()
    {
    
    List<string> ListOfProduce = new List<string>();
    List<int> ListOfPrices = new List<int>();
    string price;
  
    Console.WriteLine("Please enter an item, type exit to quit: ");

    while (true)
        {
            Console.Write("Enter item: ");
            string userInput = Console.ReadLine();

            if (userInput.ToUpper() == "EXIT")
            {
                Console.WriteLine($"{ListOfProduce}");
                int totalSum = ListOfPrices.Sum();
                Console.WriteLine($"{totalSum}");
                break;
                
            }
            else if (userInput == "")
            {
                ListOfProduce.Add(userInput);
                Console.Write("Enter the price: ");
                price = Console.ReadLine();
                int.TryParse(price, out int number);
                ListOfPrices.Add(number);
                
            }
        }
    
    }
    
}
