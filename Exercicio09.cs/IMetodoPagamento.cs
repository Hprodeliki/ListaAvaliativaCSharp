public interface IMetodoPagamento
{
    void FazerPagamento(double valor);
    string VerificarStatusPagamento();
}
