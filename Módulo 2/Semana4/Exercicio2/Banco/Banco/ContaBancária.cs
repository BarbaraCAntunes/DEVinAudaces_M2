namespace Banco
{
    internal class ContaBancária
    {
        private int _numeroConta;
        private double _saldoConta;

        public ContaBancária(int numeroConta)
        {
            _numeroConta = numeroConta;
            _saldoConta = 0;
        }

        public void Depositar(double valor)
        {
            _saldoConta += valor;
        }

        public void Saca(double valor)
        {
            if (valor <= _saldoConta)
            {
                _saldoConta -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }

        public void GetSaldo()
        {
            double saldo = _saldoConta;
            Console.WriteLine($"O saldo da sua conta é: {saldo}");
        }


    }
}
