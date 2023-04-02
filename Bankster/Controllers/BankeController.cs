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
    public class BankeController : ControllerBase
    {
        private readonly IBankaRepository _bankaRepository;
        private readonly IMapper _mapper;


        public BankeController(IBankaRepository bankaRepository, IMapper mapper)
        {
            _bankaRepository = bankaRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/api/banke")]
        public IActionResult GetBanke()
        {
            return Ok(_bankaRepository.GetAll().ToList()); //.ProjectTo<BankaDTO>(_mapper.ConfigurationProvider).ToList());
        }


        [HttpGet]
        [Route("/api/banke/{id}")]
        public IActionResult GetBanka(int id)
        {
            var banka = _bankaRepository.GetOne(id);

            if (banka == null)
            {
                return NotFound();
            }

            return Ok(banka);//Ok(_mapper.Map<BankaDTO>(banka));
        }

        [HttpPut]
        [Route("/api/banke/{id}")]
        public IActionResult PutBanka(int id, Banka banka)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != banka.Id)
            {
                return BadRequest();
            }

            try
            {
                _bankaRepository.Update(banka);
            }
            catch
            {
                return BadRequest();
            }

            return Ok(banka);
        }

        [HttpPost]
        [Route("/api/banka")]
        //[Authorize]
        public IActionResult PostBanka(Banka banka)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _bankaRepository.Add(banka);
            return CreatedAtAction("GetBanka", new { id = banka.Id });//, _mapper.Map<BankaDTO>(banka));
        }

        [HttpDelete]
        [Route("/api/banke/{id}")]
        //[Authorize]
        public IActionResult DeleteBanka(int id)
        {
            var banka = _bankaRepository.GetOne(id);
            if (banka == null)
            {
                return NotFound();
            }

            _bankaRepository.Delete(banka);
            return NoContent();
        }
    }
}
