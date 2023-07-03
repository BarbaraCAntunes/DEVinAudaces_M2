namespace Banco
{
    internal class ContaBancária
    {
        private int _numeroConta;
        private Cliente _cliente;

        public ContaBancária(int numeroConta, Cliente cliente)
        {
            _numeroConta = numeroConta;
            _cliente = cliente;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Número da conta: {_numeroConta}\n  {_cliente} ");
        }

        public void Depositar(double valor)
        {
            ;
        }

        public void Sacar(double valor)
        {
            ;
        }

        public void getSaldo()
        {

        }


        public override string ToString()
        {
            return $"Número da conta: {_numeroConta}" +
                   $"{_cliente}" +
                   $"Saldo da conta: {_saldoConta}";
        }
    }
}
