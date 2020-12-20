using API.Taxas.Model;
using Microsoft.AspNetCore.Mvc;

namespace API.Taxas.Controllers
{
    [Route("/")]
    [ApiController]
    public class JurosController : ControllerBase
    {
        [HttpGet]
        [Route("taxaJuros")]
        public IActionResult Get()
        {
            try
            {
                return Ok(new { juros = JurosEntity.JurosAtual });
            }
            catch (System.Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}
