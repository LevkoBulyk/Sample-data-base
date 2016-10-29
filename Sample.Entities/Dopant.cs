namespace Sample.Entities
{
    public class Dopant : Table
    {
        #region Bare SQL properties

        public string Name { get; set; }
        public string Valence { get; set; }

        #endregion

        #region Constructors

        public Dopant(string Name, string Valence, int Id = -1)
        {
            this.Id = Id;
            this.Name = Name;
            this.Valence = Valence;
        }

        #endregion
    }
}
