namespace Sample.Entities
{
    public class User : Table
    {
        #region Bare SQL properties

        public string Name { get; set; }
        public string Department { get; set; }

        #endregion

        #region Constructors

        public User() { }

        public User(int id, string name, string department)
        {
            this.Id = id;
            this.Name = name;
            this.Department = department;
        }

        #endregion
    }
}
