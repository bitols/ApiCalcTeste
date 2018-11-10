using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCalcTeste.Process
{
    public interface ICalcTeste
    {
        string GetUrlCode();
        string GetValorJuros(double valor, int tempo);
    }
}
