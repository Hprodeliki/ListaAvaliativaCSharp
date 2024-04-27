public class Filme
{
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public float Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Filme(string titulo, string genero, float duracao)
    {
        Titulo = titulo;
        Genero = genero;
        Duracao = duracao;
        Disponivel = true;
    }

    public void AlugarLivro(){
      if(Disponivel){
        Disponivel = false;
        Console.WriteLine($"O filme {Titulo} foi alugado com sucesso");

      }else{
        Console.WriteLine($"O livro {Titulo} não esta disponivel no momento");
      }
    }
    public void DevolverLivro(){
      if(!Disponivel){
        Disponivel = true;
        Console.WriteLine("Livro devolvido");
      }else{
        Console.WriteLine("O livro não pode ser devolvido pois está aqui");
      }
  }
    

    public string VerificarDisponibilidade()
    {
        if (Disponivel == true)
        {
            return "Disponivel";
        }
        else
        {
            return "Indisponivel";
        }
    }
    
}
