public class ContaEmpresarial : ContaBancaria
{
    public double ValorMinimo { get; set; }

    public ContaEmpresarial(string cliente, double conta, double saldo, double valorMinimo) : base(cliente, conta, saldo)
    {
        ValorMinimo = valorMinimo;
    }

    public void VerificarSaldoMinimo()
    {
        if (Saldo < ValorMinimo)
        {
            Console.WriteLine($"Saldo abaixo do valor mínimo: {ValorMinimo}");
        }
        else
        {
            Console.WriteLine("Saldo suficiente.");
        }
    }
}