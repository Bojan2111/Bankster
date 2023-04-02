using Bankster.Models;
using System.Linq;

namespace Bankster.Interfaces
{
    public interface IBankaRepository
    {
        void Add(Banka banka);
        void Update(Banka banka);
        void Delete(Banka banka);
        IQueryable<Banka> GetAll();
        Banka GetOne(int id);
    }
}
