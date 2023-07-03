internal class Program
{
    private static void Main(string[] args)
    {
        ContaBancaria conta = new ContaBancaria("123456", 10000);
        conta.Depositar(5000);
        Console.WriteLine(conta.Saldo); 
        conta.Sacar(2000);
        Console.WriteLine(conta.Saldo); 
    }
}