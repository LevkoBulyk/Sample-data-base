using Sample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.BusinessEntity
{
    public class BusinessMatrix
    {
        #region Fields

        private Matrix _matrix;
        private Percentage _percentage;
        private PercentToCompound _percentToCompound;

        #endregion

        #region Properties

        public Matrix Matrix
        {
            get { return this._matrix; }
            set { this._matrix = value; }
        }
        public Percentage Percentage
        {
            get { return this._percentage; }
            set { this._percentage = value; }
        }
        public PercentToCompound PercentToCompound
        {
            get { return this._percentToCompound; }
            set { this._percentToCompound = value; }
        }

        #endregion

        #region Constructors

        public BusinessMatrix()
        {
            this._matrix = new Matrix();
            this._percentage = new Percentage();
            this._percentToCompound = new PercentToCompound();
        }

        #endregion

        #region Methods

        #endregion
    }
}
