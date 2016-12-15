using Sample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Repositories
{
    public interface ISqlCompoundRepository
    {
        Compound GetCompoundById(int id);
        List<Compound> GetAllCompounds();
        Compound InsertCompound(Compound compound);
        Compound UpdateCompound(int id, Compound compound);
        void DeleteCompound(int id);
    }
}
