using DataAccess.DTOs;
using DedaMraz;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PesmaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiPesme")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPesme()
        {
            try
            {
                return new JsonResult(DTOManager.VratiSvePesme());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajPesmu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddPesmu([FromBody] PesmaView pesma)
        {
            try
            {
                await DTOManager.DodajPesmuAsync(pesma);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiPesmu/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ObrisiPesmu(int id)
        {
            try
            {
                await DTOManager.ObrisiPesmuAsync(id); 
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajPesmu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AzurirajPesmu([FromBody] PesmaView p)
        {
            try
            {
               await DTOManager.AzurirajPesmuAsync(p); 
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}

