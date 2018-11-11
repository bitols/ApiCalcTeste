using ApiCalcTeste.Controllers;
using ApiCalcTeste.Process;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace XUnitTestProject
{
    public class TesteControllerUnitTests
    {
        [Fact]
        public void GetUrlCode()
        {
            var controller = new TesteController();

            var result = controller.GetUrlCode(new CalcTeste());
            var okResult = result.Should().BeOfType<OkObjectResult>().Subject;
            var urlCode = okResult.Value.Should().BeAssignableTo<string>().Subject;

            urlCode.Should().Be("https://github.com/bitols/ApiCalcTeste");
        }

        [Fact]
        public void GetValorJuros()
        {
            var controller = new TesteController();

            var result = controller.GetJuros(new CalcTeste(), 210, 12);
            var okResult = result.Should().BeOfType<OkObjectResult>().Subject;
            var valorJuros = okResult.Value.Should().BeAssignableTo<string>().Subject;

            valorJuros.Should().Be("236,63");

        }
    }
}
