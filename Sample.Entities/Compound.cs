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

        public double EnergyGap { get; set; }
        public double MaxPhononEnergy { get; set; }
        public string Symmetry { get; set; }
        public string Comment { get; set; }

        #endregion

        #region Constructors

        public Compound()
        { }

        public Compound(int id, double energyGap, double maxPhononEnergy, string symmetry, string comment)
        {
            this.Id = id;
            this.EnergyGap = energyGap;
            this.MaxPhononEnergy = maxPhononEnergy;
            this.Symmetry = symmetry;
            this.Comment = comment;
        }

        #endregion
    }
}
