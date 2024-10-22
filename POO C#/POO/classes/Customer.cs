using System;
using System.Reflection.Metadata.Ecma335;


public class Customer
{
    // prop + tab
    public string Name { get; set; } = Name;
    public string Address { get; set; } = Address;
    public DateTime Birthday { get; set; }

    // Constructor
    // ctor + tab cria o construtor
    /*
    public Customer(string name, string address, DateTime birthday)
    {
        Name = name;
        Address = address;
        Birthday = birthday;
    }
    */

    public void SendWelcomeKit()
    {
        Console.WriteLine("Welcome, " + Name + ", How are you?");
    }
}