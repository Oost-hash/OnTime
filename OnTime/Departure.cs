using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace OnTime
{
    class Departure
    {
        //class and form fields
        private readonly Api _api;
        private readonly MainWindow _main;

        //XML document for data parsing
        private XmlDocument _dataDeparture;

        //List for diffrent labels
        private readonly List<Label> _timeList = new List<Label>();
        private readonly List<Label> _trackList = new List<Label>();
        private readonly List<Label> _direcitionList = new List<Label>();
        private readonly List<Label> _carrierList = new List<Label>();
        private readonly List<Label> _routeList = new List<Label>();

        //Start cordinates
        private int _infoY = 110;

        public Departure(MainWindow main)
        {
            _api = new Api();
            _main = main;

            ClearActual();
        }

        public void GetDepartures(string station)
        {
            _dataDeparture = _api.Departure(station);

            _main.stationLBL.Text = @"Station " + station;

            XmlNodeList departure = _dataDeparture.SelectNodes("ActueleVertrekTijden/VertrekkendeTrein");

            if (departure != null)
                foreach (XmlNode trains in departure)
                {
                    string carrier = "";
                    string time = trains["VertrekTijd"]?.InnerText;
                    string direction = trains["EindBestemming"]?.InnerText;
                    string route = trains["RouteTekst"]?.InnerText;
                    string track = trains["VertrekSpoor"]?.InnerText ?? trains["TreinSoort"]?.InnerText;
                    if (trains["Vervoerder"] != null)
                    {
                        carrier = trains["Vervoerder"].InnerText;
                        PrintDeparture(time, direction, track, carrier, route);
                    }
                    else
                    {
                        PrintDeparture(time, direction, track, carrier, null); 
                    }
                }
        }

        public void PrintDeparture(string time, string direction, string track, string carrier, string route)
        {
            // Print the time label
            Label timeLabel = new Label
            {
                Location = new Point(68, _infoY),
                Size = new Size(50, 18),
                Font = new Font("Open Sans", 9, FontStyle.Bold),
                Text = time.Substring(11, 5)
            };
            _main.tabActualDeparture.Controls.Add(timeLabel);

            // Print the direction label
            Label directionLabel = new Label
            {
                Location = new Point(134, _infoY),
                Size = new Size(120, 18),
                Font = new Font("Open Sans", 9),
                Text = direction
            };
            _main.tabActualDeparture.Controls.Add(directionLabel);

            // Print the track label
            Label trackLabel = new Label
            {
                Location = new Point(272, _infoY),
                Size = new Size(120, 18),
                Font = new Font("Open Sans", 9),
                Text = track
            };
            _main.tabActualDeparture.Controls.Add(trackLabel);

            // Print the carrier label
            Label carrierLabel = new Label
            {
                Location = new Point(398, _infoY),
                Size = new Size(60, 18),
                Font = new Font("Open Sans", 9),
                Text = carrier
            };
            _main.tabActualDeparture.Controls.Add(carrierLabel);

            // Print the route label
            Label routeLabel = new Label
            {
                Location = new Point(460, _infoY),
                Size = new Size(80, 18),
                Font = new Font("Open Sans", 9),
                ForeColor = Color.FromArgb(0, 154, 224),
                Cursor = Cursors.Hand,
                Text = @"Route"
            };
            routeLabel.Click += (s, e) =>
            {
                MessageBox.Show(route ?? @"Geen tussengelegen stations");
            };
            routeLabel.MouseEnter += (s, e) =>{ routeLabel.ForeColor = Color.Black; };

            routeLabel.MouseLeave += (s, e) => { routeLabel.ForeColor = Color.FromArgb(0, 154, 224); };
            _main.tabActualDeparture.Controls.Add(routeLabel);


            //Add labels to the lists
            _timeList.Add(timeLabel);
            _direcitionList.Add(directionLabel);
            _trackList.Add(trackLabel);
            _carrierList.Add(carrierLabel);
            _routeList.Add(routeLabel);

            //Extra space between times
            _infoY += 20;

        }

        public void ClearActual()
        {
            for (int i = 0; i <= _timeList.Count - 1; i++)
            {
                //Remove labels form controls
                _main.tabActualDeparture.Controls.Remove(_timeList[i]);
                _main.tabActualDeparture.Controls.Remove(_direcitionList[i]);
                _main.tabActualDeparture.Controls.Remove(_trackList[i]);
                _main.tabActualDeparture.Controls.Remove(_carrierList[i]);
                _main.tabActualDeparture.Controls.Remove(_routeList[i]);

                //Dispose of labels
                _timeList[i].Dispose();
                _direcitionList[i].Dispose();
                _trackList[i].Dispose();
                _carrierList[i].Dispose();
                _routeList[i].Dispose();

                //Empty Lists and reset variables
                if (i == _timeList.Count)
                {
                    _carrierList.Clear();
                    _timeList.Clear();
                    _trackList.Clear();
                    _carrierList.Clear();
                    _routeList.Clear();
                }
            }
        }
    }
}
