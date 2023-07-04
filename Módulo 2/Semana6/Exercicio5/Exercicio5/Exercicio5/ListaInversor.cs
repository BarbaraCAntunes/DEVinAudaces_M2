namespace Exercicio5
{
    public class ListaInversor
    {
        public void InverterLista<T>(List<T> lista)
        {
            int n = lista.Count;
            for (int i = 0; i < n / 2; i++)
            {
                T temp = lista[i];
                lista[i] = lista[n - i - 1];
                lista[n - i - 1] = temp;
            }
        }
    }
}
