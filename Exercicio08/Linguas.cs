public class Linguas
{
  public string Aluno{ get; set; }
  public int CargaHoraria{ get; set; }
  public int Custo{ get; set; }


  public Linguas(string aluno, int cargaHoraria, int custo){
    Aluno = aluno;
    CargaHoraria = cargaHoraria;
    Custo = custo;
  }
  public void CalcularCusto()
    {
        Console.WriteLine($"O custo do curso de {Aluno} é de R${Custo}");
    }

}