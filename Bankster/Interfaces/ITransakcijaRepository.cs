using Bankster.Models;
using System.Linq;

namespace Bankster.Interfaces
{
    public interface ITransakcijaRepository
    {
        void Add(Transakcija transakcija);
        void Update(Transakcija transakcija);
        void Delete(Transakcija transakcija);
        IQueryable<Transakcija> GetAll();
        Transakcija GetOne(int id);
    }
}
