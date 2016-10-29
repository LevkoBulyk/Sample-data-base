using Sample.Entities;
using System.Collections.Generic;

namespace Sample.Repositories
{
    interface IMatrixRepository
    {
        IEnumerable<Matrix> GetAllMatrixes();
        Matrix InsertMatrix(Matrix matrix);
        Matrix SeachMatrixByName(string name);
    }
}
