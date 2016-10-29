namespace Sample.Entities
{
    class Dopant : Table
    {
        #region Bare SQL properties

        public string Name { get; set; }
        public string Valance { get; set; }

        #endregion

        #region Constructors

        public Dopant(int Id, string Name, string Valance)
        {
            this.Id = Id;
            this.Name = Name;
            this.Valance = Valance;
        }

        #endregion
    }
}
