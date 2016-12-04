using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.Entities;

namespace Sample.Repositories
{
    class SqlPercentToCompoundRepository : SqlBaseRepository, ISqlPercentToCompoundRepository
    {
        #region Queries

        private const string _getPercentToCompoundByIdQuery = "SELECT Id, Percents_id, Compound_id FROM PercentToCompound WHERE [Disabled] = 0 AND Id = @Id;";
        private const string _insertPercentToCompoundQuery = "INSERT INTO PercentToCompound (Percents_id, Compound_id, [Disabled]) VALUES(@Percents_id, @Compound_id, 0); SET @Id = @@IDENTITY;";
        private const string _getAllWithCompountIdQuery = "SELECT Id, Percents_id, Compound_id FROM PercentToCompound WHERE [Disabled] = 0 AND Compound_id = @Compound_id;";

        #endregion

        #region Constructor

        public SqlPercentToCompoundRepository(string connectionString)
            : base(connectionString)
        { }

        #endregion

        #region Realisation of ISqlPencentToCompoundRepository

        public PercentToCompound GetPercentToCompoundById(int id)
        {
            PercentToCompound result = new PercentToCompound();

            object[] values = GetElementById(id, _getPercentToCompoundByIdQuery);

            if (values != null)
            {
                result.Id = (int)values[0];
                result.PercentId = (int)values[1];
                result.CompoundId = (int)values[2];

                return result;
            }
            return null;
        }

        public PercentToCompound InsertPercentToCompound(PercentToCompound percentToCompound)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@Percents_id", percentToCompound.PercentId);
            parameters.Add("@Compound_id", percentToCompound.CompoundId);

            PercentToCompound result = GetPercentToCompoundById(InsertElement(parameters, _insertPercentToCompoundQuery));

            return result;
        }

        public List<PercentToCompound> GetAllWithCompountId(int id)
        {
            var list = SearchElementsByParameter(_getAllWithCompountIdQuery, "Compound_id", id);
            var result = new List<PercentToCompound>();

            foreach (var item in list)
            {
                result.Add(GetPercentToCompoundFromObjectArray(item));
            }

            return result;
        }

        public void DeletePercentToCompoundWithId(int id)
        {
            DeleteElemetnWithId(id, "PercentToCompound");
        }

        #endregion

        #region Helping method

        private PercentToCompound GetPercentToCompoundFromObjectArray(object[] array)
        {
            PercentToCompound result = new PercentToCompound();

            if (array != null)
            {
                result.Id = (int)array[0];
                result.PercentId = (int)array[1];
                result.CompoundId = (int)array[2];

                return result;
            }
            return null;
        }

        #endregion

    }
}
