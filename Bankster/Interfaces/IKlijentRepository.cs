using Bankster.Models;
using System.Linq;

namespace Bankster.Interfaces
{
    public interface IKlijentRepository
    {
        void Add(Klijent klijent);
        void Update(Klijent klijent);
        void Delete(Klijent klijent);
        IQueryable<Klijent> GetAll();
        Klijent GetOne(int id);
    }
}
