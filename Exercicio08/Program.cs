class Program
{
    static void Main(string[] args)
    {
        Ingles ingles = new Ingles("Inglês", 30, 350);
        ingles.CalcularCusto();
        ingles.GerarCertificado();

        Espanhol espanhol = new Espanhol("Espanhol", 40, 800);
        espanhol.CalcularCusto();
        espanhol.GerarCertificado();

        Frances frances = new Frances("Frances", 30, 200);
        frances.CalcularCusto();
        frances.GerarCertificado();
    }
}