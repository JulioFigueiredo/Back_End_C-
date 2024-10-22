// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

CustomerStore c1 = new CustomerStore("Júlio", "Sorocba", DateTime.Now);
Console.WriteLine(c1.Name);
CustomerOnline c2 = new CustomerOnline("Fulano", "Rio de Janeiro", DateTime.Now);

c1.SendWelcomeKit();
c2.SendWelcomeKit();