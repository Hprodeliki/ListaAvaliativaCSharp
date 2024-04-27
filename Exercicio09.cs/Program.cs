class Program
{
    static void Main(string[] args)
    {
        IMetodoPagamento eu = new Credito();
        eu.FazerPagamento(340.0);
        Console.WriteLine(eu.VerificarStatusPagamento());

        IMetodoPagamento pato = new Boleto();
        pato.FazerPagamento(3766.50);
        Console.WriteLine(pato.VerificarStatusPagamento());

        IMetodoPagamento escobar = new Transferencia();

        escobar.FazerPagamento(350000.30);
        Console.WriteLine(escobar.VerificarStatusPagamento());
    }
}