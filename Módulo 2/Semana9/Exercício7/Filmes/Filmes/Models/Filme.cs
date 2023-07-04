using System.Globalization;

namespace Filmes.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Duracao { get; set; }
        public string Diretor { get; set; }
        public string Genero { get; set; }

        public Filme(int id, string nome, string duracao, string diretor, string genero)
        {
            Id = id;
            Nome = nome;
            Duracao = duracao;
            Diretor = diretor;
            Genero = genero;
        }
    }
}
