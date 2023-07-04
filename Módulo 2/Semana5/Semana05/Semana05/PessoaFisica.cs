

namespace Semana05
{
    public class PessoaFisica : Cliente
    {
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }

        public override void ResumoCliente()
        {
            base.ResumoCliente();
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Data de Nascimento: {DataNascimento}");
        }

        public bool EhMaior()
        {
            return DateTime.Today.Year - DataNascimento.Year >= 18;
        }
    }
}
