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

        public MainWindow()
        {
            InitializeComponent();
             _guiControl = new GuiControl(this);
            _travelInfo = new TravelInfo(this);
            _alerts = new Alerts(this);

            //Set datetimepickers to current date
            boxDate.Value = DateTime.Now;
            boxTime.Value = DateTime.Now;

            //Sets global font to Open Sans
            Font = new Font("Open Sans", 8, FontStyle.Regular);
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
            tabPlanRoute.Visible = false;
            tabTravelInfo.Show();
            _travelInfo.ShowTravelOptions();
        }

        private void Alerts_Click(object sender, EventArgs e)
        {
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
    }
}


