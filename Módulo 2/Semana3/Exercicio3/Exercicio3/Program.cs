using Proprietarios;
using Carros;
using FrotaCarros;
using ListaProprietarios;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Proprietario> proprietrarios = new List<Proprietario>();
        ListaProprietariosC listaProprietarios = new(proprietrarios);

        listaProprietarios.CadastrarProprietario("João da Silva", "00189765478", "48998852644");
        listaProprietarios.CadastrarProprietario("Maria Souza", "07582965922", "48997736211");
        listaProprietarios.CadastrarProprietario("Juliana Souza", "00961009071", "48998226299");

        List<Carro> carros = new List<Carro>();
        FrotaCarro frotaCarros = new(carros);

        frotaCarros.CadastrarCarro("Ford", "Ecosport", "RER6J05", "Preto", "João da Silva");
        frotaCarros.CadastrarCarro("Fiat", "Argo", "KIJ5G78", "Branco", "Maria Souza");
        frotaCarros.CadastrarCarro("Toyota", "Corolla", "DFK8B54", "Vermelho", "Juliana Souza");


        Console.WriteLine("Bem vido(a) ao sistema! Digite o numero da opção que você deseja: \n" +
            "1 - Cadastrar Carro\n2 - Consultar Carros\n3 - Sair");
        int opcao = int.Parse(Console.ReadLine());

        while (opcao != 3)

        {

            if (opcao == 1)
            {
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
                listaProprietarios.CadastrarProprietario(proprietario, cpf, telefone);
                Console.WriteLine("Proprietário cadastrado com sucesso: \n" + novoProrietario);


                Carro novoCarro = new(marca, modelo, placa, cor, proprietario);
                frotaCarros.CadastrarCarro(marca, modelo, placa, cor, proprietario);
                Console.WriteLine("Carro cadastrado com sucesso: \n" + novoCarro);

                Console.WriteLine("Nova opção: ");
                opcao = int.Parse(Console.ReadLine());


            }
            else if (opcao == 2)
            {
                Console.WriteLine("Segue lista de carros cadastrados: \n");
                frotaCarros.ListarCarros(carros);
                listaProprietarios.ListarProprietarios(proprietrarios);

                Console.WriteLine("Nova opção: ");
                opcao = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Digite uma opção válida: 1, 2 ou 3!");
                opcao = int.Parse(Console.ReadLine());
            }

        }
    }
}