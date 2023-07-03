namespace Banco
{
    internal class ContaBancária
    {
        private int _numeroConta;
        private Cliente _cliente;
        private double _saldoConta;

        public ContaBancária(int numeroConta, Cliente cliente)
        {
            _numeroConta = numeroConta;
            _cliente = cliente;
            _saldoConta = 0;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Número da conta: {_numeroConta}\n  {_cliente} ");
        }

        public void Depositar(double valor)
        {
            _saldoConta += valor;
        }

        public bool Saca(double valor)
        {
            if (valor <= _saldoConta)
            {
                _saldoConta -= valor;
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }
        }

        public void GetSaldo()
        {
            double saldo = _saldoConta;
            Console.WriteLine($"O saldo da sua conta é: {saldo}");
        }



        public override string ToString()
        {
            return $"Número da conta: {_numeroConta}" +
                   $"{_cliente}" +
                   $"Saldo da conta: {_saldoConta}";
        }
    }
}
