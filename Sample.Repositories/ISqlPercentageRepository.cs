using Sample.Entities;

namespace Sample.Repositories
{
    interface ISqlPercentageRepository
    {
        Percentage GetPersentageById(int id);
        Percentage InsertPersentage(Percentage dopant);
        Percentage UpdatePercentage(int id, Percentage percentage);
        void DeletePercentageWithId(int Id);
    }
}
