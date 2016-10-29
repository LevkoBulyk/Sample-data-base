namespace Sample.Entities
{
    class Compound : Table
    {
        #region Helpfull enum

        public enum VisibilityType
        {
            VisibleToAll,
            VisibleToCovorkers,
            VisibleToMe
        }

        #endregion

        #region Bare SQL properties

        public float EnergyGap { get; set; }
        public float MaxPhononEnergy { get; set; }
        public string Symmetry { get; set; }

        #endregion

        #region Constructors
        public Compound()
        {
                
        }
        public Compound(int Id)
        {
            this.Id = Id;
        }

        public Compound(int Id, float EnergyGap, float MaxPhononEnergy, string Symmetry)
            : this(Id)
        {
            this.EnergyGap = EnergyGap;
            this.MaxPhononEnergy = MaxPhononEnergy;
            this.Symmetry = Symmetry;
        }

            #endregion
    }
}
