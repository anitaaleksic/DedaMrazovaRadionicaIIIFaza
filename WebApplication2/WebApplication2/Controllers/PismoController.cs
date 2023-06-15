using DataAccess.DTOs;
using DedaMraz;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PismoController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiPismo")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPisma()
        {
            try
            {
                return new JsonResult(DTOManager.VratiSvaPisma());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajPismo/{idDeteta}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddPismo([FromBody] PismoView pismo, int idDeteta)
        {
            try
            {
                await DTOManager.PosaljiPismoAsync(pismo, idDeteta);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiPismo/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ObrisiPismo(int id)
        {
            try
            {
                await DTOManager.ObrisiPismoAsync(id); 
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajPismo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AzurirajPismo([FromBody] PismoView p)
        {
            try
            {
                await DTOManager.AzurirajPismoAsync(p); 
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}

