public class VooGrande : IReserva
{
    public void Reservar()
    {
        Console.WriteLine("seu Voo coma familia esta garantido");
    }

    public void CancelarReserva()
    {
        Console.WriteLine("Reserva de voo com grupo grande de pessoas cancelado");
    }

    public string VerificarStatus()
    {
        return "Sua reserva no voo com grupo grande de pessoas esta reservada";
    }
}