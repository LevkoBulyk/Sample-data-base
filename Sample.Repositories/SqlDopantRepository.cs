﻿using System.Collections.Generic;
using Sample.Entities;
using System.Data.SqlClient;

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
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@Name", dopant.Name);
            parameters.Add("@Valence", dopant.Valance);

            Dopant result = GetDopantById(InsertElement(parameters, _insertDopantQuery));

            return result;
        }

        public Dopant GetDopantById(int id)
        {
            Dopant resultDopant = new Dopant();

            object[] values = GetElementById(id, _getDopantById);

            if (values != null)
            {
                resultDopant.Id = (int)values[0];
                resultDopant.Name = (string)values[1];
                resultDopant.Valance = (string)values[2];

                return resultDopant;
            }
            return null;
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
