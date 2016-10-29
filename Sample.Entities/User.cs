namespace Sample.Entities
{
    class User : Table
    {
        #region Bare SQL properties

        public string Name { get; set; }
        public string Department { get; set; }

        #endregion

        #region Constructors

        public User()
        {
            
        }
        public User(int Id, string Name, string Departmrnt)
        {
            this.Id = Id;
            this.Name = Name;
            this.Department = Department;
        }

        #endregion
    }
}
