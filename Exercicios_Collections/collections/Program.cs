// See https://aka.ms/new-console-template for more information


using System.Collections;
using System.Runtime.CompilerServices;

Product[] estoque = {
            new Product("tv", 500),
            new Product("geladeira", 800),
            new Product("microondas", 300),
            new Product("fogao", 750),
        };


        for (int i = 0; i < estoque.Length - 1; i++)
        {
            for (int j = i + 1; j < estoque.Length; j++)
            {
                if (estoque[i].Price < estoque[j].Price)
                {
                    Product temp = estoque[i];
                    estoque[i] = estoque[j];
                    estoque[j] = temp;
                }
            }
        }

        Console.WriteLine("Os dois produtos mais caros são:");
        Console.WriteLine($"{estoque[0].Name}");
        Console.WriteLine($"{estoque[1].Name}");
    




