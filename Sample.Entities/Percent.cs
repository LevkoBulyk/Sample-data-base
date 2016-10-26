namespace Sample.Entities
{
    class Percent : Table
    {
        #region Base SQL properties

        public int Number { get; set; }
        public int ElementId { get; set; }

        #endregion

        #region Conctructors

        public Percent(int Id, int Number, int ElementId)
        {
            this.Id = Id;
            this.Number = Number;
            this.ElementId = ElementId;
        }

        #endregion
    }
}
