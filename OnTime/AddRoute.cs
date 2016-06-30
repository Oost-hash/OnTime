using System;
using System.Windows.Forms;

namespace OnTime
{
    public partial class AddRoute : Form
    {

        private readonly Database _db;

        public AddRoute()
        {
            InitializeComponent();
            _db = new Database();


            //Clear errors
            lblError1.Visible = false;
            lblError2.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Fields neccery voor error checking
            bool error = false;

            int i;

            //Clear errors
            lblError1.Visible = false;
            lblError2.Visible = false;

            //checks if not empty or any numbers
            if (string.IsNullOrWhiteSpace(txtbFrom.Text))
            {
                lblError1.Text = @"Vul een plaats in";
                lblError1.Visible = true;
                error = true;
            }
            else if (int.TryParse(txtbFrom.Text, out i))
            {
                lblError1.Text = @"Vul een plaats in";
                lblError1.Visible = true;
                error = true;
            }

            //checks if not empty or any numbers
            if (string.IsNullOrWhiteSpace(txtbTo.Text))
            {
                lblError2.Text = @"Vul een plaats in";
                lblError2.Visible = true;
                error = true;
            }
            else if (int.TryParse(txtbTo.Text, out i))
            {
                lblError2.Text = @"Vul een plaats in";
                lblError2.Visible = true;
                error = true;
            }

            //Create time for database
            string arrivalTime = cbArHour.Text + ":" + cbArMin.Text;
            string departureTime = cbDeHour.Text + ":" + cbDeMin.Text;

            //dit gedeelte is nog niet mogelijk omdat het contract nog niet is goedgekeurd van de ns
            //_data = _api.Prices(txtbFrom.Text, txtbTo.Text, null, null);

            int price = 0;

            //No errors? Then insert values to database
            if (error == false)
            {
                _db.InsertData(txtbFrom.Text, txtbTo.Text, arrivalTime, departureTime, price);
                Close();
            }
        }
    }
}
