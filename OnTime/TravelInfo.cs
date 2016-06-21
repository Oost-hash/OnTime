using System;
using System.Windows.Forms;
using System.Xml;

namespace OnTime
{
    public partial class TravelInfo : UserControl
    {
        private GuiControl _guiControl;
        private readonly Api _api;
        private XmlDocument _data;

        public TravelInfo()
        {
            InitializeComponent();
            _guiControl = new GuiControl(this);
            _api = new Api();
            Visible = false;
        }

        public void ShowTravelAdvice()
        {
            //var rawDate = DateTime.Parse(boxDate.Text);
            //var time = boxTime.Text;
            //var date = rawDate.ToString("yyyy-MM-dd") + "T" + time;

            //_data = _api.TravelAdvice("Amsterdam", "emmen", null, date, false, 0, 3);
            //int i = 1;
            //XmlNodeList nodeList = _data.SelectNodes("ReisMogelijkheden/ReisMogelijkheid");

            //if (nodeList != null)
            //    foreach (XmlNode data in nodeList)
            //    {
            //        string departureTime = data["ActueleVertrekTijd"]?.InnerText;
            //        string arivalTime = data["ActueleAankomstTijd"]?.InnerText;

            //        switch (i)
            //        {
            //            case 1:
            //                dptLBL1.Text = departureTime?.Substring(11, 5) + @" ➜ " + arivalTime?.Substring(11, 5);
            //                swLBL1.Text = data["AantalOverstappen"]?.InnerText;
            //                trtLBL1.Text = data["ActueleReisTijd"]?.InnerText;
            //                break;
            //            case 2:
            //                dptLBL2.Text = departureTime?.Substring(11, 5) + @" ➜ " + arivalTime?.Substring(11, 5);
            //                swLBL2.Text = data["AantalOverstappen"]?.InnerText;
            //                trtLBL2.Text = data["ActueleReisTijd"]?.InnerText;
            //                break;
            //            case 3:
            //                dptLBL3.Text = departureTime?.Substring(11, 5) + @" ➜ " + arivalTime?.Substring(11, 5);
            //                swLBL3.Text = data["AantalOverstappen"]?.InnerText;
            //                _ucTravelInfo.trtLBL3.Text = data["ActueleReisTijd"]?.InnerText;
            //                break;
            //            case 4:
            //                dptLBL4.Text = departureTime?.Substring(11, 5) + @" ➜ " + arivalTime?.Substring(11, 5);
            //                swLBL4.Text = data["AantalOverstappen"]?.InnerText;
            //                trtLBL4.Text = data["ActueleReisTijd"]?.InnerText;
            //                break;
            //        }
            //        i++;
            //    }
        }



        public void GetTravelInfo(int x)
        {
            int i = 1;
            XmlNodeList travelOptions = _data.SelectNodes("ReisMogelijkheden/ReisMogelijkheid");
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
            XmlNodeList travelParts = travelOption.SelectNodes("ReisDeel");
            if (travelParts != null)
                foreach (XmlNode travelPart in travelParts)
                {
                    XmlNodeList travelStops = travelPart.SelectNodes("ReisStop");
                    int i = 0;
                    if (travelStops != null)
                        foreach (XmlNode travelStop in travelStops)
                        {
                            if (i == 0)
                            {
                                Console.WriteLine(travelStop.InnerText);
                            }
                            else if (i == travelStops.Count - 1)
                            {
                                Console.WriteLine(travelStop.InnerText);
                                Console.WriteLine(travelStop["Spoor"]?.InnerText);
                            }
                            i++;
                        }
                }
        }
    }
}