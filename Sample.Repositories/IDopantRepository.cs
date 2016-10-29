using System.Collections.Generic;
using Sample.Entities;

namespace Sample.Repositories
{
    interface IDopantRepository
    {
        IEnumerable<Dopant> GetAllDopants();
        Dopant InsertDopant(Dopant dopant);
        Dopant SeachDopantByName(string name);
    }
}
