using Bankster.Models;
using System.Linq;

namespace Bankster.Interfaces
{
    public interface IRacunRepository
    {
        void Add(Racun racun);
        void Update(Racun racun);
        void Delete(Racun racun);
        IQueryable<Racun> GetAll();
        Racun GetOne(int id);
    }
}
