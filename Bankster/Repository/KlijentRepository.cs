using Bankster.Interfaces;
using Bankster.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Bankster.Repository
{
    public class KlijentRepository : IKlijentRepository
    {
        private readonly AppDbContext _context;
        public KlijentRepository(AppDbContext context)
        {
            this._context = context;
        }
        public void Add(Klijent klijent)
        {
            _context.Klijenti.Add(klijent);
            _context.SaveChanges();
        }

        public void Delete(Klijent klijent)
        {
            _context.Klijenti.Remove(klijent);
            _context.SaveChanges();
        }

        public IQueryable<Klijent> GetAll()
        {
            return _context.Klijenti;
        }

        public Klijent GetOne(int id)
        {
            return _context.Klijenti.FirstOrDefault(k => k.Id == id);
        }

        public void Update(Klijent klijent)
        {
            _context.Entry(klijent).State = EntityState.Modified;

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
