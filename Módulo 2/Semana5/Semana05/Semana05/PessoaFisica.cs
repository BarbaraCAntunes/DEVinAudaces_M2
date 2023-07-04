
namespace Semana05
{
    public class PessoaFisica : Cliente
    {
        public string CPF { get; set; }

        public override void ResumoCliente()
        {
            base.ResumoCliente();
            Console.WriteLine($"CPF: {CPF}");
        }
    }
}
