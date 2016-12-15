using Sample.Entities;
using System.Collections.Generic;

namespace Sample.Repositories
{
    public interface ISqlPercentToCompoundRepository
    {
        PercentToCompound GetPercentToCompoundById(int id);
        IEnumerable<PercentToCompound> GetAllPercentToCompound();
        IEnumerable<PercentToCompound> GetAllWithCompountId(int id);
        PercentToCompound InsertPercentToCompound(PercentToCompound dopant);
        void DeletePercentToCompoundWithId(int id);
    }
}
