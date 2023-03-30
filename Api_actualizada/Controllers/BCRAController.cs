using Api_actualizada.Modelo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_actualizada.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BCRAController : ControllerBase
    {
        [HttpGet("{input}")]
        public IActionResult GetString(string input)
        {
            ResultadoBCRA resultado = new ResultadoBCRA();
            resultado.Fecha = "27/03/2023";
            resultado.Informacion = input.ToUpper();
            return Ok(resultado);
        }
    }
}
