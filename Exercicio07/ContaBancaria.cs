public class ContaBancaria
{
    public string Cliente { get; set; }
    public double Conta { get; set; }
    public double Saldo { get; set; }

    public ContaBancaria(string cliente, double conta, double saldo)
    {
        Cliente = cliente;
        Conta = conta;
        Saldo = saldo;
    }

    public void Depositar(double valor)
    {
        Saldo += valor;
        Console.WriteLine($"Valor de {valor} depositado. Novo saldo: {Saldo}");
    }

    public void Sacar(double valor)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor;
            Console.WriteLine($"Você sacou {valor} com sucesso. Novo saldo: {Saldo}");
        }
        else
        {
            Console.WriteLine("Saldo Insuficiente.");
        }
    }

    public void MostrarSaldo()
    {
        Console.WriteLine($"Saldo: {Saldo}");
    }
}
