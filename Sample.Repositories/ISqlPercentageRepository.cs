using Sample.Entities;

namespace Sample.Repositories
{
    interface ISqlPercentageRepository
    {
        Percentage InsertPersentage(Percentage dopant);
        Percentage GetPersentageById(int id);
        void DeletePercentageWithId(int Id);
    }
}
