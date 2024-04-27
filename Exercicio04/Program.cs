
class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto("Vinho ", 90.00, 8);
        Console.WriteLine($"Valor total em estoque: R${produto.CalcularValorEmEstoque()}");

        produto.AdicionarEstoque(3);
        Console.WriteLine($"Valor total em estoque: R${produto.CalcularValorEmEstoque()}");

        produto.RemoverEstoque(10);
        Console.WriteLine($"Valor total em estoque: R${produto.CalcularValorEmEstoque()}");
    }
}
