internal partial class Program
{
  private static void Main(string[] args)
  {
    int numero;

    Console.WriteLine("Insira um número inteiro e positivo:");
    numero = int.Parse(Console.ReadLine());

    while (numero < 0)
    {
      Console.WriteLine("Informe apenas números positivos:");
      numero = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i <= numero; i += 2)
    {
      if (i % 2 == 0)
      {
        Console.WriteLine(i);
      }
    }
  }
}