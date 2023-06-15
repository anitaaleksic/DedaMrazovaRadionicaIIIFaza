using DataAccess.DTOs;
using DedaMraz;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VilenjakTovarController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiVilenjakeZaTovar")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetVilenjakeTovar()
        {
            try
            {
                return new JsonResult(DTOManager.VratiSveVilenjakeTovare());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajVilenjakaZaTovar/{tovarID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddVilenjakaTovar([FromBody] VilenjakTovarView vilenjak, int tovarID)
        {
            try
            {
               await DTOManager.DodajVilenjakaTovarAsync(vilenjak, tovarID); //fali funkcija
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiVilenjakaZaTovar/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ObrisVilenjakaZaTovar(int id)
        {
            try
            {
                await DTOManager.ObrisiVilenjakaTovarAsync(id);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajVilenjakaZaTovar/{idVilenjaka}/{idTovara}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AzurirajVilenjakaZaTovar([FromBody] VilenjakTovarView vilenjak, int idVilenjaka, int idTovara)
        {
            try
            {
                await DTOManager.AzurirajVilenjakaZaTovarAsync(vilenjak, idVilenjaka, idTovara); 
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}


