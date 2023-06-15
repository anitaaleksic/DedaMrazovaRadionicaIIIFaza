using DataAccess.DTOs;
using DedaMraz;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TovarController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiTovare")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetTovare()
        {
            try
            {
                return new JsonResult(DTOManager.VratiSveTovare());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajTovar")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddTovar([FromBody] TovarView tovar)
        {
            try
            {
                await DTOManager.DodajTovarAsync(tovar);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiTovar/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ObrisiTovar(int id)
        {
            try
            {
                await DTOManager.ObrisiTovarAsync(id); 
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajTovar")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AzurirajTovar([FromBody] TovarView t)
        {
            try
            {
                await DTOManager.AzurirajTovarAsync(t); 
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
