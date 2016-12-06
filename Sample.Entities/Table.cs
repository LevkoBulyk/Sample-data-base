namespace Sample.Entities
{
    public abstract class Table
    {
        public int Id { get; set; }
        public bool WasModified { get; set; }
    }
}
