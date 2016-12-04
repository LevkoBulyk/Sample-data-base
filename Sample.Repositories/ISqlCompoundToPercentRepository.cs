using Sample.Entities;
using System.Collections.Generic;

namespace Sample.Repositories
{
    interface ISqlPercentToCompoundRepository
    {
        PercentToCompound InsertPercentToCompound(PercentToCompound dopant);
        PercentToCompound GetPercentToCompoundById(int id);
        List<PercentToCompound> GetAllWithCompountId(int id);
        void DeletePercentToCompoundWithId(int id);
    }
}
