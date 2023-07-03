internal partial class Program
{
  private static void Main(string[] args)
  {
    double resultado = 0;
    string operacao = "";

    while (operacao != "S")
    {
      Console.WriteLine("Olá! Digite o símbolo da operação que você deseja fazer:");
      Console.WriteLine("'+' - Adição");
      Console.WriteLine("'-' - Subtração");
      Console.WriteLine("'*' - Multiplicação");
      Console.WriteLine("'/' - Divisão");
      Console.WriteLine("'S' - Sair");

      operacao = Console.ReadLine();

      if (operacao == "S")
      {
        Console.WriteLine("Obrigada por utilizar a calculadora!");
        break;
      }

      Console.WriteLine("Digite o primeiro número:");
      double numero1;
      if (double.TryParse(Console.ReadLine(), out numero1))
      {
        Console.WriteLine("Digite o segundo número:");
        double numero2;
        if (double.TryParse(Console.ReadLine(), out numero2))
        {
          switch (operacao)
          {
            case "+":
              resultado = numero1 + numero2;
              break;
            case "-":
              resultado = numero1 - numero2;
              break;
            case "*":
              resultado = numero1 * numero2;
              break;
            case "/":
              if (numero2 == 0)
              {
                Console.WriteLine("Não é possível realizar divisões por 0!");
              }
              else
              {
                resultado = numero1 / numero2;
              }
              break;
            default:
              Console.WriteLine("Digite uma operação válida!");
              break;
          }
          Console.WriteLine("O resultado da sua operação é: " + resultado);
        }
      }
    }
  }
}
