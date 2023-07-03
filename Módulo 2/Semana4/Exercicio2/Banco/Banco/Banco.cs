namespace Banco
{
    internal class Banco
    {
        private double _saldoConta;

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

        public override string ToString()
        {
            return $"R${_saldoConta}";
        }

    }
}
