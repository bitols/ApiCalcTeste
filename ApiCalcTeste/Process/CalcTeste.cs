using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCalcTeste.Process
{
    public class CalcTeste : ICalcTeste
    {
        public CalcTeste()
        {

        }

        public string GetUrlCode()
        {
            return Environment.GetEnvironmentVariable("URL_CODE");
        }

        public string GetValorJuros(double valor, int tempo)
        {
            var vlrJuros = Convert.ToDouble(Environment.GetEnvironmentVariable("VALOR_JUROS"));
            var vlrFinal = Math.Truncate(100 * (valor * Math.Pow((1 + vlrJuros), tempo))) / 100;

            return vlrFinal.ToString("0.00");
        }
    }
}
