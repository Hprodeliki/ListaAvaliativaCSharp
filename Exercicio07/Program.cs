class Program
{
    static void Main(string[] args)
    {
        ContaBancaria contaBancaria = new ContaBancaria("Escobar", 554, 50000.0);
        contaBancaria.Depositar(100500.0);
        contaBancaria.Sacar(90000.0);
        contaBancaria.MostrarSaldo();
        Console.WriteLine("\n ---------------------------------------------------------------\n");

        ContaPoupanca contaPoupanca = new ContaPoupanca("Geucimar", 987.0, 5000.0, 1.5);
        contaPoupanca.Depositar(5000.0);
        contaPoupanca.CalcularJuros();
        contaPoupanca.MostrarSaldo();
        Console.WriteLine("\n ---------------------------------------------------------------\n");

        ContaEmpresarial contaEmpresarial = new ContaEmpresarial("Leandro", 800, 20620.0, 900.0);
        contaEmpresarial.Depositar(20620.0);
        contaEmpresarial.VerificarSaldoMinimo();
        contaEmpresarial.Sacar(2200.0);
        contaEmpresarial.MostrarSaldo();
        Console.WriteLine("\n ---------------------------------------------------------------\n");
    }
}