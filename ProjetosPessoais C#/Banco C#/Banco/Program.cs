// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Bank b1 = new Bank("Julio", 5544);

b1.deposit(50);
Console.WriteLine(b1.Balance);
b1.deposit(1000);
Console.WriteLine(b1.Balance);
