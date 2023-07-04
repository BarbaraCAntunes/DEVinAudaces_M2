

namespace Exercicio5
{
    internal class ListaOrdenar
    {
        public void OrdenarLista(List<int> lista)
        {
            int n = lista.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (lista[j] > lista[j + 1])
                    {
                        int temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;
                    }
                }
            }
        }
    }
}
