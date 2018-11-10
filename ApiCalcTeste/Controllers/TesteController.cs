using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCalcTeste.Process;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCalcTeste.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class TesteController : Controller
    {
        [HttpGet("showmethecode")]
        public IActionResult GetUrlCode(
            [FromServices] ICalcTeste calcTeste
            )
        {
            var urlCode = calcTeste.GetUrlCode();

            var result = new
            {
                urlCode = urlCode
            };
            return Ok(result);

        }

        [HttpGet("calculajuros/{valorInicial}/{meses}")]
        public IActionResult GetJuros(
            [FromServices] ICalcTeste calcTeste,
             double valorInicial,
             int meses
            )
        {
            var valorJuros = calcTeste.GetValorJuros(valorInicial, meses);
            var result = new
            {
                valorJuros = valorJuros
            };
            return Ok(result);
        }
    }
}