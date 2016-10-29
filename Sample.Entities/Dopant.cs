namespace Sample.Entities
{
    public class Dopant : Table
    {
        #region Bare SQL properties

        public string Name { get; set; }
        public string Valance { get; set; }

        #endregion

        #region Constructors

        public Dopant() { }

        public Dopant(int id, string name, string valance)
        {
            this.Id = id;
            this.Name = name;
            this.Valance = valance;
        }

        #endregion

        #region Helping methods

        public override string ToString()
        {
            return "Id=" + this.Id.ToString() + 
                "; Name=" + this.Name +
                "; Valance=" + this.Valance;
        }

        #endregion

    }
}
