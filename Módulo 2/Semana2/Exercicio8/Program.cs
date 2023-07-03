internal partial class Program
{
  private static void Main(string[] args)
  {
    int[] numeros = new int[5];
    int maximo = 0;

    for (int i = 0; i < numeros.Length; i++)
    {
      Console.WriteLine("Digite o " + (i + 1) + "º número:");
      numeros[i] = int.Parse(Console.ReadLine());
    }

    maximo = numeros[0];
    for (int i = 1; i < numeros.Length; i++)
    {
      if (numeros[i] > maximo)
      {
        maximo = numeros[i];
      }
    }

    Console.WriteLine("O maior número no array é: " + maximo);
  }
}
