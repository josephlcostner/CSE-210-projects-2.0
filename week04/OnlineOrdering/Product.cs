using System;
using System.Collections.Generic;
using System.IO.Pipes;


public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
}

List<Product> products = new List<Product>
{
    new Product { Name = "Apples", Price = 6.99},
    new Product { Name = "Bananas", Price = 5.99}
};
