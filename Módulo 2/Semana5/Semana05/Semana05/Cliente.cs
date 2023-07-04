

namespace Semana05
{

    public abstract class Cliente
    {
        public string NumeroConta { get; set; }
        public decimal Saldo { get; set; }
        public string Endereco { get; set; }

        public string Nome { get; set; }

        public virtual void ResumoCliente()
        {
            Console.WriteLine($"Número da conta: {NumeroConta}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine($"Saldo: {Saldo}");
        }
    }

}
