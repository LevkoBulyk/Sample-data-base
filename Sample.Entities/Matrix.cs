namespace Sample.Entities
{
    public class Matrix : Table
    {

        #region Bare SQL Properties

        public string Name { get; set; }
        public float EnergyGap { get; set; }
        public float MaxPhononEnergy { get; set; }
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

        public Matrix(int id, string name, float energyGap, float maxPhononEnergy, string symmetry)
            : this(id, name)
        {
            this.EnergyGap = energyGap;
            this.MaxPhononEnergy = maxPhononEnergy;
            this.Symmetry = symmetry;
        }

        public Matrix(int id, string name, float energyGap, float maxPhononEnergy, string symmetry, string comment)
            : this(id, name)
        {
            EnergyGap = energyGap;
            MaxPhononEnergy = maxPhononEnergy;
            Symmetry = symmetry;
            Comment = comment;
        }

        #endregion
    }
}
