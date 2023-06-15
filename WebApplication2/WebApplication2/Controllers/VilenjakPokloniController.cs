using DataAccess.DTOs;
using DedaMraz;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VilenjakPokloniController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiVilenjakeZaPoklone")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetVilenjakePoklone()
        {
            try
            {
                return new JsonResult(DTOManager.VratiSveVilenjakePoklone());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajVilenjakaZaPoklone")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddVilenjakaPoklone([FromBody] VilenjakPokloniView vilenjak)
        {
            try
            {
                await DTOManager.DodajVilenjakaPoklonAsync(vilenjak);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiVilenjakaZaPoklone/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ObrisVilenjakaZaPoklone(int id)
        {
            try
            {
                await DTOManager.ObrisiVilenjakaPokloniAsync(id);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajVilenjakaZaPoklone/{idVilenjaka}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AzurirajVilenjakaZaPoklone([FromBody] VilenjakPokloniView vilenjak, int idVilenjaka)
        {
            try
            {
               await DTOManager.AzurirajVilenjakaPokloniAsync(vilenjak, idVilenjaka); 
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}

