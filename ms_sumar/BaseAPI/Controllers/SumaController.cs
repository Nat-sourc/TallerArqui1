using Microsoft.AspNetCore.Mvc;
using PapAPI.Entity.Dominio;
using SumaAPI.BAL.Dominio;
using System.Security.Claims;

namespace SumaAPI.Rest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SumaController : Controller
    {
        ILogger _logger;
        SumaBAL<Suma> _logicaBAL;

        public SumaController(ILogger<SumaController> _logger, SumaBAL<Suma> _logicaBAL)
        {
            this._logicaBAL = _logicaBAL;
            this._logger = _logger;
        }


        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(this._logicaBAL.GetById(id));
        }

       

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
           
            return Ok(this._logicaBAL.GetAll());
        }

       


        [HttpPost]
        public async Task<IActionResult> Sumar(Suma suma)
        {
            
            
            return Ok(this._logicaBAL.Add(suma));
        }


       
    }
}
