public class Credito : IMetodoPagamento
{
    public void FazerPagamento(double valor)
    {
        Console.WriteLine($"Pagamento de R${valor} feito com cartao de credito");
    }

    public string VerificarStatusPagamento()
    {
        return "Pagamento aprovado.";
    }
}