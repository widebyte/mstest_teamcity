using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace demo_mstest
{
    [TestClass]
    public class UnitTest1
    {
        private int SequencaFibonacci(int numero)
        {
            var a = 0;
            var b = 1;

            for (var i = 0; i < numero; i++)
            {
                var temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        [TestMethod]
        public void Somar_DoisNumeros_Retornar_Sucesso()
        {
            // arrange
            var numero1 = 10;
            var numero2 = 20;

            // act
            var esperado = 30;

            // asserts
            Assert.AreEqual(esperado, numero1 + numero2, $"A soma de {numero1} com {numero2} é igual ao valor esperado: {esperado}");
            Assert.IsTrue(numero1 + numero2 > 5);
        }

        [DataTestMethod]
        [DataRow(12, 144)]
        [DataRow(25, 75025)]
        [DataRow(150, 626779336)]
        public void Testar_Sequencia_Fibonacci(int numero, int resultado)
        {
            // arrange > act
            var retorno = SequencaFibonacci(numero);

            // asserts
            Assert.IsTrue(retorno > 0);
            Assert.AreEqual(resultado, retorno);
        }
    }
}