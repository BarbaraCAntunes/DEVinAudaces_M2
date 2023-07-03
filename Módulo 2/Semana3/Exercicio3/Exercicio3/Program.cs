using Exercicio3;


internal class Program
{
    private static void Main(string[] args)
    {
        Proprietario proprietario1 = new("João da Silva", "00189765478", "48998852644");
        Proprietario proprietario2 = new("Maria Souza", "07582965922", "48997736211");
        Proprietario proprietario3 = new("Juliana Souza", "00961009071", "48998226299");


        Carro carro1 = new("Ford", "Ecosport", "RER6J05", "Preto", proprietario1.Nome);
        Carro carro2 = new("Fiat", "Argo", "KIJ5G78", "Branco", proprietario2.Nome);
        Carro carro3 = new("Toyota", "Corolla", "DFK8B54", "Vermelho", proprietario3.Nome);

        List<Carro> carros = new List<Carro>();

        carros.Add(carro1);
        carros.Add(carro2);
        carros.Add(carro3);


    }
}