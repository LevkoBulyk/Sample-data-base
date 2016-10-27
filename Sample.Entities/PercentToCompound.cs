namespace Sample.Entities
{
    class PercentToCompound : Table
    {
        #region Bare SQL properties

        public int PercentId { get; set; }
        public int CompoundId { get; set; }

        #endregion

        #region Constructors

        public PercentToCompound(int PercentId, int CompountId)
        {
            this.CompoundId = CompoundId;
            this.PercentId = PercentId;
        }

        #endregion
    }
}
