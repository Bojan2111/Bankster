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
    public class RacuniController : ControllerBase
    {
        private readonly IRacunRepository _racunRepository;
        private readonly IMapper _mapper;


        public RacuniController(IRacunRepository racunRepository, IMapper mapper)
        {
            _racunRepository = racunRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/api/racuni")]
        public IActionResult GetRacuni()
        {
            return Ok(_racunRepository.GetAll().ToList()); //.ProjectTo<RacunDTO>(_mapper.ConfigurationProvider).ToList());
        }


        [HttpGet]
        [Route("/api/racuni/{id}")]
        public IActionResult GetRacun(int id)
        {
            var racun = _racunRepository.GetOne(id);

            if (racun == null)
            {
                return NotFound();
            }

            return Ok(racun);//Ok(_mapper.Map<RacunDTO>(racun));
        }

        [HttpPut]
        [Route("/api/racuni/{id}")]
        public IActionResult PutRacun(int id, Racun racun)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != racun.Id)
            {
                return BadRequest();
            }

            try
            {
                _racunRepository.Update(racun);
            }
            catch
            {
                return BadRequest();
            }

            return Ok(racun);
        }

        [HttpPost]
        [Route("/api/racun")]
        //[Authorize]
        public IActionResult PostRacun(Racun racun)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _racunRepository.Add(racun);
            return CreatedAtAction("GetRacun", new { id = racun.Id });//, _mapper.Map<RacunDTO>(racun));
        }

        [HttpDelete]
        [Route("/api/racuni/{id}")]
        //[Authorize]
        public IActionResult DeleteRacun(int id)
        {
            var racun = _racunRepository.GetOne(id);
            if (racun == null)
            {
                return NotFound();
            }

            _racunRepository.Delete(racun);
            return NoContent();
        }
    }
}
