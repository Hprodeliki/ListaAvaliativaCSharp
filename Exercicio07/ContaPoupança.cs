public class ContaPoupanca : ContaBancaria
{
    public double Juros { get; set; }

    public ContaPoupanca(string cliente, double conta, double saldo, double juros) : base(cliente, conta, saldo)
    {
        Juros = juros;
    }

    public void CalcularJuros()
    {
        Saldo *= (1 + Juros);
        Console.WriteLine($"Saldo com juros: {Saldo}");
    }
}