using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace OnTime
{
    class Alerts
    {
        private readonly Api _api;
        private XmlDocument _alerts;
        private readonly MainWindow _main;
        private int _infoY = 50;

        //for printing the plannend or unplannend header
        private bool _first = true;

        private bool _clearAlerts;

        public Alerts(MainWindow main)
        {
            _api = new Api();
            _main = main;
        }

        public void GetAlerts(bool station, string stationname)
        {
            if (station)
            {
                _alerts = _api.Disruptions(stationname, true, true);
                XmlNodeList alertsOngepland = _alerts.SelectNodes("Storingen/Ongepland/Storing");
                XmlNodeList alertsGepland = _alerts.SelectNodes("Storingen/Gepland/Storing");
                if (alertsOngepland != null)
                    foreach (XmlNode alert in alertsOngepland)
                    {
                        string traject = alert["Traject"]?.InnerText;
                        string reason = alert["Reden"]?.InnerText;
                        string message = alert["Bericht"]?.InnerText;
                        string date = alert["Datum"]?.InnerText;

                        PrintAlert(false, traject, reason, message, date, null, null, null, null);
                        _first = false;
                    }
                _first = true;

                if (alertsGepland != null)
                    foreach (XmlNode alert in alertsGepland)
                    {
                        string traject = alert["Traject"]?.InnerText;
                        string reason = alert["Reden"]?.InnerText;
                        string message = alert["Bericht"]?.InnerText;
                        string period = alert["Periode"].InnerText;
                        string advice = alert["Advies"]?.InnerText;
                        string cause = alert["Oorzaak"]?.InnerText;
                        string delay = alert["Vertraging"]?.InnerText;
                        string date = alert["Datum"]?.InnerText;

                        message = message.Replace("<br/>", "");
                        message = message.Replace("<b>", "");
                        message = message.Replace("</b>", "");
                        message = message.Replace("<p>", "");
                        message = message.Replace("</p>", "");

                        PrintAlert(true, traject, reason, message, date, period, cause, advice, delay);
                        _first = false;
                    }
                _first = true;
                _clearAlerts = true;
            }
            else
            {
                _alerts = _api.Disruptions(null, true, true);
                XmlNodeList alertsOngepland = _alerts.SelectNodes("Storingen/Ongepland/Storing");
                XmlNodeList alertsGepland = _alerts.SelectNodes("Storingen/Gepland/Storing");
                if (alertsOngepland != null)
                    foreach (XmlNode alert in alertsOngepland)
                    {
                        string traject = alert["Traject"]?.InnerText;
                        string reason = alert["Reden"]?.InnerText;
                        string message = alert["Bericht"]?.InnerText;
                        string date = alert["Datum"]?.InnerText;

                        PrintAlert(false, traject, reason, message, date, null, null, null, null);
                        _first = false;
                    }
                _first = true;

                if (alertsGepland != null)
                    foreach (XmlNode alert in alertsGepland)
                    {
                        string traject = alert["Traject"]?.InnerText;
                        string reason = alert["Reden"]?.InnerText;
                        string message = alert["Bericht"]?.InnerText;
                        string period = alert["Periode"].InnerText;
                        string advice = alert["Advies"]?.InnerText;
                        string cause = alert["Oorzaak"]?.InnerText;
                        string delay = alert["Vertraging"]?.InnerText;
                        string date = alert["Datum"]?.InnerText;

                        message = message.Replace("<br/>", "");
                        message = message.Replace("<b>", "");
                        message = message.Replace("</b>", "");
                        message = message.Replace("<p>", "");
                        message = message.Replace("</p>", "");

                        PrintAlert(true, traject, reason, message, date, period, cause, advice, delay);
                        _first = false;
                    }
                _first = true;
                _clearAlerts = true;
            }
        }

        //lists for all the labels
        private readonly List<Label> _plannendList = new List<Label>();
        private readonly List<Label> _trajectList = new List<Label>();
        private readonly List<Label> _reasonList = new List<Label>();
        private readonly List<Label> _periodList = new List<Label>();
        private readonly List<Label> _causeList = new List<Label>();
        private readonly List<Label> _dateList = new List<Label>();
        private readonly List<Label> _delayList = new List<Label>();
        private readonly List<Label> _messageList = new List<Label>();
        private readonly List<Label> _adviceList = new List<Label>();



        public void PrintAlert(bool plannend, string traject, string reason, string message, string date, string period, string cause, string advice, string delay)
        {

            if (_clearAlerts)
            {
                ClearAlerts();
                _clearAlerts = false;
            }

            if (plannend && _first)
            {
                // Print the plannend label
                Label plannendLabel = new Label
                {
                    Location = new Point(92, _infoY),
                    Size = new Size(140, 20),
                    Font = new Font("Open Sans", 12, FontStyle.Bold),
                    Text = @"Geplannend: "
                };
                _main.tabAlerts.Controls.Add(plannendLabel);

                //Add labels to the lists
                _plannendList.Add(plannendLabel);

                //Add extra space
                _infoY += 25;
            }
            else if (!plannend && _first)
            {
                // Print the unplannend label
                Label plannendLabel = new Label
                {
                    Location = new Point(92, _infoY),
                    Size = new Size(140, 20),
                    Font = new Font("Open Sans", 12, FontStyle.Bold),
                    Text = @"Ongeplannend: "
                };
                _main.tabAlerts.Controls.Add(plannendLabel);

                //Add labels to the lists
                _plannendList.Add(plannendLabel);

                //Add extra space
                _infoY += 25;
            }

            // Print the traject label
            Label trajectLabel = new Label
            {
                Location = new Point(92, _infoY),
                Size = new Size(60, 18),
                Font = new Font("Open Sans", 9, FontStyle.Bold),
                Text = @"Traject: "
            };
            _main.tabAlerts.Controls.Add(trajectLabel);

            // Print the trajectinfo
            Label trajectInfoLabel = new Label
            {
                Location = new Point(150, _infoY),
                Size = new Size(300, 18),
                Font = new Font("Open Sans", 9),
                Text = traject
            };
            _main.tabAlerts.Controls.Add(trajectInfoLabel);

            //Add labels to the lists
            _trajectList.Add(trajectLabel);
            _trajectList.Add(trajectInfoLabel);

            //Add extra space
            _infoY += 20;

            //Print reasonLabels
            if (reason != null)
            {
                // Print the reason label
                Label reasonLabel = new Label
                {
                    Location = new Point(92, _infoY),
                    Size = new Size(60, 18),
                    Font = new Font("Open Sans", 9, FontStyle.Bold),
                    Text = @"Reden: "
                };
                _main.tabAlerts.Controls.Add(reasonLabel);

                // Print the reasonInfo
                Label reasonInfoLabel = new Label
                {
                    Location = new Point(150, _infoY),
                    Size = new Size(400, 18),
                    Font = new Font("Open Sans", 9),
                    Text = reason.Substring(0, 1).ToUpper() + reason.Substring(1)
                };
                _main.tabAlerts.Controls.Add(reasonInfoLabel);

                //Add labels to the lists
                _reasonList.Add(reasonLabel);
                _reasonList.Add(reasonInfoLabel);

                //Add extra space
                _infoY += 20;
            }

            if (period != null)
            {
                // Print the reason label
                Label periodLabel = new Label
                {
                    Location = new Point(92, _infoY),
                    Size = new Size(60, 18),
                    Font = new Font("Open Sans", 9, FontStyle.Bold),
                    Text = @"Periode: "
                };
                _main.tabAlerts.Controls.Add(periodLabel);

                // Print the trajectinfo
                Label periodInfoLabel = new Label
                {
                    Location = new Point(150, _infoY),
                    Size = new Size(400, 18),
                    Font = new Font("Open Sans", 9),
                    Text = period.Substring(0, 1).ToUpper() + period.Substring(1)
                };
                _main.tabAlerts.Controls.Add(periodInfoLabel);

                //Add labels to the lists
                _periodList.Add(periodLabel);
                _periodList.Add(periodInfoLabel);

                //Add extra space
                _infoY += 20;
            }

            // Print the cause labels
            if (cause != null)
            {
                // Print the cause label
                Label causeLabel = new Label
                {
                    Location = new Point(92, _infoY),
                    Size = new Size(60, 18),
                    Font = new Font("Open Sans", 9, FontStyle.Bold),
                    Text = @"Oorzaak: "
                };
                _main.tabAlerts.Controls.Add(causeLabel);

                // Print the causeInfo
                Label causeInfoLabel = new Label
                {
                    Location = new Point(150, _infoY),
                    Size = new Size(400, 18),
                    Font = new Font("Open Sans", 9),
                    Text = cause.Substring(0,1).ToUpper() + cause.Substring(1)
                };
                _main.tabAlerts.Controls.Add(causeInfoLabel);

                //Add labels to the lists
                _causeList.Add(causeLabel);
                _causeList.Add(causeInfoLabel);

                //Add extra space
                _infoY += 20;
            }

            //Print date labels
            if (date != null)
            {
                //Print dateLabel
                Label dateLabel = new Label
                {
                    Location = new Point(92, _infoY),
                    Size = new Size(60, 18),
                    Font = new Font("Open Sans", 9, FontStyle.Bold),
                    Text = @"Datum: "
                };
                _main.tabAlerts.Controls.Add(dateLabel);

                // Print the dateInfo
                Label dateInfoLabel = new Label
                {
                    Location = new Point(150, _infoY),
                    Size = new Size(400, 18),
                    Font = new Font("Open Sans", 9),
                    Text = DateTime.Parse(date).ToString("dd MMMM yyyy") + @" om " + date.Substring(11, 5)
                };
                _main.tabAlerts.Controls.Add(dateInfoLabel);

                //Add labels to the lists
                _dateList.Add(dateLabel);
                _dateList.Add(dateInfoLabel);

                //Add extra space
                _infoY += 20;
            }
            
            //print delay labels
            if (delay != null)
            {
                //Print delayLabel
                Label delayLabel = new Label
                {
                    Location = new Point(92, _infoY),
                    Size = new Size(60, 18),
                    Font = new Font("Open Sans", 9, FontStyle.Bold),
                    Text = @"Datum: "
                };
                _main.tabAlerts.Controls.Add(delayLabel);

                // Print the delayInfo
                Label delayInfoLabel = new Label
                {
                    Location = new Point(150, _infoY),
                    Size = new Size(400, 18),
                    Font = new Font("Open Sans", 9),
                    Text = delay
                };
                _main.tabAlerts.Controls.Add(delayInfoLabel);

                //Add labels to the lists
                _delayList.Add(delayLabel);
                _delayList.Add(delayInfoLabel);

                //Add extra space
                _infoY += 20;
            }

            // Print the messageLabel
            Label messageLabel = new Label
            {
                Location = new Point(150, _infoY),
                Size = new Size(50, 18),
                Font = new Font("Open Sans", 9),
                ForeColor = Color.FromArgb(0, 154, 224),
                Cursor = Cursors.Hand,
                Text = @"Bericht"
            };
            messageLabel.Click += (s, e) =>
            {
                MessageBox.Show(message, @"Bericht van NS");
            };
            messageLabel.MouseEnter += (s, e) => { messageLabel.ForeColor = Color.Black; };
            messageLabel.MouseLeave += (s, e) => { messageLabel.ForeColor = Color.FromArgb(0, 154, 224); };

            //Add labels to the lists
            _messageList.Add(messageLabel);

            _main.tabAlerts.Controls.Add(messageLabel);

           //print advice label
            if (advice != null)
            {
                Label adviceLabel = new Label
                {
                    Location = new Point(200, _infoY),
                    Size = new Size(50, 18),
                    Font = new Font("Open Sans", 9),
                    ForeColor = Color.FromArgb(0, 154, 224),
                    Cursor = Cursors.Hand,
                    Text = @"Advies"
                };
                adviceLabel.Click += (s, e) =>
                {
                    MessageBox.Show(advice, @"Advies van NS");
                };
                adviceLabel.MouseEnter += (s, e) => { adviceLabel.ForeColor = Color.Black; };
                adviceLabel.MouseLeave += (s, e) => { adviceLabel.ForeColor = Color.FromArgb(0, 154, 224); };

                //Add labels to the lists
                _adviceList.Add(messageLabel);

                _main.tabAlerts.Controls.Add(adviceLabel);
            }

            _infoY += 30;
        }

        public void ClearAlerts()
        {

            _main.tabAlerts.VerticalScroll.Value = 0;

            for (int i = 0; i <= _messageList.Count - 1; i++)
            {
                //Remove labels form controls
                if (i < _plannendList.Count)
                {
                    _main.tabTravelInfo.Controls.Remove(_plannendList[i]);

                    _plannendList[i].Dispose();
                }
                _main.tabTravelInfo.Controls.Remove(_trajectList[i]);
                _main.tabTravelInfo.Controls.Remove(_reasonList[i]);
                _main.tabTravelInfo.Controls.Remove(_periodList[i]);
                _main.tabTravelInfo.Controls.Remove(_causeList[i]);
                if (i < _dateList.Count) { _main.tabTravelInfo.Controls.Remove(_dateList[i]); _dateList[i].Dispose(); }
                _main.tabTravelInfo.Controls.Remove(_delayList[i]);
                _main.tabTravelInfo.Controls.Remove(_messageList[i]);
                if(i < _adviceList.Count) { _main.tabTravelInfo.Controls.Remove(_adviceList[i]); _adviceList[i].Dispose(); }

                //Dispose of labels
                _trajectList[i].Dispose();
                _reasonList[i].Dispose();
                _periodList[i].Dispose();
                _causeList[i].Dispose();
                _delayList[i].Dispose();
                _messageList[i].Dispose();

                //Empty Lists and reset variables
                if (i == _messageList.Count)
                {
                    _plannendList.Clear();
                    _reasonList.Clear();
                    _periodList.Clear();
                    _causeList.Clear();
                    _dateList.Clear();
                    _delayList.Clear();
                    _messageList.Clear();
                    _adviceList.Clear();
                }

                _infoY = 50;
            }
        }
    }
}
