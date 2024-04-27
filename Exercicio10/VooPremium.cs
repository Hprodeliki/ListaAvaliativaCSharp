public class VooPremium : IReserva
{
    public void Reservar()
    {
        Console.WriteLine("Voo premium garantido");
    }

    public void CancelarReserva()
    {
        Console.WriteLine("Reserva de voo premium cancelado");
    }

    public string VerificarStatus()
    {
        return "Sua reserva no voo premium esta reservadsa";
    }
}