using ApiCalcTeste;
using ApiCalcTeste.Controllers;
using ApiCalcTeste.Process;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System.Net.Http;
using Xunit;

namespace XUnitTestProject
{
    public class TesteControllerIntegrationTests
    {

        private readonly TestServer _server;
        private readonly HttpClient _client;

        public TesteControllerIntegrationTests()
        {
            
            _server = new TestServer(new WebHostBuilder()
                                     .UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [Fact]
        public void GetUrlCode()
        {
            var responseString =  _client.GetAsync("/api/teste/showmethecode").Result.Content.ReadAsStringAsync().Result;
            var urlCode = JsonConvert.DeserializeObject<string>(responseString);

            urlCode.Should().Be("https://github.com/bitols/ApiCalcTeste");
        }

        [Fact]
        public void GetValorJuros()
        {
            var responseString = _client.GetAsync("/api/teste/calculajuros/210/12").Result.Content.ReadAsStringAsync().Result;

            var valorJuros = JsonConvert.DeserializeObject<string>(responseString);

            valorJuros.Should().Be("236,63");

        }
    }
}
