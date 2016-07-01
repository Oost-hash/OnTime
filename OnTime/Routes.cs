using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;

namespace OnTime
{
    class Routes
    {
        //fields for printfunction
        private int _i;
        private List<Label> _alertList = new List<Label>();
        private List<Label> _removeList = new List<Label>();
        private List<Label> _headerList = new List<Label>();
        private List<Label> _leaveAndArrivaList = new List<Label>();
        private bool _clearAlerts;


        private readonly Api _api;
        private readonly MainWindow _main;
        private readonly Database _dbConnect;
        private XmlDocument _data;

        public Routes(MainWindow main)
        {
            _api = new Api();
            _main = main;
            _dbConnect = new Database();

            //If no database connection show and disable button
            _main.lblNoDatabase.Visible = false;
            if (_dbConnect.DBconect("open") == null)
            {
                _main.btnAddRoute.Enabled = false;
                _main.lblNoDatabase.Visible = true;
            }
        }

        private int _startY = 58;

        public void GetRoutes()
        {

            if (_dbConnect != null)
            {
                MySqlDataReader read = _dbConnect.ReadData();
                while (read.Read())
                {
                    int id = (int)read.GetValue(0);
                    string departure = (string)read.GetValue(1);
                    string arrival = (string)read.GetValue(2);
                    string arrivalTime = (string)read.GetValue(4);
                    string departureTime = (string)read.GetValue(5);

                    string dateArrival = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd") + "T" + arrivalTime;
                    string dateDeparture = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd") + "T" + departureTime;


                    _data = _api.TravelAdvice(departure, arrival, null, dateArrival, true, 5, 5);
                    PrintRoute(id, departure, arrival, false);
                    _data = _api.TravelAdvice(departure, arrival, null, dateDeparture, true, 5, 5);
                    PrintRoute(id, departure, arrival, true);
                }
                _clearAlerts = true;
                read.Close();
            }
        }

        public void PrintRoute(int idDb, string departure, string arrival, bool home)
        {

            if (_clearAlerts)
            {
                ClearRoutes();
                _clearAlerts = false;
            }

            string departureTime = null;
            string arrivalTime = null;
            string id = null;
            string message = null;


            XmlNodeList routes = _data.SelectNodes("ReisMogelijkheden/ReisMogelijkheid");
            if (routes != null)
            {
                foreach (XmlNode optimaleRoute in routes)
                {
                    if (optimaleRoute["Optimaal"].InnerXml.Equals("true") && _i == 0)
                    {
                        _i++;

                        departureTime = optimaleRoute["ActueleVertrekTijd"]?.InnerText;
                        arrivalTime = optimaleRoute["ActueleAankomstTijd"]?.InnerText;


                        if (optimaleRoute["Melding"] != null)
                        {
                            var alerts = optimaleRoute.SelectNodes("Melding");
                            if (alerts != null)
                                foreach (XmlNode alert in alerts)
                                {
                                    id = alert["Id"]?.InnerText;
                                    message = alert["Text"]?.InnerText;
                                }
                        }
                    }
                }
                _i = 0;
            }

            //Print header if not null
            if (departure != null && arrival != null && !home)
            {
                // Print the header
                Label headerLabel = new Label
                {
                    Location = new Point(15, _startY),
                    Size = new Size(400, 18),
                    Font = new Font("Open Sans", 9, FontStyle.Bold),
                    Text = @"Station " + departure + @" ➜ Station " + arrival
                };
                _headerList.Add(headerLabel);
                _main.tabOnTime.Controls.Add(headerLabel);

                _startY += 20;
            }

            //Print header if not null
            if (departure != null && arrival != null && home)
            {
                // Print the header
                Label headerLabel = new Label
                {
                    Location = new Point(15, _startY),
                    Size = new Size(400, 18),
                    Font = new Font("Open Sans", 9, FontStyle.Bold),
                    Text = @"Station " + arrival + @" ➜ Station " + departure
                };
                _headerList.Add(headerLabel);
                _main.tabOnTime.Controls.Add(headerLabel);

                _startY += 20;
            }

            if (id != null)
                {
                    // Print alert label
                    Label alertLabel = new Label
                    {
                        Location = new Point(15, _startY),
                        Size = new Size(200, 18),
                        Font = new Font("Open Sans", 9, FontStyle.Bold),
                        ForeColor = Color.DarkOrange,
                        Cursor = Cursors.Hand,
                        Text = message
                    };
                    alertLabel.Click += (s, e) =>
                    {
                        Alerts alert = new Alerts(_main);
                        MessageBox.Show(alert.FindAlert(id));
                    };

                    alertLabel.MouseEnter += (s, e) => { alertLabel.ForeColor = Color.Black; };
                    alertLabel.MouseLeave += (s, e) => { alertLabel.ForeColor = Color.DarkOrange; };

                    _alertList.Add(alertLabel);
                    _main.tabOnTime.Controls.Add(alertLabel);

                    _startY += 20;
                }

                // Print the transportType
                string departureDate = DateTime.Parse(departureTime).ToString("dd-MMMM-yyyy");

                Label leaveAndArrivaLabel  = new Label
                {
                    Location = new Point(15, _startY),
                    Size = new Size(600, 18),
                    Font = new Font("Open Sans", 9),
                    Text = @"Vertrek morgen "+ departureDate + @" om "   + departureTime?.Substring(11,5) + @" aankomst om " + arrivalTime?.Substring(11,5)
                };
                _main.tabOnTime.Controls.Add(leaveAndArrivaLabel);

                //Add labels to the lists
                _leaveAndArrivaList.Add(leaveAndArrivaLabel);

                _startY += 20;

                Label removeLabel = new Label
                {
                    Location = new Point(15, _startY),
                    Size = new Size(50, 18),
                    Font = new Font("Open Sans", 9),
                    ForeColor = Color.FromArgb(0, 154, 224),
                    Cursor = Cursors.Hand,
                    Text = @"Verwijderen"
                };
                 removeLabel.Click += (s, e) =>
                 {
                     Database remove = new Database();
                     DialogResult dialogResult = MessageBox.Show(@"Verwijderen?", @"Route verwijderen", MessageBoxButtons.YesNo);
                     if (dialogResult == DialogResult.Yes)
                     {
                         remove.Remove(idDb);
                     }              
                 };
            removeLabel.MouseEnter += (s, e) => { removeLabel.ForeColor = Color.Black; };
            removeLabel.MouseLeave += (s, e) => { removeLabel.ForeColor = Color.FromArgb(0, 154, 224); };

            //Add labels to the lists
            _removeList.Add(removeLabel);

            _main.tabOnTime.Controls.Add(removeLabel);

            _startY += 40;
        }

        private void ClearRoutes()
        {
            for (int index = 0; index <= _removeList.Count - 1; index++)
            {
                //Remove labels form controls
                _main.tabOnTime.Controls.Remove(_leaveAndArrivaList[index]);
                _main.tabOnTime.Controls.Remove(_removeList[index]);
                if (index < _alertList.Count)
                {
                    _main.tabOnTime.Controls.Remove(_alertList[index]);
                    _alertList[index].Dispose();
                }
                _main.tabOnTime.Controls.Remove(_headerList[index]);

                //Dispose of labels
                _leaveAndArrivaList[index].Dispose();
                _removeList[index].Dispose();
                _headerList[index].Dispose();

                //Empty Lists and reset variables
                if (index == _removeList.Count)
                {
                    _leaveAndArrivaList.Clear();
                    _removeList.Clear();
                    _headerList.Clear();
                    _alertList.Clear();
                }

                _startY = 58;
            }
        }
    }
}
