using Sample.Entities;
using Sample.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.BusinessEntity
{
    public class BusinessCompound : IBusinessCompound
    {
        #region Fields

        private string _name;
        private string _connectionString;
        private SqlPercentageRepository _sqlPercentageRepository;
        private SqlPercentToCompoundRepository _sqlPercentToCompoundRepository;
        private SqlCompoundRepository _sqlCompoundRepository;

        #endregion

        #region Properties

        public double EnergyGap { get; set; }
        public double MaxPhononEnergy { get; set; }
        public string Symmetry { get; set; }
        public string Comment { get; set; }
        public Dictionary<Percentage, Matrix> Matrixes { get; set; }
        public Dictionary<Percentage, Dopant> Dopants { get; set; }
        public List<PercentToCompound> PercentageToCompound { get; set; }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        #endregion

        #region Constructors

        public BusinessCompound(string connectionString)
        {
            this._connectionString = connectionString;

            this._sqlCompoundRepository = new SqlCompoundRepository(this._connectionString);
            this._sqlPercentageRepository = new SqlPercentageRepository(this._connectionString);
            this._sqlPercentToCompoundRepository = new SqlPercentToCompoundRepository(this._connectionString);

            ResetDefaultName();
        }

        public BusinessCompound(string connectionString, int i)
            : this(connectionString)
        {

        }

        #endregion

        #region Realisation of IBusinessCompound

        public BusinessCompound GetCompoundById(int id)
        {
            throw new NotImplementedException();
        }

        public List<BusinessCompound> GetAllCompounds()
        {
            throw new NotImplementedException();
        }

        public List<BusinessCompound> SearchCompoundWithNameLike(string name)
        {
            throw new NotImplementedException();
        }

        public BusinessCompound UpdateCompoundWithId(int id, BusinessCompound compound)
        {
            throw new NotImplementedException();
        }

        public void DeleteCompoundWithId(int id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Helping methods

        public void ResetDefaultName()
        {
            if (this.Matrixes.Count == 0 && this.Dopants.Count == 0)
            {
                this._name = "NoName";
            }
            else
            {
                StringBuilder name = new StringBuilder();
                if (this.Matrixes.Count > 0)
                {
                    foreach (var key in this.Matrixes.Keys)
                    {
                        name.Append(this.Matrixes[key].Name);
                        name.Append('(');
                        name.Append(key.Number);
                        name.Append("%)");
                    }
                }

                if (this.Dopants.Count > 0)
                {
                    name.Append(':');
                    foreach (var key in this.Dopants.Keys)
                    {
                        name.Append(this.Dopants[key].Name);
                        name.Append('(');
                        name.Append(key.Number);
                        name.Append("%),");
                    }
                    name.Remove(name.Length - 1, 1);
                }

                this._name = name.ToString();
            }
        }

        #endregion

    }
}
