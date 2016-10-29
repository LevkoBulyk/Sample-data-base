﻿namespace Sample.Entities
{
    class Percentage : Table
    {
        #region Base SQL properties

        public int Number { get; set; }
        public int DopantId { get; set; }
        public int MatrixId { get; set; }

        #endregion

        #region Conctructors

        public Percentage()
        {
            
        }
        public Percentage(int Id, int Number, int DopantId, int MatrixId)
        {
            this.Id = Id;
            this.Number = Number;
            this.DopantId = DopantId;
            this.MatrixId = MatrixId;
        }

        #endregion
    }
}
