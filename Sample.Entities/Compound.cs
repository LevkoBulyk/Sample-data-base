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

        public float EnergyGap { get; set; }
        public float MaxPhononEnergy { get; set; }
        public string Symmetry { get; set; }

        #endregion

        #region Constructors

        public Compound()
        { }

        public Compound(int id, float energyGap, float maxPhononEnergy, string symmetry)
        {
            this.Id = id;
            this.EnergyGap = energyGap;
            this.MaxPhononEnergy = maxPhononEnergy;
            this.Symmetry = symmetry;
        }

        #endregion
    }
}
