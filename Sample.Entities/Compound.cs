namespace Sample.Entities
{
    public class Compound : Table
    {
        #region Helpfull enum

        public enum VisibilityType
        {
            VisibleToAll,
            VisibleToCovorkers,
            VisibleToMe
        }

        #endregion

        #region Fields

        private double _energyGap;
        private double _maxPhononEnergy;
        private string _symmetry;
        private string _comment;

        #endregion

        #region Properties

        public double EnergyGap
        {
            get { return this._energyGap; }
            set
            {
                this._energyGap = value;
                this._wasModified = true;
            }
        }
        public double MaxPhononEnergy
        {
            get { return this._maxPhononEnergy; }
            set
            {
                this._maxPhononEnergy = value;
                this._wasModified = true;
            }
        }
        public string Symmetry
        {
            get { return this._symmetry; }
            set
            {
                this._symmetry = value;
                this._wasModified = true;
            }
        }
        public string Comment
        {
            get { return this._comment; }
            set
            {
                this._comment = value;
                this._wasModified = true;
            }
        }


        #endregion

        #region Constructors

        public Compound()
        { }

        public Compound(int id, double energyGap, double maxPhononEnergy, string symmetry, string comment)
        {
            this._id = id;
            this._energyGap = energyGap;
            this._maxPhononEnergy = maxPhononEnergy;
            this._symmetry = symmetry;
            this._comment = comment;
        }

        #endregion
    }
}
