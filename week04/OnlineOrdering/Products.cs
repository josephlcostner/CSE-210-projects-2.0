using System;
using System.Collections.Generic;


public class Products
{
    public string Name { get; set; }
    public int Price { get; set; }
}

List<Product> Products = new List<Product>
{
    new Product { Name = "Apples", Price = 6},
    new Product { Name = "Bananas", Price = 5},
};