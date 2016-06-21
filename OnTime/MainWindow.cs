using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;


namespace OnTime
{
    public partial class MainWindow : Form
    {

        private readonly Api _api;
        private XmlDocument _data;
        private readonly GuiControl _guiControl;

        public MainWindow()
        {
            InitializeComponent();
             _guiControl = new GuiControl(this);
            _api = new Api();


            //Set datetimepickers to current date
            boxDate.Value = DateTime.Now;
            boxTime.Value = DateTime.Now;

            Font = new Font("Open Sans", 8, FontStyle.Regular);
        }



        public void ShowTravelOptions()
        {
            var rawDate = DateTime.Parse(boxDate.Text);
            var time = boxTime.Text;
            var date = rawDate.ToString("yyyy-MM-dd") + "T" + time;

            _data = _api.TravelAdvice("Amsterdam", "emmen", null, date, false, 0, 3);
            int i = 1;
            XmlNodeList nodeList = _data.SelectNodes("ReisMogelijkheden/ReisMogelijkheid");

            if (nodeList != null)
                foreach (XmlNode data in nodeList)
                {
                    string departureTime = data["ActueleVertrekTijd"]?.InnerText;
                    string arivalTime = data["ActueleAankomstTijd"]?.InnerText;

                    switch (i)
                    {
                        case 1:
                            dptLBL1.Text = departureTime?.Substring(11, 5) + @" ➜ " + arivalTime?.Substring(11, 5);
                            swLBL1.Text = data["AantalOverstappen"]?.InnerText;
                            trtLBL2.Text = data["ActueleReisTijd"]?.InnerText;
                            break;
                        case 2:
                            dptLBL2.Text = departureTime?.Substring(11, 5) + @" ➜ " + arivalTime?.Substring(11, 5);
                            swLBL2.Text = data["AantalOverstappen"]?.InnerText;
                            trtLBL2.Text = data["ActueleReisTijd"]?.InnerText;
                            break;
                        case 3:
                            dptLBL3.Text = departureTime?.Substring(11, 5) + @" ➜ " + arivalTime?.Substring(11, 5);
                            swLBL3.Text = data["AantalOverstappen"]?.InnerText;
                            trtLBL3.Text = data["ActueleReisTijd"]?.InnerText;
                            break;
                        case 4:
                            dptLBL4.Text = departureTime?.Substring(11, 5) + @" ➜ " + arivalTime?.Substring(11, 5);
                            swLBL4.Text = data["AantalOverstappen"]?.InnerText;
                            trtLBL4.Text = data["ActueleReisTijd"]?.InnerText;
                            break;
                    }
                    i++;
                }
        }


        public void GetTravelOptions(int x)
        {
            var i = 1;
            var travelOptions = _data.SelectNodes("ReisMogelijkheden/ReisMogelijkheid");
            if (travelOptions != null)
                foreach (XmlNode travelOption in travelOptions)
                {
                    if (i == x)
                    {
                        ParseInfo(travelOption);
                    }
                    i++;
                }
        }

        public void ParseInfo(XmlNode travelOption)
        {
            var travelParts = travelOption.SelectNodes("ReisDeel");
            if (travelParts != null)
                foreach (XmlNode travelPart in travelParts)
                {
                    var travelStops = travelPart.SelectNodes("ReisStop");
                    var i = 0;
                    if (travelStops != null)
                        foreach (XmlNode travelStop in travelStops)
                        {
                            string carrier = travelPart["Vervoerder"]?.InnerText;
                            string transportType = travelPart["VervoerType"]?.InnerText;
                            string station = travelStop["Naam"]?.InnerText;
                            string time = travelStop["Tijd"]?.InnerText;
                            string trackNr = travelStop["Spoor"]?.InnerText;

                            if (i == 0)
                            {
                                PrintTravelOption(carrier, transportType, station, time, trackNr);
                            }
                            else if (i == travelStops.Count - 1)
                            {
                                PrintTravelOption(null, null, station, time, trackNr);
                            }
                            i++;
                        }
                }
        }


        private int _headerY = 110;
        private int _infoY = 140;

        public void PrintTravelOption(string carrier, string transportType, string station, string time, string trackNr)
        {
            //Print header if not null
            if (carrier != null && transportType != null)
            {
                // Print the transportType
                Label transportTypeLabel = new Label
                {
                    Location = new Point(252, _headerY),
                    Size = new Size(80, 30),
                    Font = new Font("Open Sans", 9, FontStyle.Bold),
                    Text = transportType.Substring(0, 1).ToUpper() + transportType.Substring(1)
                };
                panTravelInfo.Controls.Add(transportTypeLabel);

                //Print carrier
                Label carrierLabel = new Label
                {
                    Location = new Point(498, _headerY),
                    Size = new Size(80, 30),
                    Font = new Font("Open Sans", 9),
                    Text = carrier
                };
                panTravelInfo.Controls.Add(carrierLabel);
            }
            // Print the transportType
            Label timeLabel = new Label
            {
                Location = new Point(252, _infoY),
                Size = new Size(80, 20),
                Font = new Font("Open Sans", 9),
                Text = time.Substring(11,5)
            };
            panTravelInfo.Controls.Add(timeLabel);

            // Print the station
            Label stationLabel = new Label
            {
                Location = new Point(332, _infoY),
                Size = new Size(150, 20),
                Font = new Font("Open Sans", 9),
                Text = @"Station " + station
            };
            panTravelInfo.Controls.Add(stationLabel);

            //Print the track number
            Label trackNrLabel = new Label
            {
                Location = new Point(498, _infoY),
                Size = new Size(100, 20),
                Font = new Font("Open Sans", 9),
                Text = @"Spoor " + trackNr
            };
            panTravelInfo.Controls.Add(trackNrLabel);
            _infoY += 35;
        }

        private void info1_click(object sender, EventArgs e)
        {
            _guiControl.ColorSwitch(1);
            GetTravelOptions(1);
        }

        
        private void info2_click(object sender, EventArgs e)
        {
            _guiControl.ColorSwitch(2);
        }

        private void info3_click(object sender, EventArgs e)
        {
            _guiControl.ColorSwitch(3);
        }

        private void info4_click(object sender, EventArgs e)
        {
            _guiControl.ColorSwitch(4);
        }

        private void btnTravelAdvice_Click(object sender, EventArgs e)
        {
            ShowTravelOptions();
        }

    }
}


