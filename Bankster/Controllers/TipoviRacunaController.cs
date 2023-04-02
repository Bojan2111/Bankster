using AutoMapper;
using Bankster.Interfaces;
using Bankster.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Bankster.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoviRacunaController : ControllerBase
    {
        private readonly ITipRacunaRepository _tipRacunaRepository;


        public TipoviRacunaController(ITipRacunaRepository tipRacunaRepository)
        {
            _tipRacunaRepository = tipRacunaRepository;
        }

        [HttpGet]
        [Route("/api/tipoviRacuna")]
        public IActionResult GetTipoviRacuna()
        {
            return Ok(_tipRacunaRepository.GetAll().ToList());
        }


        [HttpGet]
        [Route("/api/tipoviRacuna/{id}")]
        public IActionResult GetTipRacuna(int id)
        {
            var tipRacuna = _tipRacunaRepository.GetOne(id);

            if (tipRacuna == null)
            {
                return NotFound();
            }

            return Ok(tipRacuna);
        }

        [HttpPut]
        [Route("/api/tipoviRacuna/{id}")]
        public IActionResult PutTipRacuna(int id, TipRacuna tipRacuna)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipRacuna.Id)
            {
                return BadRequest();
            }

            try
            {
                _tipRacunaRepository.Update(tipRacuna);
            }
            catch
            {
                return BadRequest();
            }

            return Ok(tipRacuna);
        }

        [HttpPost]
        [Route("/api/tipRacuna")]
        //[Authorize]
        public IActionResult PostTipRacuna(TipRacuna tipRacuna)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _tipRacunaRepository.Add(tipRacuna);
            return CreatedAtAction("GetTipRacuna", new { id = tipRacuna.Id });
        }

        [HttpDelete]
        [Route("/api/tipoviRacuna/{id}")]
        //[Authorize]
        public IActionResult DeleteTipRacuna(int id)
        {
            var tipRacuna = _tipRacunaRepository.GetOne(id);
            if (tipRacuna == null)
            {
                return NotFound();
            }

            _tipRacunaRepository.Delete(tipRacuna);
            return NoContent();
        }
    }
}
