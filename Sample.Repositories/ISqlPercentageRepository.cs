using Sample.Entities;
using System.Collections.Generic;

namespace Sample.Repositories
{
    interface ISqlPercentageRepository
    {
        Percentage GetPersentageById(int id);
        Percentage GetPercentageWithValues(double number, int? matrixId, int? dopantId);
        IEnumerable<Percentage> GetAllPercents();
        Percentage InsertPersentage(Percentage dopant);
        Percentage UpdatePercentage(int id, Percentage percentage);
        void DeletePercentageWithId(int Id);
    }
}
