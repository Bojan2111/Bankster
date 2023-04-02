using Bankster.Models;
using System.Linq;

namespace Bankster.Interfaces
{
    public interface IPolRepository
    {
        void Add(Pol pol);
        void Update(Pol pol);
        void Delete(Pol pol);
        IQueryable<Pol> GetAll();
        Pol GetOne(int id);
    }
}
