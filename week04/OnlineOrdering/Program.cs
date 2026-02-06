using System;
using System.Security.Cryptography.X509Certificates;
using Product;
using Customer;
using Address;
using Order;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Person customer = new Person();
        customer.Identity();
        Home home = new Home();
        home.House();
        Choice Choice = new Choice();
        Choice.Items();
        Products products = new Products();
        products.Food();
    }
    
        
}

