using System;

public class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int QtdEstoque { get; set; }

    public Produto(string nome, double preco, int qtdEstoque)
    {
        Nome = nome;
        Preco = preco;
        QtdEstoque = qtdEstoque;
    }

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade > 0)
        {
            QtdEstoque +=quantidade;
            Console.WriteLine($"{quantidade} unidades de {Nome} adicionadas no estoque");
        }else
        {
            Console.WriteLine("Quantidade inválida. A quantidade a ser adicionada deve ser maior que zero.");
        }
    }

    public void RemoverEstoque(int quantidade)
    {
        if (quantidade > 0 && quantidade <= QtdEstoque)
        {
            QtdEstoque -= quantidade;
            Console.WriteLine($"{quantidade} unidades de {Nome} removidas do estoque");
        }
        else
        {   Console.WriteLine("Quantidade inválida");
        }
    }

    public double CalcularValorEmEstoque()
    {
        return Preco *QtdEstoque;}
}
