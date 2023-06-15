using DataAccess.DTOs;
using DedaMraz;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IgrackaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiIgracke")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetIgracke()
        {
            try
            {
                return new JsonResult(DTOManager.VratiSveIgrackeAsync());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajIgracku/{zeljaID}/{vilenjakID}/{poklonID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddIgracku([FromBody] IgrackaView igracka, int zeljaID,int vilenjakID, int poklonID)
        {
            try
            {
                await DTOManager.DodajIgrackuAsync(igracka, zeljaID, vilenjakID, poklonID); //fale parametri
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiIgracku/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ObrisiIgracku(int id)
        {
            try
            {
                await DTOManager.ObrisiIgrackuAsync(id); //fali brisanje veza
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajIgracku")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AzurirajIgracku([FromBody] IgrackaView i)
        {
            try
            {
                await DTOManager.AzurirajIgrackuAsync(i); 
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}


