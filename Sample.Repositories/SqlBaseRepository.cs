using Sample.Entities;
using System;
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

        protected object[] GetElementById(int id, string getElementByIdQuery)
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

        protected int InsertElement(Dictionary<string, object> parameters, string insertElementQuery)
        {
            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(insertElementQuery, connection))
                {
                    command.CommandType = CommandType.Text;

                    foreach (string key in parameters.Keys)
                    {
                        command.Parameters.AddWithValue(key, parameters[key] != null ? parameters[key] : DBNull.Value);
                    }

                    SqlParameter Id = command.Parameters.Add("@Id", SqlDbType.Int);
                    Id.Direction = ParameterDirection.Output;

                    command.ExecuteNonQuery();

                    return (int)command.Parameters["@Id"].Value;
                }
            }
        }

        protected List<object[]> GetAllElements(string getAllElementsQuery)
        {
            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(getAllElementsQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var list = new List<object[]>();

                        while (reader.Read())
                        {
                            object[] item = new object[reader.FieldCount];
                            reader.GetValues(item);
                            list.Add(item);
                        }

                        return list;
                    }
                }
            }
        }

        protected List<object[]> SearchElementsByParameter(string searchElementByNameQuery, string parameterName, object parameterValue)
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

                        while (reader.Read())
                        {
                            var item = new object[reader.FieldCount];
                            reader.GetValues(item);
                            list.Add(item);
                        }

                        return list;
                    }
                }
            }
        }

        protected void UpdateElementWithId(int id, Dictionary<string, object> element, string updateElementWithIdQuery)
        {
            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(updateElementWithIdQuery, connection))
                {
                    command.CommandType = CommandType.Text;

                    foreach (var key in element.Keys)
                    {
                        command.Parameters.AddWithValue(key, element[key]);
                    }
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
            }
        }

        protected void DeleteElemetnWithId(int id, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                connection.Open();

                string deleteQuery = "UPDATE " + tableName + " SET [Disabled] = 1 WHERE Id = @Id;";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
            }
        }

        #endregion
    }
}
