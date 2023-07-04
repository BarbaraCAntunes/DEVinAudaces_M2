using Exercicio5;

internal class Program
{
    private static void Main(string[] args)
    {
        ListaInversor inversor = new ListaInversor();
        List<int> minhaLista = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine("Lista original:");
        foreach (int i in minhaLista)
        {
            Console.WriteLine(i);
        }
        inversor.InverterLista(minhaLista);
        Console.WriteLine("Lista invertida:");
        foreach (int i in minhaLista)
        {
            Console.WriteLine(i);
        }


        ListaOrdenar ordenador = new ListaOrdenar();
        List<int> numeros = new List<int> { 5, 2, 8, 1, 4 };

        Console.WriteLine("Antes da ordenação:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }

        ordenador.OrdenarLista(numeros);

        Console.WriteLine("\nDepois da ordenação:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }
    }
}
