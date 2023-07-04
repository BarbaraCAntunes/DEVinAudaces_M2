

namespace Semana05
{
    public class PessoaJuridica : Cliente
    {
        public string CNPJ { get; set; }

        public override void ResumoCliente()
        {
            base.ResumoCliente();
            Console.WriteLine($"CNPJ: {CNPJ}");
        }
    }
}
