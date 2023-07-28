namespace Lesson16Project2
{
    internal class SqlClient : IDisposable
    {
        public void Dispose()
        {
            CloseConnection();
        }

        public void RunQuery(string sqlQuery)
        {
            OpenConnection();
            // ...
            CloseConnection();
        }

        private void OpenConnection()
        {
            // ....
        }

        private void CloseConnection()
        {
            // ....
        }

    }
}
