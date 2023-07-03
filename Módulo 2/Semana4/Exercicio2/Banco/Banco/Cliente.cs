
namespace Banco
{
    internal class Cliente
    {
        private string _nome;
        private int _cpf;

        public Cliente(string nome, int cpf)
        {
            _nome = nome;
            _cpf = cpf;
        }


        public override string ToString()
        {
            return $"Nome do cliente: {_nome}\n CPF: {_cpf}";
        }
    }
}
