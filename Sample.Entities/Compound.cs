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

        #region Bare SQL properties

        public int UserId { get; set; }
        public VisibilityType Visibility { get; set; }
        public float EnergyGap { get; set; }
        public float MaxPhononEnergy { get; set; }
        public string Symmetry { get; set; }

        #endregion

        #region Constructors

        public Compound(int Id)
        {
            this.Id = Id;
        }

        public Compound(int Id, int UserId, VisibilityType Visibility)
             : this(Id)
        {
            this.UserId = UserId;
            this.Visibility = Visibility;
        }

        public Compound(int Id, float EnergyGap, float MaxPhononEnergy, string Symmetry)
            : this(Id)
        {
            this.EnergyGap = EnergyGap;
            this.MaxPhononEnergy = MaxPhononEnergy;
            this.Symmetry = Symmetry;
        }

        public Compound(int Id, int UserId, VisibilityType Visibility, float EnergyGap, float MaxPhononEnergy, string Symmetry)
             : this(Id, EnergyGap, MaxPhononEnergy, Symmetry)
        {
            this.UserId = UserId;
            this.Visibility = Visibility;
        }

        #endregion
    }
}
