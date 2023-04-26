using Exercicio1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Insira um número:");
        double numero1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira um segundo número:");
        double numero2 = double.Parse(Console.ReadLine());

        Sum sum = new Sum(numero1, numero2);

        Console.WriteLine("SOMA: " + sum.CalcularSoma());

        Console.WriteLine("Insira um número:");
        double numero3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira um segundo número:");
        double numero4 = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira um terceiro número:");
        double numero5 = double.Parse(Console.ReadLine());

        Sum sum2 = new Sum(numero3, numero4, numero5);


        Console.WriteLine("SOMA: " + sum2.CalcularSoma());




    }
}