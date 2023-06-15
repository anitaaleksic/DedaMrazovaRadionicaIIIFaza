using DataAccess.DTOs;
using DedaMraz;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeteController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiDete")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetDecu()
        {
            try
            {
                return new JsonResult(DTOManager.vratiSvuDecu());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajDete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddDete([FromBody] DeteView dete)
        {
            try
            {
                await DTOManager.DodajDeteAsync(dete);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiDete/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ObrisiDete(int id)
        {
            try
            {
                await DTOManager.ObrisiDeteAsync(id); 
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajDete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AzurirajDeteAsync([FromBody] DeteView d)
        {
            try
            {
               await DTOManager.AzurirajDeteAsync(d); 
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
