using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace OnTime
{
    class Database
    {

        //Fields for Database connection
        public static MySqlConnection _conn;
        private const string MyConnectionString = "server=127.0.0.1;uid=root;pwd=;database=ontime;";

        public Database()
        {
            DatabaseConection();
        }
        public bool DBconect(string conect)
        {
            MySqlConnection _conn;
            _conn = new MySqlConnection(MyConnectionString);
            try
            {
                _conn = new MySqlConnection(MyConnectionString);
                switch (conect)
                {
                    case "open":
                        _conn.Open();

                        break;
                    case "dicht":
                        _conn.Close();
                        break;
                }
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }



        /// <summary>
        /// Open database connection
        /// </summary>
        public static MySqlConnection DatabaseConection()
        {
            try
            {
                //Open connection
                _conn = new MySqlConnection { ConnectionString = MyConnectionString };
                _conn.Open();
            }
            catch (MySqlException ex)
            {
                //catch errors
                MessageBox.Show(ex.Message);
            }

            return _conn;
        }

        /// <summary>
        /// Insert data into database
        /// </summary>
        public static void InsertData(string from, string to, string arrival, string departure, int price)
        {
            DatabaseConection();
            //Make query and excute query
            string query = $"INSERT INTO `routes`(`ID`, `departure`, `arrival`, `price`, `arrivalTime`, `departureTime`) VALUES ('NULL', '{from}', '{to}', '{price}' ,'{arrival}', '{departure}')";
            MySqlCommand command = new MySqlCommand(query, _conn);
            command.ExecuteReader();

            //Close database connection
            _conn.Close();
        }

        public static Dictionary<int ,string> ReadData()
        {
            Dictionary<int, string> lijst = new Dictionary<int, string>();
            string query = $"SELECT * FROM `routes`";
            string Connection = "server=127.0.0.1;uid=root;" + "pwd=;database=ontime";
            _conn = new MySqlConnection(Connection);
            MySqlCommand command = new MySqlCommand(query, _conn);
            _conn.Open();
            MySqlDataReader Read = command.ExecuteReader();
            while (Read.Read())
            {
                Console.WriteLine(Convert.ToString(Read.GetValue(0) + " : " + Read.GetValue(1) + " : " + Read.GetValue(2) + " : " + Read.GetValue(3) + " : " + Read.GetValue(4) + " : " + Read.GetValue(5)));
                lijst.Add(Convert.ToInt32(Read.GetValue(0)), Read.GetValue(1) + " : " + Read.GetValue(2) + " : " + Read.GetValue(3) + " : " + Read.GetValue(4) + " : " + Read.GetValue(5));
            }
            return lijst;
        }
    }
}

