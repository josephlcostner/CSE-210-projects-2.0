using System;
using System.Security.Cryptography.X509Certificates;
using Product;
using Customer;
using Address;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Person customer = new Person();
        customer.Identity();
        Home home = new Home();
        home.House();
        Products products = new Products();
        products.Food();
    }
    
        
}

