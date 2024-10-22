using System;

public class CustomerStore : Customer // herança
{


    // constructor 
    public CustomerStore(string name, string address, DateTime birthday)
    {
        Name = name;
        Address = address;
        Birthday = birthday;
    }
}