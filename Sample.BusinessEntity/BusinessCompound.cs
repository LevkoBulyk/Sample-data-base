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

        private Compound _compound;
        private Dictionary<Percentage, Matrix> _matrixes;
        private Dictionary<Percentage, Dopant> _dopants;
        private List<PercentToCompound> _percentageToCompound;
        private string _name;

        #endregion

        #region Properties

        public Compound Compound
        {
            get { return this._compound; }
            set
            {
                this._compound = value;
                OnCompundWasModified();
            }
        }
        public Dictionary<Percentage, Matrix> Matrixes
        {
            get { return this._matrixes; }
            set
            {
                this._matrixes = value;
                OnCompundWasModified();
            }
        }
        public Dictionary<Percentage, Dopant> Dopants
        {
            get { return this._dopants; }
            set
            {
                this._dopants = value;
                OnCompundWasModified();
            }
        }
        public List<PercentToCompound> PercentageToCompound
        {
            get { return this._percentageToCompound; }
            set
            {
                this._percentageToCompound = value;
                OnCompundWasModified();
            }
        }

        public string Name
        {
            get { return this._name; }
            set
            {
                this._name = value;
                OnCompundWasModified();
            }
        }

        #endregion

        #region Delegates andEvents

        public delegate void CompoundWasModifiedEventHandler(BusinessCompound sender, EventArgs args);
        public event CompoundWasModifiedEventHandler CompoundWasModified;

        #endregion

        #region Constructors

        public BusinessCompound()
        {
            this._matrixes = new Dictionary<Percentage, Matrix>();
            this._dopants = new Dictionary<Percentage, Dopant>();
            this._percentageToCompound = new List<PercentToCompound>();
            this._compound = new Compound();
            ResetDefaultName();
        }

        #endregion

        #region Helping methods

        protected virtual void OnCompundWasModified()
        {
            CompoundWasModified?.Invoke(this, EventArgs.Empty);
        }

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
