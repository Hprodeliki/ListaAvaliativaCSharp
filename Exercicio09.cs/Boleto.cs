public class Boleto : IMetodoPagamento
{
    public void FazerPagamento(double valor)
    {
        Console.WriteLine($"Pagamento de R${valor} feito com boleto");
    }

    public string VerificarStatusPagamento()
    {
        return "Pagamrento feito";
    }
}