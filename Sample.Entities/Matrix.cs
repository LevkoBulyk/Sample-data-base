namespace Sample.Entities
{
    public class Matrix : Table
    {

        #region Bare SQL Properties

        public string Name { get; set; }
        public int PercentId { get; set; }
        public float EnergyGap { get; set; }
        public float MaxPhononEnergy { get; set; }
        public string Symmetry { get; set; }

        #endregion

        #region Constructors

        public Matrix(int Id, string Name, int PercentId)
        {
            this.Id = Id;
            this.Name = Name;
            this.PercentId = PercentId;
        }

        public Matrix(int Id, string Name, int PercentId, float EnergyGap, float MaxPhononEnergy, string Symmetry)
            : this(Id, Name, PercentId)
        {
            this.EnergyGap = EnergyGap;
            this.MaxPhononEnergy = MaxPhononEnergy;
            this.Symmetry = Symmetry;
        }

        #endregion
    }
}
