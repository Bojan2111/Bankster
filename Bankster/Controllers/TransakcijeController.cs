using AutoMapper;
using Bankster.Interfaces;
using Bankster.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Bankster.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransakcijeController : ControllerBase
    {
        private readonly ITransakcijaRepository _transakcijaRepository;
        private readonly IMapper _mapper;


        public TransakcijeController(ITransakcijaRepository transakcijaRepository, IMapper mapper)
        {
            _transakcijaRepository = transakcijaRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/api/transakcije")]
        public IActionResult GetTransakcije()
        {
            return Ok(_transakcijaRepository.GetAll().ToList()); //.ProjectTo<TransakcijaDTO>(_mapper.ConfigurationProvider).ToList());
        }


        [HttpGet]
        [Route("/api/transakcije/{id}")]
        public IActionResult GetTransakcija(int id)
        {
            var transakcija = _transakcijaRepository.GetOne(id);

            if (transakcija == null)
            {
                return NotFound();
            }

            return Ok(transakcija);//Ok(_mapper.Map<TransakcijaDTO>(transakcija));
        }

        [HttpPut]
        [Route("/api/transakcije/{id}")]
        public IActionResult PutTransakcija(int id, Transakcija transakcija)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != transakcija.Id)
            {
                return BadRequest();
            }

            try
            {
                _transakcijaRepository.Update(transakcija);
            }
            catch
            {
                return BadRequest();
            }

            return Ok(transakcija);
        }

        [HttpPost]
        [Route("/api/transakcija")]
        //[Authorize]
        public IActionResult PostTransakcija(Transakcija transakcija)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _transakcijaRepository.Add(transakcija);
            return CreatedAtAction("GetTransakcija", new { id = transakcija.Id });//, _mapper.Map<TransakcijaDTO>(transakcija));
        }

        [HttpDelete]
        [Route("/api/transakcije/{id}")]
        //[Authorize]
        public IActionResult DeleteTransakcija(int id)
        {
            var transakcija = _transakcijaRepository.GetOne(id);
            if (transakcija == null)
            {
                return NotFound();
            }

            _transakcijaRepository.Delete(transakcija);
            return NoContent();
        }
    }
}
