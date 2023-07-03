

namespace Exercicio1
{
    internal class Pessoa
    {
        private string _Nome;
        protected int Idade;
        public string Endereco;

        public Pessoa(string nome, int idade, string endereco)
        {
            _Nome = nome;
            Idade = idade;
            Endereco = endereco;
        }

        public void Saudacao()
        {
            Console.WriteLine($"Olá, meu nome é {_Nome} e eu tenho {Idade} anos!");
        }
    }
}
