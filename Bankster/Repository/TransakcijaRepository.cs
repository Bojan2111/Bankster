using Bankster.Interfaces;
using Bankster.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Bankster.Repository
{
    public class TransakcijaRepository : ITransakcijaRepository
    {
        private readonly AppDbContext _context;
        public TransakcijaRepository(AppDbContext context)
        {
            this._context = context;
        }
        public void Add(Transakcija transakcija)
        {
            _context.Transakcije.Add(transakcija);
            _context.SaveChanges();
        }

        public void Delete(Transakcija transakcija)
        {
            _context.Transakcije.Remove(transakcija);
            _context.SaveChanges();
        }

        public IQueryable<Transakcija> GetAll()
        {
            return _context.Transakcije;
        }

        public Transakcija GetOne(int id)
        {
            return _context.Transakcije.FirstOrDefault(t => t.Id == id);
        }

        public void Update(Transakcija transakcija)
        {
            _context.Entry(transakcija).State = EntityState.Modified;

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
