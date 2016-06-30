using System;
using System.Drawing;
using System.Windows.Forms;

namespace OnTime
{
    public partial class MainWindow : Form
    {
        private readonly GuiControl _guiControl;
        private readonly TravelInfo _travelInfo;
        private readonly Alerts _alerts;

        private DateTime _time;

        public MainWindow()
        {
            InitializeComponent();
             _guiControl = new GuiControl(this);
            _travelInfo = new TravelInfo(this);
            _alerts = new Alerts(this);

            //Set datetimepickers to current date
            boxDate.Value = DateTime.Now;

            //Sets global font to Open Sans
            Font = new Font("Open Sans", 8, FontStyle.Regular);

            //error lbls
            lblError1.Visible = false;
            lblError2.Visible = false;
            lblError3.Visible = false;
        }

        private void info1_click(object sender, EventArgs e)
        {
            _guiControl.ColorSwitch(1);
            _travelInfo.GetTravelOptions(1);
        }

        
        private void info2_click(object sender, EventArgs e)
        {
            _guiControl.ColorSwitch(2);
            _travelInfo.GetTravelOptions(2);
        }

        private void info3_click(object sender, EventArgs e)
        {
            _guiControl.ColorSwitch(3);
            _travelInfo.GetTravelOptions(3);
        }

        private void info4_click(object sender, EventArgs e)
        {
            _guiControl.ColorSwitch(4);
            _travelInfo.GetTravelOptions(4);
        }

        private void btnTravelAdvice_Click(object sender, EventArgs e)
        {
            //Fields neccery voor error checking
            bool error = false;

            int i;

            //Clear errors
            lblError1.Visible = false;
            lblError2.Visible = false;

            //checks if not empty or any numbers
            if (string.IsNullOrWhiteSpace(boxDepartue.Text))
            {
                lblError1.Text = @"Vul een plaats in";
                lblError1.Visible = true;
                error = true;
            }
            else if (int.TryParse(boxDepartue.Text, out i))
            {
                lblError1.Text = @"Vul een plaats in";
                lblError1.Visible = true;
                error = true;
            }

            //checks if not empty or any numbers
            if (string.IsNullOrWhiteSpace(boxArrival.Text))
            {
                lblError2.Text = @"Vul een plaats in";
                lblError2.Visible = true;
                error = true;
            }
            else if (int.TryParse(boxArrival.Text, out i))
            {
                lblError2.Text = @"Vul een plaats in";
                lblError2.Visible = true;
                error = true;
            }


            if (int.TryParse(boxVia.Text, out i))
            {
                lblError3.Text = @"Vul een plaats in";
                lblError3.Visible = true;
                error = true;
            }

            if (!error)
            {
                if (string.IsNullOrWhiteSpace(boxVia.Text))
                {
                    _travelInfo.ShowTravelOptions(boxDepartue.Text, boxArrival.Text, boxVia.Text, false, null);
                }
                else
                {
                    _travelInfo.ShowTravelOptions(boxDepartue.Text, boxArrival.Text, null, false, null);
                }

                tabPlanRoute.Visible = false;
                tabTravelInfo.Show();

                _time = DateTime.Parse(cbPlHour.Text + ":" + cbPlMin.Text);
            }
        }

        private void Alerts_Click(object sender, EventArgs e)
        {
            tabOnTime.Visible = false;
            tabPlanRoute.Visible = false;
            tabActualDeparture.Visible = false;
            tabTravelInfo.Visible = false;
            tabAlerts.Show();
            _alerts.GetAlerts(false, null);
        }

        private void btnPlanRoute_Click(object sender, EventArgs e)
        {
            tabPlanRoute.Show();
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            tabTravelInfo.Show();
        }

        private void btnZoek_Click(object sender, EventArgs e)
        {
            _alerts.GetAlerts(true, txtbCity.Text);
        }

        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            AddRoute add = new AddRoute();
            add.Show();
        }

        private void btnMyRoutes_Click(object sender, EventArgs e)
        {
            tabAlerts.Visible = false;
            tabPlanRoute.Visible = false;
            tabActualDeparture.Visible = false;
            tabTravelInfo.Visible = false;
            tabOnTime.Show();
        }

        private void EarlierTravelOpt(object sender, EventArgs e)
        {
            var rawDate = DateTime.Parse(boxDate.Text);
            _time = _time.AddHours(-1);

            var date = rawDate.ToString("yyyy-MM-dd") + "T" + _time.ToString("HH:mm");

            if (string.IsNullOrWhiteSpace(boxVia.Text))
            {
                _travelInfo.ShowTravelOptions(boxDepartue.Text, boxArrival.Text, boxVia.Text, true, date);
            }
            else
            {
                _travelInfo.ShowTravelOptions(boxDepartue.Text, boxArrival.Text, null, true, date);
            }
        }

        private void LaterTravelOpt(object sender, EventArgs e)
        {
            var rawDate = DateTime.Parse(boxDate.Text);
            _time = _time.AddHours(1);

            var date = rawDate.ToString("yyyy-MM-dd") + "T" + _time.ToString("HH:mm");

            if (string.IsNullOrWhiteSpace(boxVia.Text))
            {
                _travelInfo.ShowTravelOptions(boxDepartue.Text, boxArrival.Text, boxVia.Text, true, date);
            }
            else
            {
                _travelInfo.ShowTravelOptions(boxDepartue.Text, boxArrival.Text, null, true, date);
            }
        }
    }
}


