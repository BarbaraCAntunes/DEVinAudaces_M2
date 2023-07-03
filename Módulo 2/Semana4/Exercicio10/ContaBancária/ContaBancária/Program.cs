namespace ContaBancária
{
    public class Program
    {
        public static void Main()
        {
  
            ContaBancaria conta = new ContaBancaria();

            Console.WriteLine($"Saldo inicial: {conta.VerificarSaldo()}");

            conta.Depositar(200);
            conta.Depositar(300);

            Console.WriteLine($"Saldo após depósitos: {conta.VerificarSaldo()}");


            conta.Sacar(150);

            Console.WriteLine($"Saldo após saque: {conta.VerificarSaldo()}");

            Console.WriteLine("Transações realizadas:");
            conta.VerificarTransacoes();
            
        }
    }
}