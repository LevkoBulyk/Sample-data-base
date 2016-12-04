using Sample.Entities;
using System.Collections.Generic;

namespace Sample.Repositories
{
    interface ISqlPercentToCompoundRepository
    {
        PercentToCompound GetPercentToCompoundById(int id);
        List<PercentToCompound> GetAllWithCompountId(int id);
        PercentToCompound InsertPercentToCompound(PercentToCompound dopant);
        void DeletePercentToCompoundWithId(int id);
    }
}
