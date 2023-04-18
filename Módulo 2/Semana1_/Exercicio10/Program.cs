internal partial class Program
{
    private static void Main(string[] args)
    {
        double resultado = 0;
        char operacao;

        Console.WriteLine("Olá! Digite o símbolo da operação que você deseja fazer:");
        Console.WriteLine("'+' - Adição");
        Console.WriteLine("'-' - Subtração");
        Console.WriteLine("'*' - Multiplicação");
        Console.WriteLine("'/' - Divisão");

        operacao = Console.ReadLine()[0];

        Console.WriteLine("Digite o primeiro número:");
        double numero1;
        if (double.TryParse(Console.ReadLine(), out numero1)) {
            Console.WriteLine("Digite o segundo número:");
            double numero2;
            if (double.TryParse(Console.ReadLine(), out numero2)) {
                switch (operacao)
                {
                    case '+':
                        resultado = numero1 + numero2;
                        break;
                    case '-':
                        resultado = numero1 - numero2;
                        break;
                    case '*':
                        resultado = numero1 * numero2;
                        break;
                    case '/':
                        resultado = numero1 / numero2;
                        break;
                    default:
                        Console.WriteLine("Digite uma operação válida!");
                        break;
                }
                Console.WriteLine("O resultado da sua operação é: " + resultado);
            } else {
                Console.WriteLine("Digite um número válido!");
            }
        } else {
            Console.WriteLine("Digite um número válido!");
        }
    }
}
