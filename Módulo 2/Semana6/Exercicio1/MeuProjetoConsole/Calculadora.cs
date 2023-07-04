namespace MeuProjetoConsole
{
    public class Calculadora
    {
        public int Soma(params int[] numeros)
        {
            int total = 0;
            foreach (int numero in numeros)
            {
                total += numero;
            }
            return total;
        }
    }
}
