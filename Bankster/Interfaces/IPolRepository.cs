using Bankster.Models;
using System.Linq;

namespace Bankster.Interfaces
{
    public interface IPolRepository
    {
        IQueryable<Pol> GetAll();
        Pol GetOne(int id);
    }
}
