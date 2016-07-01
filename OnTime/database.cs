using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;

namespace OnTime
{
    class Database
    {

        //Fields for Database connection
        private MySqlConnection _conn;
        private const string MyConnectionString = "server=127.0.0.1;uid=root;pwd=;database=ontime;";

        public Database()
        {
            _conn = DBconect("open");
        }

        /// <summary>
        /// Open database connection
        /// </summary>
        public dynamic DBconect(string conect)
        {
            var conn = new MySqlConnection(MyConnectionString);
            try
            {
                conn = new MySqlConnection(MyConnectionString);
                switch (conect)
                {
                    case "open":
                        conn.Open();
                        break;
                    case "dicht":
                        conn.Close();
                        break;
                }
                return conn;
            }
            catch (MySqlException)
            {
                _conn = null;
                return _conn;
            }
        }

        /// <summary>
        /// Insert data into database
        /// </summary>
        public void InsertData(string from, string to, string arrival, string departure, int price)
        {
            //Make query and excute query
            string query = $"INSERT INTO `routes`(`ID`, `departure`, `arrival`, `price`, `arrivalTime`, `departureTime`) VALUES ('NULL', '{from}', '{to}', '{price}' ,'{arrival}', '{departure}')";
            MySqlCommand command = new MySqlCommand(query, _conn);
            command.ExecuteReader();
        }

        public MySqlDataReader ReadData()
        {
            MySqlDataReader read = null;
            string query = @"SELECT * FROM `routes`";
            if (_conn != null)
            {
                MySqlCommand command = new MySqlCommand(query, _conn);
                read = command.ExecuteReader();
            }
            return read;
        }

        public void Remove(int idDB)
        {
            using (MySqlCommand command = new MySqlCommand("DELETE FROM `routes` WHERE `ID` = '" + idDB + "'", _conn))
            {
                command.ExecuteNonQuery();
            }
            _conn.Close();
        }
    }
}

