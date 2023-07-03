internal partial class Program
{
  private static void Main(string[] args)
  {
    int quantidadeNumeros;
    int soma = 0;
    double media;

    Console.WriteLine("Quantos números você vai inserir?");
    quantidadeNumeros = int.Parse(Console.ReadLine());

    int[] numeros = new int[quantidadeNumeros];

    for (int i = 0; i < numeros.Length; i++)
    {
      Console.WriteLine("Digite o " + (i + 1) + "º número:");
      numeros[i] = int.Parse(Console.ReadLine());
    }

    foreach (int numero in numeros)
    {
      soma += numero;
    }

    media = (double)soma / numeros.Length;

    Console.WriteLine("A média artimética dos valores é: " + media);
  }
}