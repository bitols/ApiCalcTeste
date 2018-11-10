using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCalcTeste.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CalculaJurosController : Controller
    {

        // GET api/calculajuros
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

    }
}