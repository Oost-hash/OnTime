namespace OnTime
{
    partial class AddRoute
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
            this.txtbFrom = new System.Windows.Forms.TextBox();
            this.txtbTo = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbArHour = new System.Windows.Forms.ComboBox();
            this.cbDeHour = new System.Windows.Forms.ComboBox();
            this.cbArMin = new System.Windows.Forms.ComboBox();
            this.cbDeMin = new System.Windows.Forms.ComboBox();
            this.lblError1 = new System.Windows.Forms.Label();
            this.lblError2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbFrom
            // 
            this.txtbFrom.Location = new System.Drawing.Point(101, 67);
            this.txtbFrom.Name = "txtbFrom";
            this.txtbFrom.Size = new System.Drawing.Size(200, 20);
            this.txtbFrom.TabIndex = 0;
            // 
            // txtbTo
            // 
            this.txtbTo.Location = new System.Drawing.Point(101, 93);
            this.txtbTo.Name = "txtbTo";
            this.txtbTo.Size = new System.Drawing.Size(200, 20);
            this.txtbTo.TabIndex = 1;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(59, 70);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(26, 13);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "Van";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(59, 96);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(30, 13);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "Naar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aankomst tijd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vertrek tijd";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(117, 212);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Annuleren";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(208, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbArHour
            // 
            this.cbArHour.FormattingEnabled = true;
            this.cbArHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbArHour.Location = new System.Drawing.Point(101, 120);
            this.cbArHour.Name = "cbArHour";
            this.cbArHour.Size = new System.Drawing.Size(38, 21);
            this.cbArHour.TabIndex = 10;
            this.cbArHour.Text = "00";
            // 
            // cbDeHour
            // 
            this.cbDeHour.FormattingEnabled = true;
            this.cbDeHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbDeHour.Location = new System.Drawing.Point(101, 144);
            this.cbDeHour.Name = "cbDeHour";
            this.cbDeHour.Size = new System.Drawing.Size(38, 21);
            this.cbDeHour.TabIndex = 11;
            this.cbDeHour.Text = "00";
            // 
            // cbArMin
            // 
            this.cbArMin.FormattingEnabled = true;
            this.cbArMin.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cbArMin.Location = new System.Drawing.Point(145, 120);
            this.cbArMin.Name = "cbArMin";
            this.cbArMin.Size = new System.Drawing.Size(38, 21);
            this.cbArMin.TabIndex = 12;
            this.cbArMin.Text = "00";
            // 
            // cbDeMin
            // 
            this.cbDeMin.FormattingEnabled = true;
            this.cbDeMin.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cbDeMin.Location = new System.Drawing.Point(145, 144);
            this.cbDeMin.Name = "cbDeMin";
            this.cbDeMin.Size = new System.Drawing.Size(38, 21);
            this.cbDeMin.TabIndex = 13;
            this.cbDeMin.Text = "00";
            // 
            // lblError1
            // 
            this.lblError1.AutoSize = true;
            this.lblError1.ForeColor = System.Drawing.Color.Red;
            this.lblError1.Location = new System.Drawing.Point(307, 70);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(45, 13);
            this.lblError1.TabIndex = 14;
            this.lblError1.Text = "lblError1";
            // 
            // lblError2
            // 
            this.lblError2.AutoSize = true;
            this.lblError2.ForeColor = System.Drawing.Color.Red;
            this.lblError2.Location = new System.Drawing.Point(307, 96);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(45, 13);
            this.lblError2.TabIndex = 15;
            this.lblError2.Text = "lblError2";
            // 
            // AddRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 259);
            this.Controls.Add(this.lblError2);
            this.Controls.Add(this.lblError1);
            this.Controls.Add(this.cbDeMin);
            this.Controls.Add(this.cbArMin);
            this.Controls.Add(this.cbDeHour);
            this.Controls.Add(this.cbArHour);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.txtbTo);
            this.Controls.Add(this.txtbFrom);
            this.Name = "AddRoute";
            this.ShowIcon = false;
            this.Text = "Voeg nieuwe route toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbFrom;
        private System.Windows.Forms.TextBox txtbTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbArHour;
        private System.Windows.Forms.ComboBox cbDeHour;
        private System.Windows.Forms.ComboBox cbArMin;
        private System.Windows.Forms.ComboBox cbDeMin;
        private System.Windows.Forms.Label lblError1;
        private System.Windows.Forms.Label lblError2;
    }
}