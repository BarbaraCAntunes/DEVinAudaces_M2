using Exercicio1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Insira um número inteiro:");
        int numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira outro número inteiro:");
        int numero2 = int.Parse(Console.ReadLine());

        Sum sum = new Sum(numero1, numero2);

        Console.WriteLine("SOMA: " + sum.CalcularSoma());
    }
}