using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace OnTime
{
    public partial class Form1 : Form
    {
        private readonly Api _api;
        private XmlDocument _data;

        public Form1()
        {
            InitializeComponent();
            _api = new Api();

            //Set datetimepickers to current date
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rawDate = DateTime.Parse(dateTimePicker1.Text);
            var time = dateTimePicker2.Text;
            var date = rawDate.ToString("yyyy-MM-dd") + "T" + time;

            _data = _api.TravelAdvice("ut", "emmen", null, date, true, 0, 5);
            ShowTravelAdvice();
        }

        public void ShowTravelAdvice()
        {
            
        }

        private readonly List<Label> _lblOverstap = new List<Label>();

        private void button2_Click(object sender, EventArgs e)
        {
            ClearGen(0);

            var rawDate = DateTime.Parse(dateTimePicker1.Text);
            var time = dateTimePicker2.Text;
            var date = rawDate.ToString("yyyy-MM-dd") + "T" + time;

            _data = _api.TravelAdvice("ut", "emmen", null, date, true, 0, 3);
            int i = 1;
            XmlNodeList nodeList = _data.SelectNodes("ReisMogelijkheden/ReisMogelijkheid");            

            if (nodeList != null)
                foreach (XmlNode data in nodeList)
                {
                    
                    Label label = new Label();
                    var xmlElement = data["GeplandeVertrekTijd"];
                    if (xmlElement != null) label.Text = xmlElement.InnerText;
                    label.Left = 10;
                    label.Top = (i + 1) * 20;
                    i++;

                    _lblOverstap.Add(label);
                    Controls.Add(label);
                }
            else
            {
                MessageBox.Show(@"Something went wrong");
            }
        }

        private void ClearGen(int list)
        {
            if (list == 0)
            {
                if (_lblOverstap.Count > 0)
                {
                    for (int y = 0; y < _lblOverstap.Count; y++)
                    {
                        Controls.Remove(_lblOverstap[y]);
                    }

                    _lblOverstap.Clear();
                }
            }
        }
    }
}
