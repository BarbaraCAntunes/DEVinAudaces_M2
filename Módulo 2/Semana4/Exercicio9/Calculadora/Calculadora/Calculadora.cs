
namespace Calculadora
{
    public static class Calculadora
    {
        public const double Pi = 3.14159265359;

        public static void Soma(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        public static void Subtracao(double a, double b)
        {
            Console.WriteLine(a - b);
        }

        public static void Multiplicacao(double a, double b)
        {
            Console.WriteLine(a * b);
        }

        public static void Divisao(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("O divisor não pode ser zero.");
            }
            Console.WriteLine(a / b);
        }
    }

}
