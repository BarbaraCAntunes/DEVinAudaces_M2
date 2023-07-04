namespace Semana05
{
    public class PessoaFisica : Cliente
    {
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nome { get; set; }

        public override void ResumoCliente()
        {
            Console.WriteLine($"{NumeroConta} | {Nome} | {CPF}");
        }

        public bool EhMaior()
        {
            return DateTime.Today.Year - DataNascimento.Year >= 18;
        }
    }
}
