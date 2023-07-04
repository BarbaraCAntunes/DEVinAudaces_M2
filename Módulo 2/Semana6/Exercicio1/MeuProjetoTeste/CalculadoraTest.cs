using MeuProjetoConsole;

namespace MeuProjetoTeste
{
    public class CalculadoraTest
    {
        [Test]
        public void SomaFuncionaComNumerosNegativos()
        {
            Calculadora calculadora = new Calculadora();
            int resultado = calculadora.Soma(-5, -3, -7);
            Assert.AreEqual(-15, resultado);
        }
    }
}
