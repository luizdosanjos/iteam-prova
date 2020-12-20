using API.Calculo.Input;
using API.Calculo.Model;
using Microsoft.AspNetCore.Mvc;
using System;


namespace API.Calculo.Controllers
{
    [Route("/")]
    [ApiController]
    public class JurosController : ControllerBase
    {
        [HttpGet]
        [Route("calculaJuros")]
        public IActionResult CalculaJuros([FromQuery] JurosInput jurosInput)
        {
            try
            {
                JurosEntity juros = JurosEntity.CriarJurosComTempoEValorInicial(jurosInput.TempoEmMeses, jurosInput.ValorInicial);
                return Ok(new { valor = juros.CalculoDeJuros() });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }


}
