class Program{

  static void Main(string[] args)
    {

      Filme filme1 = new Filme("A volta dos que não foram","Comedia", 123);
      Filme filme2 = new Filme("As longas tranças de um careca", "Terror", 231);


      filme1.AlugarLivro();
      filme1.VerificarDisponibilidade();
      filme1.AlugarLivro();
      filme1.DevolverLivro();
      Console.WriteLine("\n ---------------------------------------------------------------\n");
      filme2.VerificarDisponibilidade();
      filme2.DevolverLivro();
      filme2.AlugarLivro();
    }

}