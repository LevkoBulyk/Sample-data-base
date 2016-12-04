using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.Entities;

namespace Sample.Repositories
{
    public class SqlCompoundRepository : SqlBaseRepository, ISqlCompoundRepository
    {

        #region Queries

        private const string _getCompoundByIdQuery = "SELECT Id, Visibility, Eg, hw, Symmetry, Comment FROM Compound WHERE Id = @Id AND [Disabled] = 0;";
        private const string _getAllCompoundsQuery = "SELECT Id, Visibility, Eg, hw, Symmetry, Comment FROM Compound WHERE [Disabled] = 0;";
        private const string _insertCompoundQuery = "INSERT INTO Compound (Visibility, Eg, hw, Symmetry, Comment, [Disabled]) VALUES (@Visibility, @Eg, @hw, @Symmetry, @Comment, 0); SET @Id = @@IDENTITY;";
        private const string _updateCompoundQuery = "UPDATE Compound SET Visibility = @Visibility, Eg = @Eg, hw = @hw, Symmetry = @Symmetry, Comment = @Comment, WHERE Id = @Id;";

        #endregion

        #region Constructor

        public SqlCompoundRepository(string connectionString)
            : base(connectionString)
        { }

        #endregion

        #region Realisation of ISqlCompoundRepository

        public Compound GetCompoundById(int id)
        {
            var values = GetElementById(id, "Compound");
            return GetCompoundFromObjectArray(values);
        }

        public List<Compound> GetAllCompounds()
        {
            var list = GetAllElements(_getAllCompoundsQuery);
            var result = new List<Compound>();

            foreach (var item in list)
            {
                result.Add(GetCompoundFromObjectArray(item));
            }

            return result;
        }

        public Compound InsertCompound(Compound compound)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@Eg", compound.EnergyGap);
            parameters.Add("@hw", compound.MaxPhononEnergy);
            parameters.Add("@Symmetry", compound.Symmetry);
            parameters.Add("@Comment", compound.Comment);

            Compound result = GetCompoundById(InsertElement(parameters, _insertCompoundQuery));

            return result;
        }

        public Compound UpdateCompound(int id, Compound compound)
        {
            Compound compoundBeforeUpdating = GetCompoundById(id);

            var newMatrix = new Dictionary<string, object>();
            newMatrix.Add("@Eg", compound.EnergyGap);
            newMatrix.Add("@hw", compound.MaxPhononEnergy);
            newMatrix.Add("@Symmetry", compound.Symmetry);
            newMatrix.Add("@Comment", compound.Comment);

            UpdateElementWithId(id, newMatrix, _updateCompoundQuery);

            Compound matrixAfterUpdating = GetCompoundById(id);

            if (compoundBeforeUpdating != matrixAfterUpdating)
            {
                return matrixAfterUpdating;
            }
            return null;
        }

        public void DeleteCompound(int id)
        {
            DeleteElemetnWithId(id, "Compound");
        }

        #endregion

        #region Helping methods

        private Compound GetCompoundFromObjectArray(object[] array)
        {
            Compound result = new Compound();

            if (array != null)
            {
                // Id, Visibility, Eg, hw, Symmetry, Comment
                result.Id = (int)array[0];
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
