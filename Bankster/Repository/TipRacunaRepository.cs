using Bankster.Interfaces;
using Bankster.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Bankster.Repository
{
    public class TipRacunaRepository : ITipRacunaRepository
    {
        private readonly AppDbContext _context;
        public TipRacunaRepository(AppDbContext context)
        {
            this._context = context;
        }
        public void Add(TipRacuna tipRacuna)
        {
            _context.TipoviRacuna.Add(tipRacuna);
            _context.SaveChanges();
        }

        public void Delete(TipRacuna tipRacuna)
        {
            _context.TipoviRacuna.Remove(tipRacuna);
            _context.SaveChanges();
        }

        public IQueryable<TipRacuna> GetAll()
        {
            return _context.TipoviRacuna;
        }

        public TipRacuna GetOne(int id)
        {
            return _context.TipoviRacuna.FirstOrDefault(tr => tr.Id == id);
        }

        public void Update(TipRacuna tipRacuna)
        {
            _context.Entry(tipRacuna).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
    }
}
