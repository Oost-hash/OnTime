using MySql.Data.MySqlClient;
using System;
//using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace OnTime
{
    class Routes
    {

        private readonly Api _api;
        private readonly MainWindow _main;
        private int _infoY = 50;
        private readonly Database _DBconect = new Database();
        private Dictionary<int, string> lijst = Database.ReadData();
        public MySqlConnection _conn;
        //for printing the plannend or unplannend header
        // private bool _first = true;

        // private MySqlConnection _conn ;
        //string Connection = "server=127.0.0.1;uid=root;" + "pwd=;database=";

        public Routes(MainWindow main)
        {
            _api = new Api();
            _main = main;
            _DBconect.DBconect("open");
            GetRoutes();
        }

        public Routes()
        {

        }

        public void GetRoutes()
        {

            if (_DBconect.DBconect("open"))
            {
                foreach (KeyValuePair<int,string> kaas in lijst)
                {
                    Console.WriteLine(kaas.Key + " : ");
                    Console.WriteLine("             " + kaas.Value);
                }
            }
            else
            {

            }

        }
    }
}
