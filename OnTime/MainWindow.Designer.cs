namespace OnTime
{
    sealed partial class MainWindow
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
            this.MainControl = new OnTime.TabControlHeaders();
            this.tabPlanRoute = new System.Windows.Forms.TabPage();
            this.boxTime = new System.Windows.Forms.DateTimePicker();
            this.boxDate = new System.Windows.Forms.DateTimePicker();
            this.boxDepartue = new System.Windows.Forms.TextBox();
            this.btnTravelAdvice = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.boxArrival = new System.Windows.Forms.TextBox();
            this.tabTravelInfo = new System.Windows.Forms.TabPage();
            this.dptLBLBig = new System.Windows.Forms.Label();
            this.stationNamesLBL = new System.Windows.Forms.Label();
            this.dptLBL1 = new System.Windows.Forms.Label();
            this.LBLsw4 = new System.Windows.Forms.Label();
            this.LBLsw2 = new System.Windows.Forms.Label();
            this.LBLtt2 = new System.Windows.Forms.Label();
            this.trtLBL3 = new System.Windows.Forms.Label();
            this.swLBL1 = new System.Windows.Forms.Label();
            this.LBLtt4 = new System.Windows.Forms.Label();
            this.trtLBL1 = new System.Windows.Forms.Label();
            this.swLBL3 = new System.Windows.Forms.Label();
            this.dptLBL3 = new System.Windows.Forms.Label();
            this.dptLBL2 = new System.Windows.Forms.Label();
            this.swLBL4 = new System.Windows.Forms.Label();
            this.trtLBL2 = new System.Windows.Forms.Label();
            this.dptLBL4 = new System.Windows.Forms.Label();
            this.swLBL2 = new System.Windows.Forms.Label();
            this.trtLBL4 = new System.Windows.Forms.Label();
            this.LBLtt3 = new System.Windows.Forms.Label();
            this.LBLsw1 = new System.Windows.Forms.Label();
            this.LBLsw3 = new System.Windows.Forms.Label();
            this.LBLtt1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.info4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.info3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.info2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.info1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.tabActualDeparture = new System.Windows.Forms.TabPage();
            this.carrierLabel = new System.Windows.Forms.Label();
            this.trackLabel = new System.Windows.Forms.Label();
            this.destLBL = new System.Windows.Forms.Label();
            this.timeLBL = new System.Windows.Forms.Label();
            this.stationLBL = new System.Windows.Forms.Label();
            this.MainControl.SuspendLayout();
            this.tabPlanRoute.SuspendLayout();
            this.tabTravelInfo.SuspendLayout();
            this.tabActualDeparture.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainControl
            // 
            this.MainControl.Controls.Add(this.tabPlanRoute);
            this.MainControl.Controls.Add(this.tabTravelInfo);
            this.MainControl.Controls.Add(this.tabActualDeparture);
            this.MainControl.Location = new System.Drawing.Point(2, -2);
            this.MainControl.Name = "MainControl";
            this.MainControl.SelectedIndex = 0;
            this.MainControl.Size = new System.Drawing.Size(613, 487);
            this.MainControl.TabIndex = 9;
            // 
            // tabPlanRoute
            // 
            this.tabPlanRoute.Controls.Add(this.boxTime);
            this.tabPlanRoute.Controls.Add(this.boxDate);
            this.tabPlanRoute.Controls.Add(this.boxDepartue);
            this.tabPlanRoute.Controls.Add(this.btnTravelAdvice);
            this.tabPlanRoute.Controls.Add(this.textBox2);
            this.tabPlanRoute.Controls.Add(this.boxArrival);
            this.tabPlanRoute.Location = new System.Drawing.Point(4, 22);
            this.tabPlanRoute.Name = "tabPlanRoute";
            this.tabPlanRoute.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlanRoute.Size = new System.Drawing.Size(605, 461);
            this.tabPlanRoute.TabIndex = 0;
            this.tabPlanRoute.Text = "Search";
            this.tabPlanRoute.UseVisualStyleBackColor = true;
            // 
            // boxTime
            // 
            this.boxTime.CustomFormat = "HH:MM";
            this.boxTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.boxTime.Location = new System.Drawing.Point(192, 248);
            this.boxTime.Name = "boxTime";
            this.boxTime.ShowUpDown = true;
            this.boxTime.Size = new System.Drawing.Size(58, 20);
            this.boxTime.TabIndex = 5;
            // 
            // boxDate
            // 
            this.boxDate.CustomFormat = "dd-MM-yyyy";
            this.boxDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.boxDate.Location = new System.Drawing.Point(112, 248);
            this.boxDate.Name = "boxDate";
            this.boxDate.Size = new System.Drawing.Size(74, 20);
            this.boxDate.TabIndex = 4;
            // 
            // boxDepartue
            // 
            this.boxDepartue.Location = new System.Drawing.Point(130, 148);
            this.boxDepartue.Name = "boxDepartue";
            this.boxDepartue.Size = new System.Drawing.Size(100, 20);
            this.boxDepartue.TabIndex = 0;
            // 
            // btnTravelAdvice
            // 
            this.btnTravelAdvice.BackColor = System.Drawing.Color.OrangeRed;
            this.btnTravelAdvice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTravelAdvice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTravelAdvice.ForeColor = System.Drawing.Color.White;
            this.btnTravelAdvice.Location = new System.Drawing.Point(130, 274);
            this.btnTravelAdvice.Name = "btnTravelAdvice";
            this.btnTravelAdvice.Size = new System.Drawing.Size(102, 23);
            this.btnTravelAdvice.TabIndex = 3;
            this.btnTravelAdvice.Text = "Plan mijn reis";
            this.btnTravelAdvice.UseVisualStyleBackColor = false;
            this.btnTravelAdvice.Click += new System.EventHandler(this.btnTravelAdvice_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // boxArrival
            // 
            this.boxArrival.Location = new System.Drawing.Point(130, 222);
            this.boxArrival.Name = "boxArrival";
            this.boxArrival.Size = new System.Drawing.Size(100, 20);
            this.boxArrival.TabIndex = 2;
            // 
            // tabTravelInfo
            // 
            this.tabTravelInfo.Controls.Add(this.dptLBLBig);
            this.tabTravelInfo.Controls.Add(this.stationNamesLBL);
            this.tabTravelInfo.Controls.Add(this.dptLBL1);
            this.tabTravelInfo.Controls.Add(this.LBLsw4);
            this.tabTravelInfo.Controls.Add(this.LBLsw2);
            this.tabTravelInfo.Controls.Add(this.LBLtt2);
            this.tabTravelInfo.Controls.Add(this.trtLBL3);
            this.tabTravelInfo.Controls.Add(this.swLBL1);
            this.tabTravelInfo.Controls.Add(this.LBLtt4);
            this.tabTravelInfo.Controls.Add(this.trtLBL1);
            this.tabTravelInfo.Controls.Add(this.swLBL3);
            this.tabTravelInfo.Controls.Add(this.dptLBL3);
            this.tabTravelInfo.Controls.Add(this.dptLBL2);
            this.tabTravelInfo.Controls.Add(this.swLBL4);
            this.tabTravelInfo.Controls.Add(this.trtLBL2);
            this.tabTravelInfo.Controls.Add(this.dptLBL4);
            this.tabTravelInfo.Controls.Add(this.swLBL2);
            this.tabTravelInfo.Controls.Add(this.trtLBL4);
            this.tabTravelInfo.Controls.Add(this.LBLtt3);
            this.tabTravelInfo.Controls.Add(this.LBLsw1);
            this.tabTravelInfo.Controls.Add(this.LBLsw3);
            this.tabTravelInfo.Controls.Add(this.LBLtt1);
            this.tabTravelInfo.Controls.Add(this.shapeContainer1);
            this.tabTravelInfo.Location = new System.Drawing.Point(4, 22);
            this.tabTravelInfo.Name = "tabTravelInfo";
            this.tabTravelInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTravelInfo.Size = new System.Drawing.Size(605, 461);
            this.tabTravelInfo.TabIndex = 1;
            this.tabTravelInfo.Text = "TravelInfo";
            this.tabTravelInfo.UseVisualStyleBackColor = true;
            // 
            // dptLBLBig
            // 
            this.dptLBLBig.AutoSize = true;
            this.dptLBLBig.Location = new System.Drawing.Point(232, 110);
            this.dptLBLBig.Name = "dptLBLBig";
            this.dptLBLBig.Size = new System.Drawing.Size(41, 13);
            this.dptLBLBig.TabIndex = 48;
            this.dptLBLBig.Text = "Vertrek";
            // 
            // stationNamesLBL
            // 
            this.stationNamesLBL.AutoSize = true;
            this.stationNamesLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.stationNamesLBL.Location = new System.Drawing.Point(232, 80);
            this.stationNamesLBL.Name = "stationNamesLBL";
            this.stationNamesLBL.Size = new System.Drawing.Size(138, 24);
            this.stationNamesLBL.TabIndex = 47;
            this.stationNamesLBL.Text = "StationNames";
            // 
            // dptLBL1
            // 
            this.dptLBL1.AutoSize = true;
            this.dptLBL1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dptLBL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptLBL1.Location = new System.Drawing.Point(21, 30);
            this.dptLBL1.Name = "dptLBL1";
            this.dptLBL1.Size = new System.Drawing.Size(159, 17);
            this.dptLBL1.TabIndex = 21;
            this.dptLBL1.Text = "Vertrek en Aankomst";
            this.dptLBL1.Click += new System.EventHandler(this.info1_click);
            // 
            // LBLsw4
            // 
            this.LBLsw4.AutoSize = true;
            this.LBLsw4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBLsw4.Location = new System.Drawing.Point(21, 403);
            this.LBLsw4.Name = "LBLsw4";
            this.LBLsw4.Size = new System.Drawing.Size(74, 13);
            this.LBLsw4.TabIndex = 37;
            this.LBLsw4.Text = "Overstappen: ";
            this.LBLsw4.Click += new System.EventHandler(this.info4_click);
            // 
            // LBLsw2
            // 
            this.LBLsw2.AutoSize = true;
            this.LBLsw2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBLsw2.Location = new System.Drawing.Point(21, 174);
            this.LBLsw2.Name = "LBLsw2";
            this.LBLsw2.Size = new System.Drawing.Size(74, 13);
            this.LBLsw2.TabIndex = 27;
            this.LBLsw2.Text = "Overstappen: ";
            this.LBLsw2.Click += new System.EventHandler(this.info2_click);
            // 
            // LBLtt2
            // 
            this.LBLtt2.AutoSize = true;
            this.LBLtt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBLtt2.Location = new System.Drawing.Point(21, 199);
            this.LBLtt2.Name = "LBLtt2";
            this.LBLtt2.Size = new System.Drawing.Size(72, 13);
            this.LBLtt2.TabIndex = 30;
            this.LBLtt2.Text = "Totale reistijd:";
            this.LBLtt2.Click += new System.EventHandler(this.info2_click);
            // 
            // trtLBL3
            // 
            this.trtLBL3.AutoSize = true;
            this.trtLBL3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trtLBL3.Location = new System.Drawing.Point(101, 312);
            this.trtLBL3.Name = "trtLBL3";
            this.trtLBL3.Size = new System.Drawing.Size(36, 13);
            this.trtLBL3.TabIndex = 34;
            this.trtLBL3.Text = "reistijd";
            this.trtLBL3.Click += new System.EventHandler(this.info3_click);
            // 
            // swLBL1
            // 
            this.swLBL1.AutoSize = true;
            this.swLBL1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swLBL1.Location = new System.Drawing.Point(101, 60);
            this.swLBL1.Name = "swLBL1";
            this.swLBL1.Size = new System.Drawing.Size(32, 13);
            this.swLBL1.TabIndex = 23;
            this.swLBL1.Text = "stops";
            this.swLBL1.Click += new System.EventHandler(this.info1_click);
            // 
            // LBLtt4
            // 
            this.LBLtt4.AutoSize = true;
            this.LBLtt4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBLtt4.Location = new System.Drawing.Point(21, 428);
            this.LBLtt4.Name = "LBLtt4";
            this.LBLtt4.Size = new System.Drawing.Size(72, 13);
            this.LBLtt4.TabIndex = 40;
            this.LBLtt4.Text = "Totale reistijd:";
            this.LBLtt4.Click += new System.EventHandler(this.info4_click);
            // 
            // trtLBL1
            // 
            this.trtLBL1.AutoSize = true;
            this.trtLBL1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trtLBL1.Location = new System.Drawing.Point(101, 85);
            this.trtLBL1.Name = "trtLBL1";
            this.trtLBL1.Size = new System.Drawing.Size(36, 13);
            this.trtLBL1.TabIndex = 24;
            this.trtLBL1.Text = "reistijd";
            this.trtLBL1.Click += new System.EventHandler(this.info1_click);
            // 
            // swLBL3
            // 
            this.swLBL3.AutoSize = true;
            this.swLBL3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swLBL3.Location = new System.Drawing.Point(101, 287);
            this.swLBL3.Name = "swLBL3";
            this.swLBL3.Size = new System.Drawing.Size(32, 13);
            this.swLBL3.TabIndex = 33;
            this.swLBL3.Text = "stops";
            this.swLBL3.Click += new System.EventHandler(this.info3_click);
            // 
            // dptLBL3
            // 
            this.dptLBL3.AutoSize = true;
            this.dptLBL3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dptLBL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptLBL3.Location = new System.Drawing.Point(21, 257);
            this.dptLBL3.Name = "dptLBL3";
            this.dptLBL3.Size = new System.Drawing.Size(159, 17);
            this.dptLBL3.TabIndex = 31;
            this.dptLBL3.Text = "Vertrek en Aankomst";
            this.dptLBL3.Click += new System.EventHandler(this.info3_click);
            // 
            // dptLBL2
            // 
            this.dptLBL2.AutoSize = true;
            this.dptLBL2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dptLBL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptLBL2.Location = new System.Drawing.Point(21, 144);
            this.dptLBL2.Name = "dptLBL2";
            this.dptLBL2.Size = new System.Drawing.Size(159, 17);
            this.dptLBL2.TabIndex = 26;
            this.dptLBL2.Text = "Vertrek en Aankomst";
            this.dptLBL2.Click += new System.EventHandler(this.info2_click);
            // 
            // swLBL4
            // 
            this.swLBL4.AutoSize = true;
            this.swLBL4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swLBL4.Location = new System.Drawing.Point(101, 403);
            this.swLBL4.Name = "swLBL4";
            this.swLBL4.Size = new System.Drawing.Size(32, 13);
            this.swLBL4.TabIndex = 38;
            this.swLBL4.Text = "stops";
            this.swLBL4.Click += new System.EventHandler(this.info4_click);
            // 
            // trtLBL2
            // 
            this.trtLBL2.AutoSize = true;
            this.trtLBL2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trtLBL2.Location = new System.Drawing.Point(101, 199);
            this.trtLBL2.Name = "trtLBL2";
            this.trtLBL2.Size = new System.Drawing.Size(36, 13);
            this.trtLBL2.TabIndex = 29;
            this.trtLBL2.Text = "reistijd";
            this.trtLBL2.Click += new System.EventHandler(this.info2_click);
            // 
            // dptLBL4
            // 
            this.dptLBL4.AutoSize = true;
            this.dptLBL4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dptLBL4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptLBL4.Location = new System.Drawing.Point(21, 373);
            this.dptLBL4.Name = "dptLBL4";
            this.dptLBL4.Size = new System.Drawing.Size(159, 17);
            this.dptLBL4.TabIndex = 36;
            this.dptLBL4.Text = "Vertrek en Aankomst";
            this.dptLBL4.Click += new System.EventHandler(this.info4_click);
            // 
            // swLBL2
            // 
            this.swLBL2.AutoSize = true;
            this.swLBL2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swLBL2.Location = new System.Drawing.Point(101, 174);
            this.swLBL2.Name = "swLBL2";
            this.swLBL2.Size = new System.Drawing.Size(32, 13);
            this.swLBL2.TabIndex = 28;
            this.swLBL2.Text = "stops";
            this.swLBL2.Click += new System.EventHandler(this.info2_click);
            // 
            // trtLBL4
            // 
            this.trtLBL4.AutoSize = true;
            this.trtLBL4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trtLBL4.Location = new System.Drawing.Point(101, 428);
            this.trtLBL4.Name = "trtLBL4";
            this.trtLBL4.Size = new System.Drawing.Size(36, 13);
            this.trtLBL4.TabIndex = 39;
            this.trtLBL4.Text = "reistijd";
            this.trtLBL4.Click += new System.EventHandler(this.info4_click);
            // 
            // LBLtt3
            // 
            this.LBLtt3.AutoSize = true;
            this.LBLtt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBLtt3.Location = new System.Drawing.Point(21, 312);
            this.LBLtt3.Name = "LBLtt3";
            this.LBLtt3.Size = new System.Drawing.Size(72, 13);
            this.LBLtt3.TabIndex = 35;
            this.LBLtt3.Text = "Totale reistijd:";
            this.LBLtt3.Click += new System.EventHandler(this.info3_click);
            // 
            // LBLsw1
            // 
            this.LBLsw1.AutoSize = true;
            this.LBLsw1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBLsw1.Location = new System.Drawing.Point(21, 60);
            this.LBLsw1.Name = "LBLsw1";
            this.LBLsw1.Size = new System.Drawing.Size(74, 13);
            this.LBLsw1.TabIndex = 22;
            this.LBLsw1.Text = "Overstappen: ";
            this.LBLsw1.Click += new System.EventHandler(this.info1_click);
            // 
            // LBLsw3
            // 
            this.LBLsw3.AutoSize = true;
            this.LBLsw3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBLsw3.Location = new System.Drawing.Point(21, 287);
            this.LBLsw3.Name = "LBLsw3";
            this.LBLsw3.Size = new System.Drawing.Size(74, 13);
            this.LBLsw3.TabIndex = 32;
            this.LBLsw3.Text = "Overstappen: ";
            this.LBLsw3.Click += new System.EventHandler(this.info3_click);
            // 
            // LBLtt1
            // 
            this.LBLtt1.AutoSize = true;
            this.LBLtt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBLtt1.Location = new System.Drawing.Point(21, 85);
            this.LBLtt1.Name = "LBLtt1";
            this.LBLtt1.Size = new System.Drawing.Size(72, 13);
            this.LBLtt1.TabIndex = 25;
            this.LBLtt1.Text = "Totale reistijd:";
            this.LBLtt1.Click += new System.EventHandler(this.info1_click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.info4,
            this.info3,
            this.info2,
            this.info1});
            this.shapeContainer1.Size = new System.Drawing.Size(599, 455);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // info4
            // 
            this.info4.BorderColor = System.Drawing.Color.Transparent;
            this.info4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info4.FillColor = System.Drawing.Color.Transparent;
            this.info4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.info4.Location = new System.Drawing.Point(6, 352);
            this.info4.Name = "info4";
            this.info4.SelectionColor = System.Drawing.Color.Transparent;
            this.info4.Size = new System.Drawing.Size(144, 109);
            this.info4.Click += new System.EventHandler(this.info4_click);
            // 
            // info3
            // 
            this.info3.BorderColor = System.Drawing.Color.Transparent;
            this.info3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info3.FillColor = System.Drawing.Color.Transparent;
            this.info3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.info3.Location = new System.Drawing.Point(6, 237);
            this.info3.Name = "info3";
            this.info3.SelectionColor = System.Drawing.Color.Transparent;
            this.info3.Size = new System.Drawing.Size(144, 109);
            this.info3.Click += new System.EventHandler(this.info3_click);
            // 
            // info2
            // 
            this.info2.BorderColor = System.Drawing.Color.Transparent;
            this.info2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info2.FillColor = System.Drawing.Color.Transparent;
            this.info2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.info2.Location = new System.Drawing.Point(6, 123);
            this.info2.Name = "info2";
            this.info2.SelectionColor = System.Drawing.Color.Transparent;
            this.info2.Size = new System.Drawing.Size(144, 109);
            this.info2.Click += new System.EventHandler(this.info2_click);
            // 
            // info1
            // 
            this.info1.BorderColor = System.Drawing.Color.Transparent;
            this.info1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info1.FillColor = System.Drawing.Color.Transparent;
            this.info1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.info1.Location = new System.Drawing.Point(6, 8);
            this.info1.Name = "info1";
            this.info1.SelectionColor = System.Drawing.Color.Transparent;
            this.info1.Size = new System.Drawing.Size(144, 109);
            this.info1.Click += new System.EventHandler(this.info1_click);
            // 
            // tabActualDeparture
            // 
            this.tabActualDeparture.Controls.Add(this.carrierLabel);
            this.tabActualDeparture.Controls.Add(this.trackLabel);
            this.tabActualDeparture.Controls.Add(this.destLBL);
            this.tabActualDeparture.Controls.Add(this.timeLBL);
            this.tabActualDeparture.Controls.Add(this.stationLBL);
            this.tabActualDeparture.Location = new System.Drawing.Point(4, 22);
            this.tabActualDeparture.Name = "tabActualDeparture";
            this.tabActualDeparture.Padding = new System.Windows.Forms.Padding(3);
            this.tabActualDeparture.Size = new System.Drawing.Size(605, 461);
            this.tabActualDeparture.TabIndex = 2;
            this.tabActualDeparture.Text = "ActualDeparture";
            this.tabActualDeparture.UseVisualStyleBackColor = true;
            // 
            // carrierLabel
            // 
            this.carrierLabel.AutoSize = true;
            this.carrierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carrierLabel.Location = new System.Drawing.Point(450, 129);
            this.carrierLabel.Name = "carrierLabel";
            this.carrierLabel.Size = new System.Drawing.Size(73, 13);
            this.carrierLabel.TabIndex = 4;
            this.carrierLabel.Text = "Vervoerder:";
            // 
            // trackLabel
            // 
            this.trackLabel.AutoSize = true;
            this.trackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackLabel.Location = new System.Drawing.Point(324, 129);
            this.trackLabel.Name = "trackLabel";
            this.trackLabel.Size = new System.Drawing.Size(44, 13);
            this.trackLabel.TabIndex = 3;
            this.trackLabel.Text = "Spoor:";
            // 
            // destLBL
            // 
            this.destLBL.AutoSize = true;
            this.destLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destLBL.Location = new System.Drawing.Point(186, 129);
            this.destLBL.Name = "destLBL";
            this.destLBL.Size = new System.Drawing.Size(58, 13);
            this.destLBL.TabIndex = 2;
            this.destLBL.Text = "Richting:";
            // 
            // timeLBL
            // 
            this.timeLBL.AutoSize = true;
            this.timeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLBL.Location = new System.Drawing.Point(120, 129);
            this.timeLBL.Name = "timeLBL";
            this.timeLBL.Size = new System.Drawing.Size(32, 13);
            this.timeLBL.TabIndex = 1;
            this.timeLBL.Text = "Tijd:";
            // 
            // stationLBL
            // 
            this.stationLBL.AutoSize = true;
            this.stationLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationLBL.Location = new System.Drawing.Point(120, 93);
            this.stationLBL.Name = "stationLBL";
            this.stationLBL.Size = new System.Drawing.Size(87, 26);
            this.stationLBL.TabIndex = 0;
            this.stationLBL.Text = "Station";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 484);
            this.Controls.Add(this.MainControl);
            this.Name = "MainWindow";
            this.Text = "OnTime";
            this.MainControl.ResumeLayout(false);
            this.tabPlanRoute.ResumeLayout(false);
            this.tabPlanRoute.PerformLayout();
            this.tabTravelInfo.ResumeLayout(false);
            this.tabTravelInfo.PerformLayout();
            this.tabActualDeparture.ResumeLayout(false);
            this.tabActualDeparture.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public TabControlHeaders MainControl;
        private System.Windows.Forms.TabPage tabPlanRoute;
        public System.Windows.Forms.TabPage tabTravelInfo;
        public System.Windows.Forms.DateTimePicker boxTime;
        public System.Windows.Forms.DateTimePicker boxDate;
        public System.Windows.Forms.TextBox boxDepartue;
        private System.Windows.Forms.Button btnTravelAdvice;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox boxArrival;
        public System.Windows.Forms.Label stationNamesLBL;
        public System.Windows.Forms.Label dptLBL1;
        public System.Windows.Forms.Label LBLsw4;
        public System.Windows.Forms.Label LBLsw2;
        public System.Windows.Forms.Label LBLtt2;
        public System.Windows.Forms.Label trtLBL3;
        public System.Windows.Forms.Label swLBL1;
        public System.Windows.Forms.Label LBLtt4;
        public System.Windows.Forms.Label trtLBL1;
        public System.Windows.Forms.Label swLBL3;
        public System.Windows.Forms.Label dptLBL3;
        public System.Windows.Forms.Label dptLBL2;
        public System.Windows.Forms.Label swLBL4;
        public System.Windows.Forms.Label trtLBL2;
        public System.Windows.Forms.Label dptLBL4;
        public System.Windows.Forms.Label swLBL2;
        public System.Windows.Forms.Label trtLBL4;
        public System.Windows.Forms.Label LBLtt3;
        public System.Windows.Forms.Label LBLsw1;
        public System.Windows.Forms.Label LBLsw3;
        public System.Windows.Forms.Label LBLtt1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        public Microsoft.VisualBasic.PowerPacks.RectangleShape info4;
        public Microsoft.VisualBasic.PowerPacks.RectangleShape info3;
        public Microsoft.VisualBasic.PowerPacks.RectangleShape info2;
        public Microsoft.VisualBasic.PowerPacks.RectangleShape info1;
        public System.Windows.Forms.Label dptLBLBig;
        public System.Windows.Forms.TabPage tabActualDeparture;
        public System.Windows.Forms.Label stationLBL;
        private System.Windows.Forms.Label carrierLabel;
        private System.Windows.Forms.Label trackLabel;
        private System.Windows.Forms.Label destLBL;
        private System.Windows.Forms.Label timeLBL;
    }
}

