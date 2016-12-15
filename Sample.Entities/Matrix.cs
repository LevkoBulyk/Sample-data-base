namespace Sample.Entities
{
    public class Matrix : Table
    {

        #region Fields

        private string _name;
        private double _energyGap;
        private double _maxPhononEnergy;
        private string _symmetry;
        private string _comment;

        #endregion

        #region Properties

        public string Name
        {
            get { return this._name; }
            set
            {
                this._name = value;
                this._wasModified = true;
            }
        }
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

        public Matrix() { }

        public Matrix(int id = -1)
        {
            this._id = id;
        }

        public Matrix(int id, string name)
            : this(id)
        {
            this._name = name;
        }

        public Matrix(int id, string name, double energyGap, double maxPhononEnergy, string symmetry)
            : this(id, name)
        {
            this._energyGap = energyGap;
            this._maxPhononEnergy = maxPhononEnergy;
            this._symmetry = symmetry;
        }

        public Matrix(int id, string name, double energyGap, double maxPhononEnergy, string symmetry, string comment)
            : this(id, name, energyGap, maxPhononEnergy, symmetry)
        {
            this._comment = comment;
        }

        #endregion

        #region Helping methods

        public override string ToString()
        {
            return this.Name;
        }

        #endregion
    }
}
