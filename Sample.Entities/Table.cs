namespace Sample.Entities
{
    public enum Tasks
    {
        DoNothink,
        Update,
        Insert,
        Delete
    }

    public abstract class Table
    {

        #region Fields

        protected int _id;
        protected Tasks _wasModified = Tasks.DoNothink;

        #endregion

        #region Properties

        public int Id
        {
            get { return this._id; }
            set
            {
                this._id = value;
                this._wasModified = true;
            }
        }

        public bool WasModified
        {
            get { return this._wasModified; }
            set { this._wasModified = value; }
        }

        #endregion
    }

}
