public class Ingles : Linguas
{
    public Ingles(string aluno, int cargaHoraria, int custo) : base(aluno, cargaHoraria, custo)
    {
    }
    public void GerarCertificado()
    {
        Console.WriteLine("------------------Certificado-------------------");
        Console.WriteLine($"\nO aluno {Aluno} concluiu com exito o curso de ingles");
    }
}