using Bankster.Interfaces;
using Bankster.Models;
using System.Linq;

namespace Bankster.Repository
{
    public class PolRepository : IPolRepository
    {
        private readonly AppDbContext _context;
        public PolRepository(AppDbContext context)
        {
            this._context = context;
        }

        public IQueryable<Pol> GetAll()
        {
            return _context.Polovi;
        }

        public Pol GetOne(int id)
        {
            return _context.Polovi.FirstOrDefault(p => p.Id == id);
        }
    }
}
