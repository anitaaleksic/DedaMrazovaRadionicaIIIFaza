using DataAccess.DTOs;
using DedaMraz;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ZeljaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiZelje")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetZelje()
        {
            try
            {
                return new JsonResult(DTOManager.VratiSveZelje());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajZelju/{idPisma}/{idIgracke}/{sifraPoklona}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddZelju([FromBody] ZeljaView zelja, int idPisma, int idIgracke, int sifraPoklona)
        {
            try
            {
               await  DTOManager.DodajZeljuAsync(zelja, idPisma, idIgracke, sifraPoklona); 
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiZelju/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ObrisZelju(int id)
        {
            try
            {
                await DTOManager.ObrisiZeljuAsync(id); 
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajZelju/{pismoID}/{sifraPok}/{igrackaID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AzurirajZelju([FromBody] ZeljaView zelja, int pismoID, int sifraPok, int igrackaID)
        {
            try
            {
                await DTOManager.AzurirajZeljuAsync(zelja, pismoID, sifraPok, igrackaID);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}



