

namespace ContaBancária
{
    public class ContaBancaria
    {
        private decimal saldo;
        private List<string> transacoes;

        public ContaBancaria()
        {
            saldo = 0m;
            transacoes = new List<string>();
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                transacoes.Add($"Depósito de {valor}, Saldo atual: {saldo}");
                Console.WriteLine("Depósito efetuado com sucesso!");
            }
            else
            {
                Console.WriteLine("O valor do depósito precisa ser maior que zero.");
            }
        }

        public void Sacar(decimal valor)
        {
            if (valor <= saldo && valor > 0)
            {
                saldo -= valor;
                transacoes.Add($"Saque de {valor}, Saldo atual: {saldo}");
                Console.WriteLine("Saque efetuado com sucesso!");

            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou valor de saque inválido.");

            }
        }

        public decimal VerificarSaldo()
        {
            return saldo;
        }

        public void VerificarTransacoes()
        {
            foreach (var transacao in transacoes)
            {
                Console.WriteLine(transacao);
            };
        }
    }

}
