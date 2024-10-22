Account account1 = new Account(2222, "Joao");
Account account2 = new Account(1111, "Maria");
Account account3 = new Account(3333, "Bruno");

Dictionary<string, Account> accounts = new Dictionary<string, Account>();

accounts.Add("b", account1);
accounts.Add("a", account2);
accounts.Add("c", account3);

Console.WriteLine(accounts["a"]);

foreach(string key in accounts.Keys)
{
    Console.WriteLine(accounts[key]);
}