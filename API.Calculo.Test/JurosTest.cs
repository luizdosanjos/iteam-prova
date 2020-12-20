using NUnit.Framework;
using API.Calculo.Model;

namespace API.Calculo.Test
{
    public sealed class JurosTest
    {
        [Test]
        public void Deve_Fazer_O_Calculo_E_Retornar_O_Valor_Correto()
        {
            JurosEntity juros = new JurosEntity()
            {
                Juros = 0.01,
                ValorInicial = 100,
                TempoEmMeses = 5
            };

            string resultadoCalculo = juros.CalculoDeJuros();

            Assert.AreEqual("105,10", resultadoCalculo);
        }

        [Test]
        public void Deve_Fazer_O_Calculo_E_Retornar_O_Valor_Incorreto()
        {
            JurosEntity juros = new JurosEntity()
            {
                Juros = 0.01,
                ValorInicial = 100,
                TempoEmMeses = 6
            };

            string resultadoCalculo = juros.CalculoDeJuros();

            Assert.AreNotEqual("105,10", resultadoCalculo);
        }
    }
}