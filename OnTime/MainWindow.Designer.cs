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
            this.travelInfo1 = new OnTime.TravelInfo();
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
            // travelInfo1
            // 
            this.travelInfo1.Location = new System.Drawing.Point(12, 12);
            this.travelInfo1.Name = "travelInfo1";
            this.travelInfo1.Size = new System.Drawing.Size(580, 394);
            this.travelInfo1.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 453);
            this.Controls.Add(this.travelInfo1);
            this.Controls.Add(this.boxTime);
            this.Controls.Add(this.boxDate);
            this.Controls.Add(this.btnTravelAdvice);
            this.Controls.Add(this.boxArrival);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.boxDepartue);
            this.Name = "MainWindow";
            this.Text = "OnTime";
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
        private TravelInfo travelInfo1;
    }
}

