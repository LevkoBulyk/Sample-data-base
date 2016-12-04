using System;
using Sample.Entities;
using System.Collections.Generic;

namespace Sample.Repositories
{
    public class SqlPercentageRepository : SqlBaseRepository, ISqlPercentageRepository
    {

        #region Queries

        private const string _getPercentageByIdQuery = "SELECT Id, Number, Matrix_id, Dopant_id FROM Percentage WHERE [Disabled] = 0 AND Id = @Id;";
        private const string _insertPercentageQuery = "INSERT INTO Percentage (Number, Matrix_id, Dopant_id, [Disabled]) VALUES(@Number, @Matrix_id, @Dopant_id, 0); SET @Id = @@IDENTITY;";
        private const string _updatePercentageQuery = "UPDATE Persentage SET Number = @Number, Matrix_id = @Matrix_id, Dopant_Id = Dopant_id WHERE Id = @Id;";

        #endregion

        #region Constructor

        public SqlPercentageRepository(string connectionString)
            : base(connectionString)
        { }

        #endregion

        #region Realisation of IPercentageRepository

        public Percentage GetPersentageById(int id)
        {
            Percentage resultPercentage = new Percentage();

            object[] values = GetElementById(id, _getPercentageByIdQuery);

            if (values != null)
            {
                resultPercentage.Id = (int)values[0];
                resultPercentage.Number = (int)values[1];
                resultPercentage.MatrixId = (int)values[2];
                resultPercentage.DopantId = (int)values[3];

                return resultPercentage;
            }
            return null;
        }

        public Percentage InsertPersentage(Percentage percentage)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@Number", percentage.Number);
            parameters.Add("@Matrix_id", percentage.MatrixId);
            parameters.Add("@Dopant_id", percentage.DopantId);

            Percentage result = GetPersentageById(InsertElement(parameters, _insertPercentageQuery));

            return result;
        }

        public Percentage UpdatePercentage(int id, Percentage percentage)
        {
            Percentage percentageBeforeUpdating = GetPersentageById(id);

            var elements = new Dictionary<string, object>();
            elements.Add("@Number", percentage.Number);
            elements.Add("@Matrix_id", percentage.MatrixId);
            elements.Add("@Dopant_Id", percentage.DopantId);

            UpdateElementWithId(id, elements, _updatePercentageQuery);

            Percentage result = GetPersentageById(id);
            if (result != percentageBeforeUpdating)
            {
                return result;
            }

            return null;
        }

        public void DeletePercentageWithId(int id)
        {
            DeleteElemetnWithId(id, "Percentage");
        }

        #endregion

    }
}
