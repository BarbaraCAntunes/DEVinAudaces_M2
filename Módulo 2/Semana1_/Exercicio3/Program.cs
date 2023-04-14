internal partial class Program
{
  private static void Main(string[] args)
  {
    string nome;
    int idade;

    Console.WriteLine("Qual o nome do paciente?");
    nome = Console.ReadLine();
    Console.WriteLine("Qual a idade do paciente?");
    idade = int.Parse(Console.ReadLine());

    if (idade > 60) {
      Console.WriteLine("O paciente " + nome + " é maior de idade e é idoso.");
    } else if (idade < 18) {
      Console.WriteLine("O paciente " + nome + " é menor de idade.");
    } else {
      Console.WriteLine("O paciente " + nome + " é maior de idade.");
    }
  } 
}