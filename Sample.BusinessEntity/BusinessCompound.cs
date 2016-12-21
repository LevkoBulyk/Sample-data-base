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
        private List<BusinessMatrix> _matrixes;
        private List<BusinessMatrix> _dopants;
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
        public List<BusinessMatrix> Dopants
        {
            get { return this._dopants; }
            set
            {
                this._dopants = value; OnCompundWasModified();
            }
        }
        public List<BusinessMatrix> Matrixes
        {
            get { return this._matrixes; }
            set
            {
                this._matrixes = value;
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
            this._matrixes = new List<BusinessMatrix>();
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
            if (this._matrixes.Count == 0 && this._dopants.Count == 0)
            {
                this._name = "NoName";
            }
            else
            {
                StringBuilder name = new StringBuilder();
                if (this.Matrixes.Count > 0)
                {
                    foreach (var item in this._matrixes)
                    {
                        name.Append(item.Matrix.Name);
                        name.Append('(');
                        name.Append(item.Percentage.Number);
                        name.Append("%)");
                    }
                }

                if (this._dopants.Count > 0)
                {
                    name.Append(':');
                    foreach (var item in this._dopants)
                    {
                        name.Append(item.Matrix.Name);
                        name.Append('(');
                        name.Append(item.Percentage.Number);
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
