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
    public class CalculaJurosController : Controller
    {

        // GET api/calculajuros
        [HttpGet("valorinicial={valor}&meses={tempo}")]
        public IActionResult Get(
            [FromServices] ICalcTeste calcTeste,
             double valor,
             int tempo
            )
        {
            var valorFinal = calcTeste.GetValorJuros(valor, tempo);
            return Ok(valorFinal);
        }

    }
}