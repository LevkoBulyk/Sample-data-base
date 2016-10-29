using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.Entities;
using System.Data.SqlClient;
using System.Data;

namespace Sample.Repositories
{
    public class SqlDopantRepository : SqlBaseRepository, IDopantRepository
    {

        #region Queries

        private const string _getAllDopantsQuery = "";
        private const string _insertDopantQuery = "INSERT INTO Dopant (Name, Valense, [Disabled]) VALUES(@Name, @Valence, 0);";

        #endregion

        #region Constructor

        public SqlDopantRepository(string connectionString)
            : base(connectionString)
        { }

        #endregion

        #region Realisation of IDopantRepository

        public IEnumerable<Dopant> GetAllDopants()
        {
            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(_getAllDopantsQuery, connection))
                {

                }
            }
            return null;
        }

        public Dopant InsertDopant(Dopant dopant)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(_insertDopantQuery, connection))
                {
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@Name", dopant.Name);
                    command.Parameters.AddWithValue("@Valence", dopant.Valence);

                    command.ExecuteNonQuery();
                    return null;
                }
            }
        }

        public Dopant SeachDopantByName(string name)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
