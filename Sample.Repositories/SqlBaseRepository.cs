namespace Sample.Repositories
{
    public class SqlBaseRepository
    {
        protected string _connectionString;

        public SqlBaseRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }
    }
}
