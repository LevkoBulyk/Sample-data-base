using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Sample.Repositories
{
    public class SqlBaseRepository
    {
        #region Fields

        protected string _connectionString;

        #endregion

        #region Constructor

        public SqlBaseRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }

        #endregion

        #region Methods

        public object[] GetElementById(int id, string getElementByIdQuery)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(getElementByIdQuery, connection))
                {
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@Id", id);

                    SqlDataReader reader = command.ExecuteReader();

                    object[] item = new object[reader.FieldCount];

                    if (reader.Read())
                    {
                        reader.GetValues(item);
                        return item;
                    }
                }
            }
            return null;
        }

        public int InsertElement(Dictionary<string, object> parameters, string insertElementQuery)
        {
            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(insertElementQuery, connection))
                {
                    command.CommandType = CommandType.Text;

                    foreach (string key in parameters.Keys)
                    {
                        command.Parameters.AddWithValue(key, parameters[key]);
                    }

                    SqlParameter Id = command.Parameters.Add("@Id", SqlDbType.Int);
                    Id.Direction = ParameterDirection.Output;

                    command.ExecuteNonQuery();

                    return (int)command.Parameters["@Id"].Value;
                }
            }
        }

        public List<object[]> GetAllElements(string getAllElementsQuery)
        {
            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(getAllElementsQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var list = new List<object[]>();
                        object[] item = new object[reader.FieldCount];

                        while (reader.Read())
                        {
                            reader.GetValues(item);

                            list.Add(item);
                        }

                        return list;
                    }
                }
            }
        }

        public List<object[]> SearchElementsByParameter(string searchElementByNameQuery, string parameterName, object parameterValue)
        {
            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(searchElementByNameQuery, connection))
                {
                    command.Parameters.AddWithValue(parameterName, parameterValue);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var list = new List<object[]>();
                        var item = new object[reader.FieldCount];

                        while (reader.Read())
                        {
                            reader.GetValues(item);
                            list.Add(item);
                        }

                        return list;
                    }
                }
            }
        }

        #endregion
    }
}
