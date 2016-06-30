using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace OnTime
{
    class TravelInfo
    {
        //List for diffrent labels
        private readonly List<Label> _transportTypeList = new List<Label>();
        private readonly List<Label> _carrierList = new List<Label>();
        private readonly List<Label> _timeList = new List<Label>();
        private readonly List<Label> _stationList = new List<Label>();
        private readonly List<Label> _trackNrList = new List<Label>();

        //Start cordinates headerinfo and stationinfo
        private int _headerY = 150;
        private int _infoY = 170;

        //Counter to display header info correctly
        private int _counterHeader;

        //bool for clearing info
        private bool _clearInfo;

        //Link to classes
        private readonly Api _api;
        private readonly MainWindow _main;
        private readonly GuiControl _guiControl;
        private XmlDocument _data;
        
        public TravelInfo(MainWindow main)
        {
            _api = new Api();
            _main = main;
            _guiControl = new GuiControl(_main);
        }

        public void ShowTravelOptions()
        {
            //Set the date
            var rawDate = DateTime.Parse(_main.boxDate.Text);
            var time = _main.cbPlHour.Text + ":" + _main.cbPlMin.Text;
            var date = rawDate.ToString("yyyy-MM-dd") + "T" + time;

            //Call api and get info
            _data = _api.TravelAdvice("Amsterdam", "emmen", null, date, false, 0, 3);
            int i = 1;
            XmlNodeList nodeList = _data.SelectNodes("ReisMogelijkheden/ReisMogelijkheid");

            if (nodeList != null)
                foreach (XmlNode data in nodeList)
                {
                    string departureTime = data["ActueleVertrekTijd"]?.InnerText;
                    string arivalTime = data["ActueleAankomstTijd"]?.InnerText;

                    //Switch for displaying info
                    switch (i)
                    {
                        case 1:
                            _main.dptLBL1.Text = departureTime?.Substring(11, 5) + @" ➜ " + arivalTime?.Substring(11, 5);
                            _main.swLBL1.Text = data["AantalOverstappen"]?.InnerText;
                            _main.trtLBL2.Text = data["ActueleReisTijd"]?.InnerText;
                            break;
                        case 2:
                            _main.dptLBL2.Text = departureTime?.Substring(11, 5) + @" ➜ " + arivalTime?.Substring(11, 5);
                            _main.swLBL2.Text = data["AantalOverstappen"]?.InnerText;
                            _main.trtLBL2.Text = data["ActueleReisTijd"]?.InnerText;
                            break;
                        case 3:
                            _main.dptLBL3.Text = departureTime?.Substring(11, 5) + @" ➜ " + arivalTime?.Substring(11, 5);
                            _main.swLBL3.Text = data["AantalOverstappen"]?.InnerText;
                            _main.trtLBL3.Text = data["ActueleReisTijd"]?.InnerText;
                            _guiControl.ColorSwitch(3);
                            GetTravelOptions(3);
                            break;
                        case 4:
                            _main.dptLBL4.Text = departureTime?.Substring(11, 5) + @" ➜ " + arivalTime?.Substring(11, 5);
                            _main.swLBL4.Text = data["AantalOverstappen"]?.InnerText;
                            _main.trtLBL4.Text = data["ActueleReisTijd"]?.InnerText;
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
                        //Go to parse info
                        ParseInfo(travelOption);

                        //Set the departue label text
                        DateTime departureDate = DateTime.Parse(travelOption["ActueleVertrekTijd"]?.InnerText);
                        string departureTime = travelOption["ActueleVertrekTijd"]?.InnerText.Substring(11, 5);
                        _main.dptLBLBig.Text = @"Vertrek " + departureDate.ToString("dddd dd MMMM yyyy") + @" om " + departureTime;
                    }
                    i++;
                }
            _clearInfo = true;
        }

        public void ParseInfo(XmlNode travelOption)
        {
            bool first = true;
            string strOne = "";
            string station = "";

            //Iterate to the correct info
            var travelParts = travelOption.SelectNodes("ReisDeel");
            if (travelParts != null)
                foreach (XmlNode travelPart in travelParts)
                {
                    var travelStops = travelPart.SelectNodes("ReisStop");
                    int countStations = 0;
                    if (travelStops != null)
                        foreach (XmlNode travelStop in travelStops)
                        {
                            //Variables needed for printing the labels
                            string carrier = travelPart["Vervoerder"]?.InnerText;
                            string transportType = travelPart["VervoerType"]?.InnerText;
                            station = travelStop["Naam"]?.InnerText;
                            string time = travelStop["Tijd"]?.InnerText;
                            string trackNr = travelStop["Spoor"]?.InnerText;

                            //Print first station
                            if (countStations == 0)
                            {
                                PrintTravelOption(station, time, trackNr, carrier, transportType);
                                if (first)
                                {
                                    strOne = station;
                                    first = false;
                                }
                            }
                            //Print last Station
                            else if (countStations == travelStops.Count - 1)
                            {
                                PrintTravelOption(station, time, trackNr, null, null);
                            }
                            countStations++;
                        }
                    _main.stationNamesLBL.Text = strOne + @" ➜ " + station;
                }
        }

        public void PrintTravelOption(string station, string time, string trackNr, string carrier, string transportType)
        {

            if (_clearInfo)
            {
                ClearInfo();
                _clearInfo = false;
            }

            //Set StationNames
            _main.stationNamesLBL.Text = _main.boxDepartue.Text + @" ➜ " + _main.boxArrival.Text;

            //Print header if not null
            if (carrier != null && transportType != null)
            {
                // Print the transportType
                Label transportTypeLabel = new Label
                {
                    Location = new Point(232, _headerY),
                    Size = new Size(80, 18),
                    Font = new Font("Open Sans", 9, FontStyle.Bold),
                    Text = transportType.Substring(0, 1).ToUpper() + transportType.Substring(1)
                };
                _main.tabTravelInfo.Controls.Add(transportTypeLabel);

                //Print carrier
                Label carrierLabel = new Label
                {
                    Location = new Point(464, _headerY),
                    Size = new Size(80, 18),
                    Font = new Font("Open Sans", 9, FontStyle.Bold),
                    Text = carrier
                };
                _main.tabTravelInfo.Controls.Add(carrierLabel);

                //Add labels to the list
                _transportTypeList.Add(transportTypeLabel);
                _carrierList.Add(carrierLabel);

                _headerY += 60;

                //Adds more space for the headers
                if (_counterHeader == 1)
                {
                    _infoY += 20;
                    _counterHeader = 0;
                }

                _counterHeader++;
            }
            // Print the time
            Label timeLabel = new Label
            {
                Location = new Point(232, _infoY),
                Size = new Size(50, 13),
                Font = new Font("Open Sans", 9),
                Text = time.Substring(11, 5)
            };
            _main.tabTravelInfo.Controls.Add(timeLabel);

            // Print the station
            Label stationLabel = new Label
            {
                Location = new Point(298, _infoY),
                Size = new Size(150, 13),
                Font = new Font("Open Sans", 9),
                Text = @"Station " + station,
                Cursor = Cursors.Hand
            };
            stationLabel.Click += (s, e) =>
            {
                Departure departure = new Departure(_main);
                departure.GetDepartures(station);
                _main.tabTravelInfo.Visible = false; 
                _main.tabActualDeparture.Show();
            };

            stationLabel.MouseEnter += (s, e) => { stationLabel.ForeColor = Color.FromArgb(0, 154, 224); };
            stationLabel.MouseLeave += (s, e) => { stationLabel.ForeColor = Color.Black; };
            _main.tabTravelInfo.Controls.Add(stationLabel);

            //Print the track number
            Label trackNrLabel = new Label
            {
                Location = new Point(464, _infoY),
                Size = new Size(100, 13),
                Font = new Font("Open Sans", 9),
                Text = @"Spoor " + trackNr
            };
            _main.tabTravelInfo.Controls.Add(trackNrLabel);

            //add space between labels
            _infoY += 20;

            //Add labels to the lists
            _timeList.Add(timeLabel);
            _stationList.Add(stationLabel);
            _trackNrList.Add(trackNrLabel);
        }

        public void ClearInfo()
        {
            for (int i = 0; i <= _stationList.Count - 1; i++)
            {
                //Remove labels form controls
                if (i < _transportTypeList.Count)
                {
                    _main.tabTravelInfo.Controls.Remove(_transportTypeList[i]);
                    _main.tabTravelInfo.Controls.Remove(_carrierList[i]);

                    _transportTypeList[i].Dispose();
                    _carrierList[i].Dispose();
                }
                _main.tabTravelInfo.Controls.Remove(_timeList[i]);
                _main.tabTravelInfo.Controls.Remove(_stationList[i]);
                _main.tabTravelInfo.Controls.Remove(_trackNrList[i]);

                //Dispose of labels
                _timeList[i].Dispose();
                _stationList[i].Dispose();
                _trackNrList[i].Dispose();
                
                //Empty Lists and reset variables
                if (i == _stationList.Count)
                {
                    _transportTypeList.Clear();
                    _carrierList.Clear();
                    _timeList.Clear();
                    _stationList.Clear();
                    _trackNrList.Clear();
                }

                _headerY = 150;
                _infoY = 170;
                _counterHeader = 0;
            }
        }
    }
}
