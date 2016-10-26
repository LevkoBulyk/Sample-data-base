namespace Sample.Entities
{
    class Join : Table
    {
        #region Bare SQL properties

        public int PercentId { get; set; }
        public int CompoundId { get; set; }

        #endregion

        #region Constructors

        public Join(int PercentId, int CompountId)
        {
            this.CompoundId = CompoundId;
            this.PercentId = PercentId;
        }

        #endregion
    }
}
