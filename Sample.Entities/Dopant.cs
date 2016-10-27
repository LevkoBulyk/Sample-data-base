﻿namespace Sample.Entities
{
    class Dopant : Table
    {
        #region Bare SQL properties

        public string Name { get; set; }
        public int PercentId { get; set; }
        public short Valance { get; set; }

        #endregion

        #region Constructors

        public Dopant(int Id, string Name, int PercentId, short Valance)
        {
            this.Id = Id;
            this.Name = Name;
            this.PercentId = PercentId;
            this.Valance = Valance;
        }

        #endregion
    }
}