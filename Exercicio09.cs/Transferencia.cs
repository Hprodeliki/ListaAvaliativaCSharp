public class Transferencia : IMetodoPagamento
{
    public void FazerPagamento(double valor)
    {
        Console.WriteLine($"Pagamento de R${valor} feito por transferencia bancária");
    }

    public string VerificarStatusPagamento()
    {
        return "Pagamento confirmado";
    }
}