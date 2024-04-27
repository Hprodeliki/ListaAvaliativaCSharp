class Program
{
  static void Main(string[] args){

    Bike bike = new Bike();
    
    bike.NumAro = 29;
    bike.Cor = "Verde";
    Console.WriteLine("\n ---------------------------------------------------------------\n");
    Console.WriteLine($" Bike aro: {bike.NumAro}");
    Console.WriteLine(bike.Cor);

    Carro carro = new Carro();
    carro.NumPortas = 4;
    carro.Cor="Vermelho";
    Console.WriteLine("\n ---------------------------------------------------------------\n");
    Console.WriteLine($"Carro com {carro.NumPortas} portas");
    Console.WriteLine(carro.Cor);

    Moto moto = new Moto();
    moto.Cilindrada = 120;
    moto.Cor = "preta";
    Console.WriteLine("\n ---------------------------------------------------------------\n");
    Console.WriteLine($" Moto com {moto.Cilindrada} clilindradas");
    Console.WriteLine(moto.Cor);
    Console.WriteLine("\n ---------------------------------------------------------------\n");
    
  }
}