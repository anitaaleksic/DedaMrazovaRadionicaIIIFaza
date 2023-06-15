using DataAccess.DTOs;
using DedaMraz;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VilenjakIgrackeController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiVilenjakeZaIgracke")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetVilenjakeIgracke()
        {
            try
            {
                return new JsonResult(DTOManager.VratiSveVilenjakeIgracke());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajVilenjakaZaIgracke/{mentorID}/{deoradioniceID}/{timID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddVilenjakaIgracke([FromBody] VilenjakIgrackeView vilenjak, int mentorID, int deoradioniceID, int timID)
        {
            try
            {
               await DTOManager.DodajVilenjakaIgrackeAsync(vilenjak, mentorID, deoradioniceID, timID); 
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiVilenjakaZaIgracke/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ObrisVilenjakaZaIgracke(int id)
        {
            try
            {
                await DTOManager.ObrisiVilenjakaIgrackeAsync(id);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajVilenjakaZaIgracke/{idVilenjaka}/{idTim}/{idMentor}/{idRadionica}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AzurirajVilenjakaZaIgracke([FromBody] VilenjakIgrackeView vilenjak, int idVilenjaka, int idTim, int idMentor, int idRadionica)
        {
            try
            {
                await DTOManager.AzurirajVilenjakaIgrackeAsync(vilenjak, idVilenjaka, idTim, idMentor, idRadionica);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
