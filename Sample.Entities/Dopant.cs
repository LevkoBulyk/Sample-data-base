namespace Sample.Entities
{
    public class Dopant : Table
    {
        #region Bare SQL properties

        public string Name { get; set; }
        public short Valence { get; set; }

        #endregion

        #region Constructors

        public Dopant(int Id, string Name, short Valance)
        {
            this.Id = Id;
            this.Name = Name;
            this.Valence = Valence;
        }

        #endregion
    }
}
