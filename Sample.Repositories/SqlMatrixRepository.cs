using Sample.Entities;
using System.Collections.Generic;

namespace Sample.Repositories
{
    public class SqlMatrixRepository : SqlBaseRepository, IMatrixRepository
    {
        #region Queries

        private const string _getAllMatrixesQuery = "SELECT Id, Name, Eg, hw, Symmetry, Comment, Disabled FROM Matrix WHERE [Disabled] = 0;";
        private const string _insertMatrixQuery = "INSERT INTO Matrix (Name, Eg, hw, Symmetry, Comment, [Disabled]) VALUES(@Name, @Eg, @hw, @Symmetry, @Comment, 0); SET @Id = @@IDENTITY;";
        private const string _getMatrixById = "SELECT Id, Name, Eg, hw, Symmetry, Comment FROM Matrix WHERE [Disabled] = 0 AND Id = @Id;";
        private const string _getMatrixesByName = "SELECT Id, Name, Eg, hw, Symmetry, Comment, Disabled FROM Matrix WHERE [Disabled] = 0 AND Name LIKE @Name;";
        private const string _updateMatrixWithId = "UPDATE Matrix SET Name = @Name, Eg = @Eg, hw = @hw, Symmetry = @Symmetry, Comment = @Comment WHERE Id = @Id;";

        #endregion

        #region Constructor

        public SqlMatrixRepository(string connectionString)
            : base(connectionString)
        { }

        #endregion

        #region Realisation of IMatrixRepository

        public IEnumerable<Matrix> GetAllMatrixes()
        {
            var list = GetAllElements(_getAllMatrixesQuery);
            var result = new List<Matrix>();

            foreach (var item in list)
            {
                result.Add(GetMatrixFromObjectArray(item));
            }

            return result;
        }

        public Matrix InsertMatrix(Matrix matrix)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@Name", matrix.Name);
            parameters.Add("@Eg", matrix.EnergyGap);
            parameters.Add("@hw", matrix.MaxPhononEnergy);
            parameters.Add("@Symmetry", matrix.Symmetry);
            parameters.Add("@Comment", matrix.Comment);

            Matrix result = GetMatrixById(InsertElement(parameters, _insertMatrixQuery));

            return result;
        }

        public Matrix GetMatrixById(int id)
        {
            var values = GetElementById(id, _getMatrixById);
            return GetMatrixFromObjectArray(values);
        }

        public IEnumerable<Matrix> SearchMatrixesByName(string name)
        {
            var list = SearchElementsByParameter(_getMatrixesByName, "Name", "%" + name + "%");
            var result = new List<Matrix>();

            foreach (var item in list)
            {
                result.Add(GetMatrixFromObjectArray(item));
            }

            return result;
        }

        public Matrix UpdateMatrixWithId(int id, Matrix matrix)
        {
            Matrix matrixBeforeUpdating = GetMatrixById(id);

            var newMatrix = new Dictionary<string, object>();
            newMatrix.Add("@Name", matrix.Name);
            newMatrix.Add("@Eg", matrix.EnergyGap);
            newMatrix.Add("@hw", matrix.MaxPhononEnergy);
            newMatrix.Add("@Symmetry", matrix.Symmetry);
            newMatrix.Add("@Comment", matrix.Comment);

            UpdateElementWithId(id, newMatrix, _updateMatrixWithId);

            Matrix matrixAfterUpdating = GetMatrixById(id);

            if (matrixBeforeUpdating != matrixAfterUpdating)
            {
                return matrixAfterUpdating;
            }
            return null;
        }

        public void DeleteMatrixWithId(int id)
        {
            DeleteElemetnWithId(id, "matrix");
        }

        #endregion

        #region Helping methods

        private Matrix GetMatrixFromObjectArray(object[] array)
        {
            Matrix result = new Matrix();

            if (array != null)
            {
                result.Id = (int)array[0];
                result.Name = (string)array[1];
                result.EnergyGap = (double)array[2];
                result.MaxPhononEnergy = (double)array[3];
                result.Symmetry = (string)array[4];
                result.Comment = (string)array[5];

                return result;
            }
            return null;
        }

        #endregion

    }
}
