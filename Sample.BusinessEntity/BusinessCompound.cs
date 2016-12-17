using Sample.Entities;
using Sample.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.BusinessEntity
{
    public class BusinessCompound
    {
        #region Fields

        private string _name;

        #endregion

        #region Properties

        public Compound Compound { get; set; }
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

        public BusinessCompound()
        {
            this.Matrixes = new Dictionary<Percentage, Matrix>();
            this.Dopants = new Dictionary<Percentage, Dopant>();
            this.PercentageToCompound = new List<PercentToCompound>();
            this.Compound = new Compound();
            ResetDefaultName();
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
