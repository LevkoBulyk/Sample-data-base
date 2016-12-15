namespace Sample.Entities
{
    public class Dopant : Table
    {
        #region Fields

        private string _name;
        private string _valence;

        #endregion

        #region Properties

        public string Name
        {
            get { return this._name; }
            set
            {
                this._name = value;
                this._wasModified = true;
            }
        }
        public string Valence
        {
            get { return _valence; }
            set
            {
                this._valence = value;
                this._wasModified = true;
            }
        }

        #endregion

        #region Constructors

        public Dopant() { }

        public Dopant(int id, string name, string valance)
        {
            this._id = id;
            this._name = name;
            this._valence = valance;
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
