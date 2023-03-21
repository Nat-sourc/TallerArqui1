using Microsoft.AspNetCore.Mvc;
using PapAPI.Entity.Dominio;
using SumaAPI.BAL.Dominio;
using System.Security.Claims;

namespace SumaAPI.Rest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RestaController : Controller
    {
        ILogger _logger;
        RestaBAL<Resta> _logicaBAL;

        public RestaController(ILogger<RestaController> _logger, RestaBAL<Resta> _logicaBAL)
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
        public async Task<IActionResult> Restar(Resta resta)
        {
            
            
            return Ok(this._logicaBAL.Add(resta));
        }


       
    }
}
