﻿using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OnTime
{
    class Database
    {

        //Fields for Database connection
        private MySqlConnection _conn;
        private const string MyConnectionString = "server=127.0.0.1;uid=root;pwd=;database=ontime;";

        public Database()
        {
            DatabaseConection();
        }

        /// <summary>
        /// Open database connection
        /// </summary>
        public void DatabaseConection()
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

            //Close database connection
            _conn.Close();
        }
    }
}
