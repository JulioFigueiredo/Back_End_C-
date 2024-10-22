using System;
using System.Collections.Generic;

public class StockManager
{
    public List<Product> Products = new List<Product>();

    public void AddProduct(string name, double price)
    {
        Product product = new Product(name, price);
        Products.Add(product); 
    }

    public bool RemoveProduct(string name)
    {
        foreach (var product in Products)
        {
            if (product.Name.Contains(name))
            {
                Products.Remove(product);
                return true;
            }
        }
        return false;
    }

    public string SearchProduct(string name)
    {
        foreach (var product in Products)
        {
            if (product.Name.Contains(name))
            {
                Console.WriteLine($"O Produto {product.Name} com o preço R$ {product.Price} está disponível.");
                return $"{product.Name} - R$ {product.Price}";
            }
        }
        Console.WriteLine($"Produto {name} não encontrado.");
        return "nao encontrado";
    }

    public void ListAllProducts()
    {
        foreach (var product in Products)
        {
            Console.WriteLine(product);
        }
    }
}
