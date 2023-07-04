using System;

namespace Semana05
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IClienteService clienteService = new ClienteService();

            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("Bem-vindo ao nosso sistema bancário!");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Abrir Conta");
                Console.WriteLine("2 - Consultar Conta");
                Console.WriteLine("3 - Listar Todas as contas");
                Console.WriteLine("4 - Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        clienteService.CriarConta();
                        break;
                    case "2":
                        Console.WriteLine("Digite o número da conta:");
                        string numeroConta = Console.ReadLine();
                        var cliente = clienteService.BuscarClientePorNumeroDeConta(numeroConta);
                        if (cliente != null)
                        {
                            cliente.ResumoCliente();
                        }
                        else
                        {
                            Console.WriteLine("Conta não encontrada.");
                        }
                        break;
                    case "3":
                        clienteService.ExibirClientes();
                        break;
                    case "4":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
