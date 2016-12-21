using Sample.BusinessEntity;
using System.Collections.Generic;

namespace Sample.Servises
{
    interface IMatrixService
    {
        void SetMatrixWithIdInto(BusinessMatrix matrixGroup, int id);
        void SetPercentageWiyhNumberInto(BusinessMatrix matrixGroup, double number);
        void SetPercentageToCompoundWithCompoundIdInto(BusinessMatrix matrixGroup, int compoundId);

        BusinessMatrix GetGroupByPercToCompId(int percToCompId);
        List<BusinessMatrix> GetAllForCompoundId(int compoundid);
    }
}
