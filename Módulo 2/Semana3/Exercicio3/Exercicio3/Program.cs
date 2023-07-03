using Proprietarios;
using Carros;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
                   
        
        Proprietario proprietario1 = new("João da Silva", "00189765478", "48998852644");
        Proprietario proprietario2 = new("Maria Souza", "07582965922", "48997736211");
        Proprietario proprietario3 = new("Juliana Souza", "00961009071", "48998226299");

        proprietario1.CadastrarProprietario("João da Silva", "00189765478", "48998852644");
        proprietario2.CadastrarProprietario("Maria Souza", "07582965922", "48997736211");
        proprietario3.CadastrarProprietario("Juliana Souza", "00961009071", "48998226299");
      

        Carro carro1 = new("Ford", "Ecosport", "RER6J05", "Preto", proprietario1);
        Carro carro2 = new("Fiat", "Argo", "KIJ5G78", "Branco", proprietario2);
        Carro carro3 = new("Toyota", "Corolla", "DFK8B54", "Vermelho", proprietario3);

        carro1.CadastrarCarro("Ford", "Ecosport", "RER6J05", "Preto", proprietario1);
        carro1.CadastrarCarro("Fiat", "Argo", "KIJ5G78", "Branco", proprietario2);
        carro1.CadastrarCarro("Toyota", "Corolla", "DFK8B54", "Vermelho", proprietario3);
    


        Console.WriteLine("Qual a marca do carro?");
        string marca = Console.ReadLine();
        Console.WriteLine("Qual o modelo do carro?");
        string modelo = Console.ReadLine();
        Console.WriteLine("Qual a placa do carro?");
        string placa = Console.ReadLine();
        Console.WriteLine("Qual a cor do carro?");
        string cor = Console.ReadLine();
        Console.WriteLine("Qual o proprietário do carro?");
        string proprietario = Console.ReadLine();
        Console.WriteLine($"Qual o CPF de {proprietario}?");
        string cpf = Console.ReadLine();
        Console.WriteLine($"Qual o telefone de {proprietario}?");
        string telefone = Console.ReadLine();

        Proprietario novoProrietario = new(proprietario, cpf, telefone);
        novoProrietario.CadastrarProprietario(proprietario, cpf, telefone);
        Console.WriteLine("Proprietário cadastrado com sucesso: \n" + novoProrietario);
        Carro novoCarro = new(marca, modelo, placa, cor, novoProrietario);
        novoCarro.CadastrarCarro(marca, modelo, placa, cor, novoProrietario);
        Console.WriteLine("Carro cadastrado com sucesso: \n" + novoCarro);





    }
}