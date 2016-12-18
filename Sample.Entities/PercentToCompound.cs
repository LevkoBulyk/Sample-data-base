namespace Sample.Entities
{
    public class PercentToCompound : Table
    {
        #region Fields

        private int _percentId;
        private int _compoundId;

        #endregion

        #region Properties

        public int PercentId
        {
            get { return this._percentId; }
            set
            {
                this._percentId = value;
                this._wasModified = true;
            }
        }

        public int CompoundId
        {
            get { return this._compoundId; }
            set
            {
                this._compoundId = value;
                this._wasModified = true;
            }
        }

        #endregion

        #region Constructors

        public PercentToCompound() { }

        public PercentToCompound(int percentId, int compoundId)
        {
            this._compoundId = compoundId;
            this._percentId = percentId;
        }

        #endregion
    }
}
