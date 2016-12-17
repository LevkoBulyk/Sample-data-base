using System;

namespace Sample.Entities
{
    public class Percentage : Table
    {

        #region Fields

        private double _number;
        private int? _dopantId;
        private int? _matrixId;

        #endregion

        #region Properties

        public double Number
        {
            get { return this._number; }
            set
            {
                this._number = value;
                this._wasModified = true;
            }
        }
        public int? DopantId
        {
            get { return this._dopantId; }
            set
            {
                this._dopantId = value;
                this._wasModified = true;
            }
        }
        public int? MatrixId
        {
            get { return this._matrixId; }
            set
            {
                this._matrixId = value;
                this._wasModified = true;
            }
        }

        #endregion

        #region Conctructors

        public Percentage() { }

        public Percentage(int Id, double number, int? dopantId, int? matrixId)
        {
            this._id = Id;
            this._number = number;
            this._dopantId = dopantId;
            this._matrixId = matrixId;
        }

        #endregion

        #region Helping methods

        public override int GetHashCode()
        {
            return this._id;
        }

        #endregion

    }
}
