namespace Exercicio1
{
    internal class Sum
    {

        public int Numero1;
        public int Numero2;


        public Sum(int numero1, int numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }


        public int CalcularSoma()
        {
            return Numero1 + Numero2;
        }

    }
}
