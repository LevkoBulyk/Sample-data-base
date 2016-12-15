using System.Collections.Generic;
using Sample.Entities;

namespace Sample.Repositories
{
    public interface IDopantRepository
    {
        IEnumerable<Dopant> GetAllDopants();
        Dopant InsertDopant(Dopant dopant);
        Dopant GetDopantById(int id);
        IEnumerable<Dopant> SeachDopantsByName(string name);
    }
}
