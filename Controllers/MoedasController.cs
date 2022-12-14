using System.Net;
using ConsumoAPI_Dolar.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConsumoAPI_Dolar.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MoedasController : ControllerBase
    {
        public readonly IMoedasService _moedasService;

        public MoedasController(IMoedasService moedasService)
        {
            _moedasService = moedasService;
        }

        [HttpGet("bucar/{code}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        
        public async Task<ActionResult> BuscarMoeda([FromRoute] string code)
        {
            var response = await _moedasService.BuscarMoeda(code);

            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }
    }
}