class Program
{
    static void Main(string[] args)
    {
        IReserva reserva1 = new VooNormal();

        reserva1.Reservar();
        Console.WriteLine(reserva1.VerificarStatus());

        IReserva reserva2 = new VooPremium();

        reserva2.Reservar();
        Console.WriteLine(reserva2.VerificarStatus());

        IReserva reserva3 = new VooGrande();

        reserva3.Reservar();
        Console.WriteLine(reserva3.VerificarStatus());
        reserva3.CancelarReserva();
        
    }
}