using DataAccess.DTOs;
using DedaMraz;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IrvasController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiIrvase")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetIrvase()
        {
            try
            {
                return new JsonResult(DTOManager.vratiSveIrvase());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajIrvasa")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddIrvasa([FromBody] IrvasView irvas)
        {
            try
            {
                await DTOManager.DodajIrvasaAsync(irvas);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiIrvasa/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ObrisiIrvasa(int id)
        {
            try
            {
                await DTOManager.ObrisiIrvasaAsync(id);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajIrvasa")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AzurirajIrvasa([FromBody] IrvasView i)
        {
            try
            {
                await DTOManager.AzurirajIrvasaAsync(i);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
