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

        public Matrix()
        {
                
        }
        public Matrix(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public Matrix(int Id, string Name, float EnergyGap, float MaxPhononEnergy, string Symmetry)
            : this(Id, Name)
        {
            this.EnergyGap = EnergyGap;
            this.MaxPhononEnergy = MaxPhononEnergy;
            this.Symmetry = Symmetry;
        }

        public Matrix(int id,string name, float energyGap, float maxPhononEnergy, string symmetry, string comment)
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
