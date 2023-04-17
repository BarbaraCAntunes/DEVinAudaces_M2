internal class Program
{
  private static void Main(string[] args)
  {
    int[] numeros = new int[4];

    for (int i = 0; i < numeros.Length; i++)
    {
      Console.WriteLine("Digite o " + (i + 1) + "º numero:");
      numeros[i] = int.Parse(Console.ReadLine());
    }

    Array.Sort(numeros);

    for (int i = 0; i < numeros.Length; i++)
    {
      Console.WriteLine("Numero " + (i + 1) + ": " + numeros[i]);
    }
  }
}