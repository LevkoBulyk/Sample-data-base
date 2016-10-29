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

        private const string _getAllDopantsQuery = "SELECT Id, Name, Valence FROM Dopant WHERE[Disabled] = 0;";
        private const string _insertDopantQuery = "INSERT INTO Dopant (Name, Valence, [Disabled]) VALUES(@Name, @Valence, 0); SET @Id = @@IDENTITY;";
        private const string _getDopantById = "SELECT Id, Name, Valence FROM Dopant WHERE[Disabled] = 0 AND Id = @Id;";
        private const string _getDopantsByName = "SELECT Id, Name, Valence FROM Dopant WHERE[Disabled] = 0 AND Name = @Name;";

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
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var list = new List<Dopant>();

                        while (reader.Read())
                        {
                            int id = (int)reader["Id"];
                            string name = (string)reader["Name"];
                            string valence = (string)reader["Valence"];

                            list.Add(new Dopant(id, name, valence));
                        }

                        return list;
                    }
                }
            }
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
                    command.Parameters.AddWithValue("@Valence", dopant.Valance);
                    SqlParameter Id = command.Parameters.Add("@Id", SqlDbType.Int);
                    Id.Direction = ParameterDirection.Output;

                    command.ExecuteNonQuery();

                    return GetDopantById((int)command.Parameters["@Id"].Value);
                }
            }
        }

        public Dopant GetDopantById(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(_getDopantById, connection))
                {
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@Id", id);

                    SqlDataReader reader = command.ExecuteReader();

                    Dopant dopant = new Dopant();

                    Dopant resultDopant = new Dopant();

                    if (reader.Read())
                    {
                        resultDopant.Id = (int)reader["Id"];
                        resultDopant.Name = (string)reader["Name"];
                        resultDopant.Valance = (string)reader["Valence"];
                    }

                    return resultDopant;
                }
            }
        }

        public IEnumerable<Dopant> SeachDopantsByName(string name)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(_getDopantsByName, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var list = new List<Dopant>();
                        while (reader.Read())
                        {
                            int id = (int)reader["Id"];
                            string retName = (string)reader["Name"];
                            string valence = (string)reader["Valence"];

                            list.Add(new Dopant(id, retName, valence));
                        }
                    }
                }
            }
            return null;
        }

        #endregion

    }
}
