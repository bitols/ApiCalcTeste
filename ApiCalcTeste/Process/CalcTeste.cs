using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCalcTeste.Process
{
    public class CalcTeste : ICalcTeste
    {
        private const string URL_CODE = "https://github.com/bitols/ApiCalcTeste";
        private const double VALOR_JUROS = 0.01;

        public string GetUrlCode()
        {
            return URL_CODE;
        }

        public string GetValorJuros(double valor, int tempo)
        {
            
            var vlrFinal = Math.Truncate(100 * (valor * Math.Pow((1 + VALOR_JUROS), tempo))) / 100;

            return vlrFinal.ToString("0.00");
        }
    }
}
