using Proprietarios;

namespace Carros
{
    internal class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }

        public Proprietario Proprietario { get; }
        public List<Carro> Carros { get; set; }


        public Carro(string marca, string modelo, string placa, string cor, Proprietario proprietario)
        {
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            Cor = cor;
            Proprietario = proprietario;
            Carros = new List<Carro>();
        }


        public void CadastrarCarro(string marca, string modelo, string placa, string cor, Proprietario proprietario)
        {
            Carro novoCarro = new Carro(marca, modelo, placa, cor, proprietario);
            Carros.Add(novoCarro);


        }

        public void ListarCarros()
        {
            foreach (var carro in Carros)
            {
                Console.WriteLine(carro);
                Console.WriteLine(carro.Proprietario);
            }
        }

        public override string ToString()
        {
            return $"Marca: {Marca} " +
             $"Modelo: {Modelo} " +
             $"Placa: {Placa} " +
             $"Cor: {Cor} " +
             $"Proprietário: {Proprietario.Nome}";
        }

    }
}
