using DataAccess.DTOs;
using DedaMraz;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeoRadioniceController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiDeloveRadionice")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetDeloveRadionice()
        {
            //var deloviRadionice =  DTOManager.vratiSveDeloveRadioniceAsync();

            //if (deloviRadionice.IsError)
            //{
            //    return BadRequest(deloviRadionice.Error);
            //}

            //return Ok(deloviRadionice.Data);
            try
            {
                return new JsonResult(DTOManager.vratiSveDeloveRadioniceAsync());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajDeoRadionice/{sefID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddDeoRadionice([FromBody] DeoRadioniceView deoRadionice, int sefID)
        {
            try
            {
                await DTOManager.DodajDeoRadioniceAsync(deoRadionice, sefID);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiDeoRadionice/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ObrisiDeoRadionice(int id)
        {
            try
            {
                await DTOManager.obrisiDeoRadioniceAsync(id);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajDeoRadionice/{vilenjakID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AzurirajDeoRadioniceAsync([FromBody] DeoRadioniceView d, int vilenjakID)
        {
            try
            {
                await DTOManager.azurirajDeoRadioniceAsync(d, vilenjakID);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}