using AutoMapper;
using AutoMapper.QueryableExtensions;
using Bankster.Interfaces;
using Bankster.Models;
using Bankster.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Bankster.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KlijentiController : ControllerBase
    {
        private readonly IKlijentRepository _klijentRepository;
        private readonly IMapper _mapper;


        public KlijentiController(IKlijentRepository klijentRepository, IMapper mapper)
        {
            _klijentRepository = klijentRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/api/klijenti")]
        public IActionResult GetKlijenti()
        {
            return Ok(_klijentRepository.GetAll().ProjectTo<KlijentDTO>(_mapper.ConfigurationProvider).ToList());
        }


        [HttpGet]
        [Route("/api/klijenti/{id}")]
        public IActionResult GetKlijent(int id)
        {
            var klijent = _klijentRepository.GetOne(id);

            if (klijent == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<KlijentDTO>(klijent));
        }

        [HttpPut]
        [Route("/api/klijenti/{id}")]
        public IActionResult PutKlijent(int id, Klijent klijent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != klijent.Id)
            {
                return BadRequest();
            }

            try
            {
                _klijentRepository.Update(klijent);
            }
            catch
            {
                return BadRequest();
            }

            return Ok(klijent);
        }

        [HttpPost]
        [Route("/api/klijent")]
        //[Authorize]
        public IActionResult PostKlijent(Klijent klijent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _klijentRepository.Add(klijent);
            return CreatedAtAction("GetKlijent", new { id = klijent.Id }, _mapper.Map<KlijentDTO>(klijent));
        }

        [HttpDelete]
        [Route("/api/klijenti/{id}")]
        //[Authorize]
        public IActionResult DeleteKlijent(int id)
        {
            var klijent = _klijentRepository.GetOne(id);
            if (klijent == null)
            {
                return NotFound();
            }

            _klijentRepository.Delete(klijent);
            return NoContent();
        }
    }
}
