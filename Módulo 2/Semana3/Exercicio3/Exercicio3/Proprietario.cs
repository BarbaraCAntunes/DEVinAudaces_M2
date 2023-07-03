namespace Proprietarios
{
    public class Proprietario
    {
        public string Nome { get; set; }

        public string CPF { get; set; }
        public string Telefone { get; set; }
        public List<Proprietario> Proprietarios { get; set; }

        public Proprietario(string nome, string cpf, string telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Proprietarios = new List<Proprietario>();
        }

        public void CadastrarProprietario(string nome, string cpf, string telefone)
        {

            Proprietario novoProprietario = new Proprietario(nome, cpf, telefone);
            Proprietarios.Add(novoProprietario);

        }

        public override string ToString()
        {
            return $"Nome: {Nome} " +
                   $"CPF: {CPF} " +
                   $"Telefone: {Telefone} ";

        }

    }
}
