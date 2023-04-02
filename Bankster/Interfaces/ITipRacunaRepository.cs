using Bankster.Models;
using System.Linq;

namespace Bankster.Interfaces
{
    public interface ITipRacunaRepository
    {
        void Add(TipRacuna tipRacuna);
        void Update(TipRacuna tipRacuna);
        void Delete(TipRacuna tipRacuna);
        IQueryable<TipRacuna> GetAll();
        TipRacuna GetOne(int id);
    }
}
