namespace Sample.Entities
{
    public class Matrix : Table
    {

        #region Bare SQL Properties

        public string Name { get; set; }
        public double EnergyGap { get; set; }
        public double MaxPhononEnergy { get; set; }
        public string Symmetry { get; set; }
        public string Comment { get; set; }

        #endregion

        #region Constructors

        public Matrix() { }

        public Matrix(int id = -1)
        {
            this.Id = id;
        }

        public Matrix(int id, string name)
        {
            this.Name = name;
        }

        public Matrix(int id, string name, double energyGap, double maxPhononEnergy, string symmetry)
            : this(id, name)
        {
            this.EnergyGap = energyGap;
            this.MaxPhononEnergy = maxPhononEnergy;
            this.Symmetry = symmetry;
        }

        public Matrix(int id, string name, double energyGap, double maxPhononEnergy, string symmetry, string comment)
            : this(id, name, energyGap, maxPhononEnergy, symmetry)
        {
            this.Comment = comment;
        }

        #endregion

        #region Helping methods

        public override string ToString()
        {
            return "Id=" + this.Id.ToString() +
                "; Name=" + this.Name +
                "; Energy gap=" + this.EnergyGap.ToString() +
                "; Maximum photon energy = " + this.MaxPhononEnergy.ToString() +
                "; Symmetry = " + this.Symmetry +
                "; Comment = " + this.Comment;
        }

        #endregion
    }
}
