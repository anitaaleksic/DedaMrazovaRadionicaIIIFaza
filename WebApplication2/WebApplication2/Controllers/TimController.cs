using DataAccess.DTOs;
using DedaMraz;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiTimove")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetTimove()
        {
            try
            {
                return new JsonResult(DTOManager.VratiSveTimove());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajTim/{idKoord}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddTim([FromBody] TimView tim, int idKoord)
        {
            try
            {
                await DTOManager.DodajTimAsync(tim, idKoord);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiTim/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ObrisiTim(int id)
        {
            try
            {
                await DTOManager.ObrisiTimAsync(id); 
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajTim/{idKoord}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AzurirajTim([FromBody] TimView t, int idKoord)
        {
            try
            {
                await DTOManager.AzurirajTimAsync(t, idKoord); 
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
