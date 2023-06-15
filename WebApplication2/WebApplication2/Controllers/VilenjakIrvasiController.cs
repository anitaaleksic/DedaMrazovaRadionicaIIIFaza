using DataAccess.DTOs;
using DedaMraz;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VilenjakIrvasiController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiVilenjakeZaIrvase")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetVilenjakeIrvase()
        {
            try
            {
                return new JsonResult(DTOManager.VratiSveVilenjakeIrvase());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajVilenjakaZaIrvase/{irvasID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddVilenjakaIrvase([FromBody] VilenjakIrvasiView vilenjak, int irvasID)
        {
            try
            {
                 await DTOManager.DodajVilenjakaIrvasAsync(vilenjak, irvasID); // fale parametri
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiVilenjakaZaIrvase/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ObrisVilenjakaZaIrvase(int id)
        {
            try
            {
                await DTOManager.ObrisiVilenjakaIrvasAsync(id);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajVilenjakaZaIrvase/{idIrvasa}/{idVilenjaka}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AzurirajVilenjakaZaIrvase([FromBody] VilenjakIrvasiView vilenjak, int idIrvasa, int idVilenjaka)
        {
            try
            {
                await DTOManager.AzurirajVilenjakaIrvasiAsync(vilenjak,idIrvasa, idVilenjaka ); // fali funkcija
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}

