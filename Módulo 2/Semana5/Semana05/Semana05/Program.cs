using Semana05;

public class Program
{

    private static List<Cliente> clientes = new List<Cliente>();

    public static void Main(string[] args)
    {
        Console.WriteLine("Deseja criar uma conta para Pessoa Física ou Jurídica? (F/J)");
        var resposta = Console.ReadLine();

        
        if (resposta.ToUpper() == "F")
        {
            CriarContaPessoaFisica();
        }
        else if (resposta.ToUpper() == "J")
        {
            CriarContaPessoaJuridica();
        } 
    }

    private static void CriarContaPessoaFisica()
    {
        Console.WriteLine("Informe o número da conta:");
        var numeroConta = Console.ReadLine();

        Console.WriteLine("Informe o endereço:");
        var endereco = Console.ReadLine();

        Console.WriteLine("Informe o CPF:");
        var cpf = Console.ReadLine();

        Console.WriteLine("Informe a data de nascimento (AAAA-MM-DD):");
        var dataNascimento = DateTime.Parse(Console.ReadLine());

        var cliente = new PessoaFisica
        {
            NumeroConta = numeroConta,
            Endereco = endereco,
            CPF = cpf,
            DataNascimento = dataNascimento,
            Saldo = 0
        };

        if (!cliente.EhMaior())
        {
            Console.WriteLine("Não é possível criar uma conta para uma pessoa menor de idade.");
            return;
        }

        clientes.Add(cliente);
        Console.WriteLine("Conta criada com sucesso!");
    }

    private static void CriarContaPessoaJuridica()
    {
        Console.WriteLine("Informe o número da conta:");
        var numeroConta = Console.ReadLine();

        Console.WriteLine("Informe o endereço:");
        var endereco = Console.ReadLine();

        Console.WriteLine("Informe o CNPJ:");
        var cnpj = Console.ReadLine();

        var cliente = new PessoaJuridica
        {
            NumeroConta = numeroConta,
            Endereco = endereco,
            CNPJ = cnpj,
            Saldo = 0
        };

        clientes.Add(cliente);
        Console.WriteLine("Conta criada com sucesso!");
    }
}