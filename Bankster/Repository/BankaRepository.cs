using Bankster.Interfaces;
using Bankster.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Bankster.Repository
{
    public class BankaRepository : IBankaRepository
    {
        private readonly AppDbContext _context;
        public BankaRepository(AppDbContext context)
        {
            this._context = context;
        }
        public void Add(Banka banka)
        {
            _context.Banke.Add(banka);
            _context.SaveChanges();
        }

        public void Delete(Banka banka)
        {
            _context.Banke.Remove(banka);
            _context.SaveChanges();
        }

        public IQueryable<Banka> GetAll()
        {
            return _context.Banke;
        }

        public Banka GetOne(int id)
        {
            return _context.Banke.FirstOrDefault(b => b.Id == id);
        }

        public void Update(Banka banka)
        {
            _context.Entry(banka).State = EntityState.Modified;

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
