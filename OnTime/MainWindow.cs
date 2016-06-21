using System;
using System.Windows.Forms;
using System.Xml;

namespace OnTime
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();

            //Set datetimepickers to current date
            boxDate.Value = DateTime.Now;
            boxTime.Value = DateTime.Now;
        }

        private void btnTravelAdvice_Click(object sender, EventArgs e)
        {
            travelInfo1.Visible = true;
            travelInfo1.ShowTravelAdvice();
        }
    }
}


