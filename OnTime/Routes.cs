using MySql.Data.MySqlClient;

namespace OnTime
{
    class Routes
    {
        private MySqlConnection _conn;

        public Routes()
        {
            _conn = Database.DatabaseConection();
        }

        public void GetRoutes()
        {
            _conn.Open();

            //Query and running qeury
            string query = "SELECT * FROM routes";
            MySqlCommand cmd = new MySqlCommand(query, _conn);
            MySqlDataReader reader = cmd.ExecuteReader();

        }
    }
}
