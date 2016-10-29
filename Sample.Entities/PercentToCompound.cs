namespace Sample.Entities
{
    public class PercentToCompound : Table
    {
        #region Bare SQL properties

        public int PercentId { get; set; }
        public int CompoundId { get; set; }

        #endregion

        #region Constructors

        public PercentToCompound() { }

        public PercentToCompound(int percentId, int compoundId)
        {
            this.CompoundId = compoundId;
            this.PercentId = percentId;
        }

        #endregion
    }
}
