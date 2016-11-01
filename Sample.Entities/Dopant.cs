namespace Sample.Entities
{
    public class Dopant : Table
    {
        #region Bare SQL properties

        public string Name { get; set; }
        public string Valence { get; set; }

        #endregion

        #region Constructors

        public Dopant() { }

        public Dopant(int id, string name, string valance)
        {
            this.Id = id;
            this.Name = name;
            this.Valence = valance;
        }

        #endregion

        #region Helping methods

        public override string ToString()
        {
            return "Name: " + this.Name +
                "; Valance: " + this.Valence + ";";
        }

        #endregion

    }
}
