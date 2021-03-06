﻿using Sample.Entities;
using System.Collections.Generic;

namespace Sample.Repositories
{
    public interface IMatrixRepository
    {
        IEnumerable<Matrix> GetAllMatrixes();
        Matrix InsertMatrix(Matrix matrix);
        Matrix GetMatrixById(int id);
        IEnumerable<Matrix> SearchMatrixesByName(string name);
    }
}
