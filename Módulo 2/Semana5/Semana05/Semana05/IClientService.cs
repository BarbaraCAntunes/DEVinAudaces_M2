namespace Semana05
{
    public interface IClienteService
    {
        void CriarConta();

        Cliente BuscarClientePorNumeroDeConta(string numeroConta);

        void ExibirClientes();
    }
}
