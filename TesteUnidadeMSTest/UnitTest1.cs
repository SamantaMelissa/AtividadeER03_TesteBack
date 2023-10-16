using Matematica;

namespace TesteUnidadeMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void somar()
        {
            //3As
            //Arrange - Prepara��o
            double number01 = 1;
            double number02 = 2;
            double numberR = 3;

            //Act - A��o
            var resultado = Operacoes.Somar(number01, number02);

            //Assert - Verifica��o
            Assert.AreEqual(numberR, resultado);
        }
        [TestMethod]
        public void multiplicar()
        {
            //Arrange - Prepara��o
            double numer01 = 5;
            double numer02 = 6;
            double numberR = 80;

            //Act - A��o
            var X = Operacoes.Multiplicar(numer01, numer02);

            //Assert - Verifica��o
            Assert.AreEqual(numberR, X);
        }

        //Tudo o que vier abaixo, ser� testado v�rias vezes.
        [DataTestMethod]
        [DataRow(4,6,10)]
        [DataRow(9, 0, 9)]
        [DataRow(2, 6, 8)]

        public void Somar(double number01, double number02, double numberR)
        {
            var resultado = Operacoes.Somar(number01, number02);

            Assert.AreEqual(numberR, resultado);

        }

        [DataTestMethod]
        [DataRow(4, 6, 10)]
        [DataRow(9, 0, 0)]
        [DataRow(2, 6, 12)]
        public void Multiplicar(double number01, double number02, double numberR)
        {
            var resultado = Operacoes.Multiplicar(number01, number02);

            Assert.AreEqual(numberR, resultado);

        }

    }
}