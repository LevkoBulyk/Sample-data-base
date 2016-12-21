using Sample.BusinessEntity;
using System.Collections.Generic;

namespace Sample.Servises
{
    interface ICompoundService
    {
        BusinessCompound GetCompoundWithId(int id);
        IEnumerable<BusinessCompound> GetAllCompounds();
        IEnumerable<BusinessCompound> SearchCompoundWithNameLike(string name);
        BusinessCompound InsertCompound(BusinessCompound compound);
        BusinessCompound UpdateCompoundWithId(int id, BusinessCompound compound);
        void DeleteCompoundWithId(int id);
    }
}
