internal partial class Program
{
  private static void Main(string[] args)
  {
    string marca;
    string modelo;
    double kmRodados;

    Console.WriteLine("Qual a marca do veículo?");
    marca = Console.ReadLine();
    Console.WriteLine("Qual o modelo do veículo?");
    modelo = Console.ReadLine();
    Console.WriteLine("Quantos km rodados tem o veículo?");
    kmRodados = double.Parse(Console.ReadLine());

    if (kmRodados > 10000)
    {
      Console.WriteLine("O carro " + modelo + " da marca " + marca + " precisa fazer revisão.");
    }
    else
    {
      Console.WriteLine("O carro " + modelo + " da marca " + marca + " não precisa fazer revisão.");
    }
  }
}