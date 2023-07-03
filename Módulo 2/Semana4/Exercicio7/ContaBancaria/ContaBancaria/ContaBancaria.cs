public class ContaBancaria
{
    public string NumeroDaConta { get; set; }

    private double _saldo;


    public double Saldo
    {
        get { return _saldo; }
        private set
        {
            if (value >= 0 && value <= ValorMaximoSaldo)
            {
                _saldo = value;
            }
            else
            {
                Console.WriteLine("O valor é inválido para o saldo.");
            }
        }
    }

    private readonly double ValorMaximoSaldo = 1000000.0;

    public ContaBancaria(string numeroDaConta, double saldoInicial)
    {
        NumeroDaConta = numeroDaConta;
        Saldo = saldoInicial;
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            if (Saldo + valor <= ValorMaximoSaldo)
            {
                Saldo += valor;
            }
            else
            {
                Console.WriteLine("O depósito ultrapassará o valor máximo permitido de saldo.");
            }
        }
        else
        {
            Console.WriteLine("O valor do depósito deve ser maior que zero.");
        }
    }

    public void Sacar(double valor)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para sacar esse valor.");
        }
    }
}
