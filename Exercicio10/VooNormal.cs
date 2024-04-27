public class VooNormal : IReserva
{
    public void Reservar()
    {
        Console.WriteLine("Voo garantido");
    }

    public void CancelarReserva()
    {
        Console.WriteLine("Reserva de voo cancelado");
    }

    public string VerificarStatus()
    {
        return "Sua reserva no voo normalesta reservadsa";
    }
}
