using Carros;


namespace FrotaCarros
{
    internal class FrotaCarro
    {
        public List<Carro> Carros { get; set; }

        public FrotaCarro(List<Carro> carros)
        {
            Carros = carros;
        }

        public void CadastrarCarro(string marca, string modelo, string placa, string cor, string proprietario)
        {
            Carro novoCarro = new Carro(marca, modelo, placa, cor, proprietario);
            Carros.Add(novoCarro);
        }

        public void ListarCarros(List<Carro> carros)
        {

              foreach (var carro in carros)
            {
                Console.WriteLine(carro.ToString());
              
            }
        }
    }
}

