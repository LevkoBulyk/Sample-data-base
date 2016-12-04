namespace Sample.Entities
{
    public class Percentage : Table
    {
        #region Base SQL properties

        public double Number { get; set; }
        public int? DopantId { get; set; }
        public int? MatrixId { get; set; }

        #endregion

        #region Conctructors

        public Percentage() { }

        public Percentage(int Id, int number, int dopantId, int matrixId)
        {
            this.Id = Id;
            this.Number = number;
            this.DopantId = dopantId;
            this.MatrixId = matrixId;
        }

        #endregion
    }
}
