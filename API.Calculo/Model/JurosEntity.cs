using System;

namespace API.Calculo.Model
{
    public sealed class JurosEntity
    {
        public JurosEntity()
        {

        }
        private JurosEntity(int tempoEmMeses, double valorInicial)
        {
            Juros = JurosService.GetJurosAtual().Juros;
            TempoEmMeses = tempoEmMeses;
            ValorInicial = valorInicial;
        }

        public static JurosEntity CriarJurosComTempoEValorInicial(int tempoEmMeses, double valorInicial)
        {
            return new JurosEntity(tempoEmMeses, valorInicial);
        }

        public double Juros { get; set; }
        public double ValorInicial { get; set; }
        public int TempoEmMeses { get; set; }

        public string CalculoDeJuros()
        {
            const int CASA_DECIMAL_ARREDONDAMENTO = 2;
            const int DIVISAO_CALCULO = 100000000;
            double potencia = Math.Pow(ValorInicial * (1 + Juros), TempoEmMeses);
            return Math.Round(potencia / DIVISAO_CALCULO, CASA_DECIMAL_ARREDONDAMENTO).ToString("F");
        }
    }
}
