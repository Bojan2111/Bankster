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
    public class PoloviController : ControllerBase
    {
        private readonly IPolRepository _polRepository;


        public PoloviController(IPolRepository polRepository)
        {
            _polRepository = polRepository;
        }

        [HttpGet]
        [Route("/api/polovi")]
        public IActionResult GetPolovi()
        {
            return Ok(_polRepository.GetAll().ToList());
        }


        [HttpGet]
        [Route("/api/polovi/{id}")]
        public IActionResult GetPol(int id)
        {
            var pol = _polRepository.GetOne(id);

            if (pol == null)
            {
                return NotFound();
            }

            return Ok(pol);
        }
    }
}
