using System.Collections.Generic;

namespace Sample.BusinessEntity
{
    interface IBusinessCompound
    {
        BusinessCompound GetCompoundById(int id);
        List<BusinessCompound> GetAllCompounds();
        List<BusinessCompound> SearchCompoundWithNameLike(string name);
        BusinessCompound UpdateCompoundWithId(int id, BusinessCompound compound);
        void DeleteCompoundWithId(int id);
    }
}
