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
    public class ShowMeTheCodeController : Controller
    {
        // GET api/showmethecode
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Environment.GetEnvironmentVariable("URL_CODE"));
        }
    }
}