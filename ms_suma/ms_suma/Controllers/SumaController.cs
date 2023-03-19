using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ms_suma.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SumaController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Sumar(SumandosDto sumandos)
        {
            sumandos.resultado=sumandos.sumando1+sumandos.sumando2;
            return Ok(sumandos);
        }
    
    }
}
