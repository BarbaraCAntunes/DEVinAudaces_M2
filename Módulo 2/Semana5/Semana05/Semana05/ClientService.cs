﻿

namespace Semana05
{
    public class ClienteService : IClienteService
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public void CriarConta()
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

        private void CriarContaPessoaFisica()
        {
            Console.WriteLine("Informe o número da conta:");
            var numeroConta = Console.ReadLine();

            Console.WriteLine("Informe o nome completo:");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe o endereço:");
            var endereco = Console.ReadLine();

            Console.WriteLine("Informe o CPF:");
            var cpf = Console.ReadLine();

            Console.WriteLine("Informe a data de nascimento (AAAA-MM-DD):");
            var dataNascimento = DateTime.Parse(Console.ReadLine());

            var cliente = new PessoaFisica
            {
                NumeroConta = numeroConta,
                Nome = nome,
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

        private void CriarContaPessoaJuridica()
        {
            Console.WriteLine("Informe o número da conta:");
            var numeroConta = Console.ReadLine();

            Console.WriteLine("Informe a razão social da empresa:");
            var razaoSocial = Console.ReadLine();

            Console.WriteLine("Informe o endereço:");
            var endereco = Console.ReadLine();

            Console.WriteLine("Informe o CNPJ:");
            var cnpj = Console.ReadLine();

            var cliente = new PessoaJuridica
            {
                NumeroConta = numeroConta,
                RazaoSocial = razaoSocial,
                Endereco = endereco,
                CNPJ = cnpj,
                Saldo = 0
            };

            clientes.Add(cliente);
            Console.WriteLine("Conta criada com sucesso!");
        }

        public Cliente BuscarClientePorNumeroDeConta(string numeroConta)
        {
            return clientes.FirstOrDefault(c => c.NumeroConta == numeroConta);
        }

        public void ExibirClientes()
        {
            foreach (var cliente in clientes)
            {
                cliente.ResumoCliente();
                Console.WriteLine();
            }
        }
    }
}
