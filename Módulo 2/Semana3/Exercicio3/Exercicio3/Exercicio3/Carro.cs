using System.Security.Cryptography.X509Certificates;

namespace Exercicio3
{
    internal class Carro
    {
        public string Marca;
        public string Modelo;
        public string Placa;
        public string Cor;
        public string Proprietario;

        public Carro(string marca, string modelo, string placa, string cor, string proprietario)
        {
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            Cor = cor;
            Proprietario = proprietario;
        }
    }
}
