using Bankster.Interfaces;
using Bankster.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Bankster.Repository
{
    public class RacunRepository : IRacunRepository
    {
        private readonly AppDbContext _context;
        public RacunRepository(AppDbContext context)
        {
            this._context = context;
        }
        public void Add(Racun racun)
        {
            _context.Racuni.Add(racun);
            _context.SaveChanges();
        }

        public void Delete(Racun racun)
        {
            _context.Racuni.Remove(racun);
            _context.SaveChanges();
        }

        public IQueryable<Racun> GetAll()
        {
            return _context.Racuni.Include(r => r.Banka).Include(r => r.Klijent).Include(r => r.Banka).Include(r => r.TipRacuna);
        }

        public Racun GetOne(int id)
        {
            return _context.Racuni.Include(r => r.Banka).Include(r => r.Klijent).Include(r => r.Banka).Include(r => r.TipRacuna).FirstOrDefault(r => r.Id == id);
        }

        public void Update(Racun racun)
        {
            _context.Entry(racun).State = EntityState.Modified;

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
