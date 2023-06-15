using DataAccess.DTOs;
using DedaMraz;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MagicnaVestinaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiMagicneVestine")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetMagicneVestine()
        {
            try
            {
                  return new JsonResult(DTOManager.VratiSveMagicneVestine()); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajMagicnuVestinu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddMagicnuVestinu([FromBody] MagicnaVestinaView magicnavestina)
        {
            try
            {
                await DTOManager.DodajMagicnuVestinuASync(magicnavestina);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiMagicnuVestinu/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ObrisiMagicnuVestinu(string id) //ovde je string
        {
            try
            {
                await DTOManager.ObrisiMagicnuVestinuAsync(id);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        //nema azuriraj jer ima samo string id


        //[HttpPut]
        //[Route("AzurirajMagicnuVestinu")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public async Task<IActionResult> AzurirajMagicnuVestinu([FromBody] MagicnaVestinaView m)
        //{
        //    try
        //    {
        //        await DTOManager.AzurirajMagicnuVestinuAsync(m);
        //        return Ok();

        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.ToString());
        //    }
        //}

    }
}

