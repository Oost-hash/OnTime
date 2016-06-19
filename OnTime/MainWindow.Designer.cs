namespace OnTime
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.boxDepartue = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.boxArrival = new System.Windows.Forms.TextBox();
            this.btnTravelAdvice = new System.Windows.Forms.Button();
            this.boxDate = new System.Windows.Forms.DateTimePicker();
            this.boxTime = new System.Windows.Forms.DateTimePicker();
            this.trtLBL1 = new System.Windows.Forms.Label();
            this.swLBL1 = new System.Windows.Forms.Label();
            this.LBLsw1 = new System.Windows.Forms.Label();
            this.LBLtt1 = new System.Windows.Forms.Label();
            this.dptLBL1 = new System.Windows.Forms.Label();
            this.info4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.info3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.info2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.info1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.dptLBL2 = new System.Windows.Forms.Label();
            this.LBLtt2 = new System.Windows.Forms.Label();
            this.LBLsw2 = new System.Windows.Forms.Label();
            this.swLBL2 = new System.Windows.Forms.Label();
            this.trtLBL2 = new System.Windows.Forms.Label();
            this.dptLBL3 = new System.Windows.Forms.Label();
            this.LBLtt3 = new System.Windows.Forms.Label();
            this.LBLsw3 = new System.Windows.Forms.Label();
            this.swLBL3 = new System.Windows.Forms.Label();
            this.trtLBL3 = new System.Windows.Forms.Label();
            this.dptLBL4 = new System.Windows.Forms.Label();
            this.LBLtt4 = new System.Windows.Forms.Label();
            this.LBLsw4 = new System.Windows.Forms.Label();
            this.swLBL4 = new System.Windows.Forms.Label();
            this.trtLBL4 = new System.Windows.Forms.Label();
            this.panTravelInfo = new System.Windows.Forms.Panel();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.panTravelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxDepartue
            // 
            this.boxDepartue.Location = new System.Drawing.Point(643, 28);
            this.boxDepartue.Name = "boxDepartue";
            this.boxDepartue.Size = new System.Drawing.Size(100, 20);
            this.boxDepartue.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(643, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // boxArrival
            // 
            this.boxArrival.Location = new System.Drawing.Point(643, 102);
            this.boxArrival.Name = "boxArrival";
            this.boxArrival.Size = new System.Drawing.Size(100, 20);
            this.boxArrival.TabIndex = 2;
            // 
            // btnTravelAdvice
            // 
            this.btnTravelAdvice.BackColor = System.Drawing.Color.OrangeRed;
            this.btnTravelAdvice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTravelAdvice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTravelAdvice.ForeColor = System.Drawing.Color.White;
            this.btnTravelAdvice.Location = new System.Drawing.Point(643, 154);
            this.btnTravelAdvice.Name = "btnTravelAdvice";
            this.btnTravelAdvice.Size = new System.Drawing.Size(102, 23);
            this.btnTravelAdvice.TabIndex = 3;
            this.btnTravelAdvice.Text = "Plan mijn reis";
            this.btnTravelAdvice.UseVisualStyleBackColor = false;
            this.btnTravelAdvice.Click += new System.EventHandler(this.btnTravelAdvice_Click);
            // 
            // boxDate
            // 
            this.boxDate.CustomFormat = "dd-MM-yyyy";
            this.boxDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.boxDate.Location = new System.Drawing.Point(625, 128);
            this.boxDate.Name = "boxDate";
            this.boxDate.Size = new System.Drawing.Size(74, 20);
            this.boxDate.TabIndex = 4;
            // 
            // boxTime
            // 
            this.boxTime.CustomFormat = "HH:MM";
            this.boxTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.boxTime.Location = new System.Drawing.Point(705, 128);
            this.boxTime.Name = "boxTime";
            this.boxTime.ShowUpDown = true;
            this.boxTime.Size = new System.Drawing.Size(58, 20);
            this.boxTime.TabIndex = 5;
            // 
            // trtLBL1
            // 
            this.trtLBL1.AutoSize = true;
            this.trtLBL1.BackColor = System.Drawing.Color.Transparent;
            this.trtLBL1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trtLBL1.Location = new System.Drawing.Point(87, 83);
            this.trtLBL1.Name = "trtLBL1";
            this.trtLBL1.Size = new System.Drawing.Size(52, 13);
            this.trtLBL1.TabIndex = 7;
            this.trtLBL1.Text = "traveltime";
            this.trtLBL1.Click += new System.EventHandler(this.info1_Click);
            // 
            // swLBL1
            // 
            this.swLBL1.AutoSize = true;
            this.swLBL1.BackColor = System.Drawing.Color.Transparent;
            this.swLBL1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swLBL1.Location = new System.Drawing.Point(87, 65);
            this.swLBL1.Name = "swLBL1";
            this.swLBL1.Size = new System.Drawing.Size(50, 13);
            this.swLBL1.TabIndex = 8;
            this.swLBL1.Text = "Switches";
            this.swLBL1.Click += new System.EventHandler(this.info1_Click);
            // 
            // LBLsw1
            // 
            this.LBLsw1.AutoSize = true;
            this.LBLsw1.BackColor = System.Drawing.Color.Transparent;
            this.LBLsw1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.LBLsw1.Location = new System.Drawing.Point(19, 65);
            this.LBLsw1.Name = "LBLsw1";
            this.LBLsw1.Size = new System.Drawing.Size(71, 13);
            this.LBLsw1.TabIndex = 9;
            this.LBLsw1.Text = "Overstappen:";
            this.LBLsw1.UseWaitCursor = true;
            this.LBLsw1.Click += new System.EventHandler(this.info1_Click);
            // 
            // LBLtt1
            // 
            this.LBLtt1.AutoSize = true;
            this.LBLtt1.BackColor = System.Drawing.Color.Transparent;
            this.LBLtt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBLtt1.Location = new System.Drawing.Point(19, 83);
            this.LBLtt1.Name = "LBLtt1";
            this.LBLtt1.Size = new System.Drawing.Size(72, 13);
            this.LBLtt1.TabIndex = 10;
            this.LBLtt1.Text = "Totale reistijd:";
            this.LBLtt1.Click += new System.EventHandler(this.info1_Click);
            // 
            // dptLBL1
            // 
            this.dptLBL1.AutoSize = true;
            this.dptLBL1.BackColor = System.Drawing.Color.Transparent;
            this.dptLBL1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dptLBL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptLBL1.Location = new System.Drawing.Point(19, 43);
            this.dptLBL1.Name = "dptLBL1";
            this.dptLBL1.Size = new System.Drawing.Size(162, 17);
            this.dptLBL1.TabIndex = 11;
            this.dptLBL1.Text = "departure and arrival";
            this.dptLBL1.Click += new System.EventHandler(this.info1_Click);
            // 
            // info4
            // 
            this.info4.BackColor = System.Drawing.Color.Transparent;
            this.info4.BorderColor = System.Drawing.Color.Transparent;
            this.info4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.info4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info4.FillColor = System.Drawing.Color.Transparent;
            this.info4.FillGradientColor = System.Drawing.Color.Transparent;
            this.info4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.info4.Location = new System.Drawing.Point(14, 274);
            this.info4.Name = "info4";
            this.info4.SelectionColor = System.Drawing.Color.Transparent;
            this.info4.Size = new System.Drawing.Size(127, 77);
            this.info4.Click += new System.EventHandler(this.info4_Click);
            // 
            // info3
            // 
            this.info3.BackColor = System.Drawing.Color.Transparent;
            this.info3.BorderColor = System.Drawing.Color.Transparent;
            this.info3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.info3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info3.FillColor = System.Drawing.Color.Transparent;
            this.info3.FillGradientColor = System.Drawing.Color.Transparent;
            this.info3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.info3.Location = new System.Drawing.Point(14, 193);
            this.info3.Name = "info3";
            this.info3.SelectionColor = System.Drawing.Color.Transparent;
            this.info3.Size = new System.Drawing.Size(127, 77);
            this.info3.Click += new System.EventHandler(this.info3_Click);
            // 
            // info2
            // 
            this.info2.BackColor = System.Drawing.Color.Transparent;
            this.info2.BorderColor = System.Drawing.Color.Transparent;
            this.info2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.info2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info2.FillColor = System.Drawing.Color.Transparent;
            this.info2.FillGradientColor = System.Drawing.Color.Transparent;
            this.info2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.info2.Location = new System.Drawing.Point(14, 113);
            this.info2.Name = "info2";
            this.info2.SelectionColor = System.Drawing.Color.Transparent;
            this.info2.Size = new System.Drawing.Size(127, 77);
            this.info2.Click += new System.EventHandler(this.info2_Click);
            // 
            // info1
            // 
            this.info1.BackColor = System.Drawing.Color.Transparent;
            this.info1.BorderColor = System.Drawing.Color.Transparent;
            this.info1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.info1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info1.FillColor = System.Drawing.Color.Transparent;
            this.info1.FillGradientColor = System.Drawing.Color.Transparent;
            this.info1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.info1.Location = new System.Drawing.Point(14, 33);
            this.info1.Name = "info1";
            this.info1.SelectionColor = System.Drawing.Color.Transparent;
            this.info1.Size = new System.Drawing.Size(127, 77);
            this.info1.Click += new System.EventHandler(this.info1_Click);
            // 
            // dptLBL2
            // 
            this.dptLBL2.AutoSize = true;
            this.dptLBL2.BackColor = System.Drawing.Color.Transparent;
            this.dptLBL2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dptLBL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptLBL2.Location = new System.Drawing.Point(19, 122);
            this.dptLBL2.Name = "dptLBL2";
            this.dptLBL2.Size = new System.Drawing.Size(162, 17);
            this.dptLBL2.TabIndex = 35;
            this.dptLBL2.Text = "departure and arrival";
            this.dptLBL2.Click += new System.EventHandler(this.info2_Click);
            // 
            // LBLtt2
            // 
            this.LBLtt2.AutoSize = true;
            this.LBLtt2.BackColor = System.Drawing.Color.Transparent;
            this.LBLtt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBLtt2.Location = new System.Drawing.Point(19, 163);
            this.LBLtt2.Name = "LBLtt2";
            this.LBLtt2.Size = new System.Drawing.Size(72, 13);
            this.LBLtt2.TabIndex = 34;
            this.LBLtt2.Text = "Totale reistijd:";
            this.LBLtt2.Click += new System.EventHandler(this.info2_Click);
            // 
            // LBLsw2
            // 
            this.LBLsw2.AutoSize = true;
            this.LBLsw2.BackColor = System.Drawing.Color.Transparent;
            this.LBLsw2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.LBLsw2.Location = new System.Drawing.Point(19, 145);
            this.LBLsw2.Name = "LBLsw2";
            this.LBLsw2.Size = new System.Drawing.Size(71, 13);
            this.LBLsw2.TabIndex = 33;
            this.LBLsw2.Text = "Overstappen:";
            this.LBLsw2.UseWaitCursor = true;
            this.LBLsw2.Click += new System.EventHandler(this.info2_Click);
            // 
            // swLBL2
            // 
            this.swLBL2.AutoSize = true;
            this.swLBL2.BackColor = System.Drawing.Color.Transparent;
            this.swLBL2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swLBL2.Location = new System.Drawing.Point(87, 145);
            this.swLBL2.Name = "swLBL2";
            this.swLBL2.Size = new System.Drawing.Size(50, 13);
            this.swLBL2.TabIndex = 32;
            this.swLBL2.Text = "Switches";
            this.swLBL2.Click += new System.EventHandler(this.info2_Click);
            // 
            // trtLBL2
            // 
            this.trtLBL2.AutoSize = true;
            this.trtLBL2.BackColor = System.Drawing.Color.Transparent;
            this.trtLBL2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trtLBL2.Location = new System.Drawing.Point(87, 163);
            this.trtLBL2.Name = "trtLBL2";
            this.trtLBL2.Size = new System.Drawing.Size(52, 13);
            this.trtLBL2.TabIndex = 31;
            this.trtLBL2.Text = "traveltime";
            this.trtLBL2.Click += new System.EventHandler(this.info2_Click);
            // 
            // dptLBL3
            // 
            this.dptLBL3.AutoSize = true;
            this.dptLBL3.BackColor = System.Drawing.Color.Transparent;
            this.dptLBL3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dptLBL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptLBL3.Location = new System.Drawing.Point(19, 202);
            this.dptLBL3.Name = "dptLBL3";
            this.dptLBL3.Size = new System.Drawing.Size(162, 17);
            this.dptLBL3.TabIndex = 40;
            this.dptLBL3.Text = "departure and arrival";
            this.dptLBL3.Click += new System.EventHandler(this.info3_Click);
            // 
            // LBLtt3
            // 
            this.LBLtt3.AutoSize = true;
            this.LBLtt3.BackColor = System.Drawing.Color.Transparent;
            this.LBLtt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBLtt3.Location = new System.Drawing.Point(19, 243);
            this.LBLtt3.Name = "LBLtt3";
            this.LBLtt3.Size = new System.Drawing.Size(72, 13);
            this.LBLtt3.TabIndex = 39;
            this.LBLtt3.Text = "Totale reistijd:";
            this.LBLtt3.Click += new System.EventHandler(this.info3_Click);
            // 
            // LBLsw3
            // 
            this.LBLsw3.AutoSize = true;
            this.LBLsw3.BackColor = System.Drawing.Color.Transparent;
            this.LBLsw3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.LBLsw3.Location = new System.Drawing.Point(19, 225);
            this.LBLsw3.Name = "LBLsw3";
            this.LBLsw3.Size = new System.Drawing.Size(71, 13);
            this.LBLsw3.TabIndex = 38;
            this.LBLsw3.Text = "Overstappen:";
            this.LBLsw3.UseWaitCursor = true;
            this.LBLsw3.Click += new System.EventHandler(this.info3_Click);
            // 
            // swLBL3
            // 
            this.swLBL3.AutoSize = true;
            this.swLBL3.BackColor = System.Drawing.Color.Transparent;
            this.swLBL3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swLBL3.Location = new System.Drawing.Point(87, 225);
            this.swLBL3.Name = "swLBL3";
            this.swLBL3.Size = new System.Drawing.Size(50, 13);
            this.swLBL3.TabIndex = 37;
            this.swLBL3.Text = "Switches";
            this.swLBL3.Click += new System.EventHandler(this.info3_Click);
            // 
            // trtLBL3
            // 
            this.trtLBL3.AutoSize = true;
            this.trtLBL3.BackColor = System.Drawing.Color.Transparent;
            this.trtLBL3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trtLBL3.Location = new System.Drawing.Point(87, 243);
            this.trtLBL3.Name = "trtLBL3";
            this.trtLBL3.Size = new System.Drawing.Size(52, 13);
            this.trtLBL3.TabIndex = 36;
            this.trtLBL3.Text = "traveltime";
            this.trtLBL3.Click += new System.EventHandler(this.info3_Click);
            // 
            // dptLBL4
            // 
            this.dptLBL4.AutoSize = true;
            this.dptLBL4.BackColor = System.Drawing.Color.Transparent;
            this.dptLBL4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dptLBL4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptLBL4.Location = new System.Drawing.Point(19, 284);
            this.dptLBL4.Name = "dptLBL4";
            this.dptLBL4.Size = new System.Drawing.Size(162, 17);
            this.dptLBL4.TabIndex = 45;
            this.dptLBL4.Text = "departure and arrival";
            this.dptLBL4.Click += new System.EventHandler(this.info4_Click);
            // 
            // LBLtt4
            // 
            this.LBLtt4.AutoSize = true;
            this.LBLtt4.BackColor = System.Drawing.Color.Transparent;
            this.LBLtt4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBLtt4.Location = new System.Drawing.Point(18, 324);
            this.LBLtt4.Name = "LBLtt4";
            this.LBLtt4.Size = new System.Drawing.Size(72, 13);
            this.LBLtt4.TabIndex = 44;
            this.LBLtt4.Text = "Totale reistijd:";
            this.LBLtt4.Click += new System.EventHandler(this.info4_Click);
            // 
            // LBLsw4
            // 
            this.LBLsw4.AutoSize = true;
            this.LBLsw4.BackColor = System.Drawing.Color.Transparent;
            this.LBLsw4.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.LBLsw4.Location = new System.Drawing.Point(18, 306);
            this.LBLsw4.Name = "LBLsw4";
            this.LBLsw4.Size = new System.Drawing.Size(71, 13);
            this.LBLsw4.TabIndex = 43;
            this.LBLsw4.Text = "Overstappen:";
            this.LBLsw4.UseWaitCursor = true;
            this.LBLsw4.Click += new System.EventHandler(this.info4_Click);
            // 
            // swLBL4
            // 
            this.swLBL4.AutoSize = true;
            this.swLBL4.BackColor = System.Drawing.Color.Transparent;
            this.swLBL4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swLBL4.Location = new System.Drawing.Point(87, 306);
            this.swLBL4.Name = "swLBL4";
            this.swLBL4.Size = new System.Drawing.Size(50, 13);
            this.swLBL4.TabIndex = 42;
            this.swLBL4.Text = "Switches";
            this.swLBL4.Click += new System.EventHandler(this.info4_Click);
            // 
            // trtLBL4
            // 
            this.trtLBL4.AutoSize = true;
            this.trtLBL4.BackColor = System.Drawing.Color.Transparent;
            this.trtLBL4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trtLBL4.Location = new System.Drawing.Point(87, 324);
            this.trtLBL4.Name = "trtLBL4";
            this.trtLBL4.Size = new System.Drawing.Size(52, 13);
            this.trtLBL4.TabIndex = 41;
            this.trtLBL4.Text = "traveltime";
            this.trtLBL4.Click += new System.EventHandler(this.info4_Click);
            // 
            // panTravelInfo
            // 
            this.panTravelInfo.Controls.Add(this.dptLBL1);
            this.panTravelInfo.Controls.Add(this.dptLBL4);
            this.panTravelInfo.Controls.Add(this.trtLBL1);
            this.panTravelInfo.Controls.Add(this.LBLtt4);
            this.panTravelInfo.Controls.Add(this.swLBL1);
            this.panTravelInfo.Controls.Add(this.LBLsw4);
            this.panTravelInfo.Controls.Add(this.LBLsw1);
            this.panTravelInfo.Controls.Add(this.swLBL4);
            this.panTravelInfo.Controls.Add(this.LBLtt1);
            this.panTravelInfo.Controls.Add(this.trtLBL4);
            this.panTravelInfo.Controls.Add(this.trtLBL2);
            this.panTravelInfo.Controls.Add(this.dptLBL3);
            this.panTravelInfo.Controls.Add(this.swLBL2);
            this.panTravelInfo.Controls.Add(this.LBLtt3);
            this.panTravelInfo.Controls.Add(this.LBLsw2);
            this.panTravelInfo.Controls.Add(this.LBLsw3);
            this.panTravelInfo.Controls.Add(this.LBLtt2);
            this.panTravelInfo.Controls.Add(this.swLBL3);
            this.panTravelInfo.Controls.Add(this.dptLBL2);
            this.panTravelInfo.Controls.Add(this.trtLBL3);
            this.panTravelInfo.Controls.Add(this.shapeContainer2);
            this.panTravelInfo.Location = new System.Drawing.Point(12, 12);
            this.panTravelInfo.Name = "panTravelInfo";
            this.panTravelInfo.Size = new System.Drawing.Size(607, 395);
            this.panTravelInfo.TabIndex = 46;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.info4,
            this.info3,
            this.info2,
            this.info1});
            this.shapeContainer2.Size = new System.Drawing.Size(607, 395);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 453);
            this.Controls.Add(this.panTravelInfo);
            this.Controls.Add(this.boxTime);
            this.Controls.Add(this.boxDate);
            this.Controls.Add(this.btnTravelAdvice);
            this.Controls.Add(this.boxArrival);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.boxDepartue);
            this.Name = "MainWindow";
            this.Text = "OnTime";
            this.panTravelInfo.ResumeLayout(false);
            this.panTravelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxDepartue;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox boxArrival;
        private System.Windows.Forms.Button btnTravelAdvice;
        private System.Windows.Forms.DateTimePicker boxDate;
        private System.Windows.Forms.DateTimePicker boxTime;
        public Microsoft.VisualBasic.PowerPacks.RectangleShape info1;
        public Microsoft.VisualBasic.PowerPacks.RectangleShape info4;
        public Microsoft.VisualBasic.PowerPacks.RectangleShape info3;
        public Microsoft.VisualBasic.PowerPacks.RectangleShape info2;
        public System.Windows.Forms.Label trtLBL1;
        public System.Windows.Forms.Label swLBL1;
        public System.Windows.Forms.Label LBLsw1;
        public System.Windows.Forms.Label LBLtt1;
        public System.Windows.Forms.Label dptLBL1;
        public System.Windows.Forms.Label dptLBL2;
        public System.Windows.Forms.Label LBLtt2;
        public System.Windows.Forms.Label LBLsw2;
        public System.Windows.Forms.Label swLBL2;
        public System.Windows.Forms.Label trtLBL2;
        public System.Windows.Forms.Label dptLBL3;
        public System.Windows.Forms.Label LBLtt3;
        public System.Windows.Forms.Label LBLsw3;
        public System.Windows.Forms.Label swLBL3;
        public System.Windows.Forms.Label trtLBL3;
        public System.Windows.Forms.Label dptLBL4;
        public System.Windows.Forms.Label LBLtt4;
        public System.Windows.Forms.Label LBLsw4;
        public System.Windows.Forms.Label swLBL4;
        public System.Windows.Forms.Label trtLBL4;
        private System.Windows.Forms.Panel panTravelInfo;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
    }
}

