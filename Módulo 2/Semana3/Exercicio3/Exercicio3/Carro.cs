using Proprietarios;

namespace Carros
{
    internal class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }

        public string Proprietario { get; }



        public Carro(string marca, string modelo, string placa, string cor, string proprietario)
        {
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            Cor = cor;
            Proprietario = proprietario;

        }


       

        public override string ToString()
        {
            return $"Marca: {Marca} " +
             $"Modelo: {Modelo} " +
             $"Placa: {Placa} " +
             $"Cor: {Cor} " ;
        }

    }
}

