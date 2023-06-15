using DataAccess.DTOs;
using DedaMraz;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PoklonController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiPoklon")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPoklone()
        {
            try
            {
                return new JsonResult(DTOManager.VratiSvePoklone());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajPoklon/{tovarID}/{vilenjakID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddPoklon([FromBody] PoklonView poklon, int tovarID, int vilenjakID)
        {
            try
            {
                await DTOManager.DodajPoklonAsync(poklon, tovarID, vilenjakID); //fale parametri*/
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiPoklon/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ObrisiPoklon(int id)
        {
            try
            {
                await DTOManager.ObrisiPoklonAsync(id);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajPoklon")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AzurirajPoklon([FromBody] PoklonView p)
        {
            try
            {
                await DTOManager.AzurirajPoklonAsync(p); 
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}

