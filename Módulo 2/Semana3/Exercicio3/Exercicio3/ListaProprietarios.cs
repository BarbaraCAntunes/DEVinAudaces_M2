using Proprietarios;

namespace ListaProprietarios
{
    internal class ListaProprietariosC
    {
        public List<Proprietario> Proprietarios { get; set; }

        public ListaProprietariosC(List<Proprietario> proprietarios)
        {
            Proprietarios = proprietarios;
        }

        public void CadastrarProprietario(string nome, string cpf, string telefone)
        {

            Proprietario novoProprietario = new Proprietario(nome, cpf, telefone);
            Proprietarios.Add(novoProprietario);

        }

        public void ListarProprietarios(List<Proprietario> proprietarios)
        {
            foreach (var prop in proprietarios)
            {
                Console.WriteLine(prop.ToString());
            }
        }

    }


}
