namespace Exercicio1
{
    internal class Sum
    {

        public double Numero1;
        public double Numero2;
        public double Numero3;


        public Sum(double numero1, double numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        public Sum(double numero1, double numero2, double numero3)
        {
            Numero1 = numero1;
            Numero2 = numero2;
            Numero3 = numero3;
        }

        public double CalcularSoma()
        {
            return Numero1 + Numero2 + Numero3;
        }

    }
}
