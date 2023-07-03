
namespace Banco
{
    internal class Pessoa
    {
        private string _nome;
        private int _idade;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public int Idade
        {
            get { return _idade; }
            set
            {
                if (value >= 0)
                {
                    _idade = value;
                }
                else
                {
                    Console.WriteLine("A idade não pode ser negativa!");
                }
            }
        }

        public void DefinirIdade(int value)
        {
            if (value >= 0)
            {
                Idade = value;
            }
            else
            {
                Console.WriteLine("A idade não pode ser negativa!");
            }
        }

        public int RecuperarIdade()
        {
            return Idade;
        }

        public string RecuperarNome()
        {
            return Nome;
        }
    }
}
