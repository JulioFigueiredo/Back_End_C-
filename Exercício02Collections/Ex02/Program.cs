int option;
StockManager stockManager = new StockManager();

do
{
    Console.WriteLine("Digite uma opção");
    Console.WriteLine("1. - Adicionar Produto");
    Console.WriteLine("2 - Remover Produto");
    Console.WriteLine("3 - Encontrar um produto");
    Console.WriteLine("4 - Listar produtos");
    Console.WriteLine("0 - Sair");

    option = Convert.ToInt32(Console.ReadLine());

    switch(option)
    {
        case 1: 
        Console.WriteLine("Digite o nome do produto");
        string name = Console.ReadLine();
        Console.WriteLine("Digite o preço: ");
        double price = Convert.ToDouble(Console.ReadLine());
        stockManager.AddProduct(name, price);
        Console.WriteLine("Produto cadastrado");
        break;

        case 2:
        Console.WriteLine("Digite o nome do produto");
        name = Console.ReadLine();
        stockManager.RemoveProduct(name);
        Console.WriteLine("Produto removido");
        break;

        case 3:
        Console.WriteLine("Digite o nome do produto");
        name = Console.ReadLine();
        stockManager.SearchProduct(name);
        break;

        case 4:
        stockManager.ListAllProducts();
        break;

        default:
        Console.WriteLine("Opção Inválida");
        break;
    }

}
while (option != 0);



