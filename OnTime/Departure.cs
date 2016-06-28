
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Xml;

namespace OnTime
{
    class Departure
    {

        private Api _api;
        private XmlDocument _dataDeparture;
        private MainWindow _main;

        //Start cordinates
        private int _infoY = 98;

        public Departure(MainWindow main)
        {
            _api = new Api();
            _main = main;
        }

        public void GetDepartures(string station)
        {
            _dataDeparture = _api.Departure(station);

            XmlNodeList departure = _dataDeparture.SelectNodes("ActueleVertrekTijden/VertrekkendeTrein");

            if (departure != null)
                foreach (XmlNode trains in departure)
                {
                    string time = trains["VertrekTijd"].InnerText;
                    string destenation = trains["EindBestemming"].InnerText;
                    string track = trains["VertrekSpoor"].InnerText;
                    string carrier = trains["Vervoerder"].InnerText;

                    PrintDeparture(time);
                }
        }

        public void PrintDeparture(string time)
        {
            // Print the transportType
            Label timeDepLabel = new Label
            {
                Location = new Point(92, _infoY),
                Size = new Size(80, 18),
                Font = new Font("Open Sans", 9, FontStyle.Bold),
                Text = time
            };
            _main.MainControl.TabPages[2].Controls.Add(timeDepLabel);

            _infoY += 20;

        }
    }
}
