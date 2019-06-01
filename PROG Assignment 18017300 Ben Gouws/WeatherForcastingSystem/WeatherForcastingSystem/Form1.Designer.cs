namespace WeatherForcastingSystem
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCity1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dTime = new System.Windows.Forms.DateTimePicker();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.nudWind = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dStart = new System.Windows.Forms.DateTimePicker();
            this.dEnd = new System.Windows.Forms.DateTimePicker();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.nudHumidity = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPercipitation = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.cmbCity2 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.lblmaxWindy = new System.Windows.Forms.Label();
            this.lblHumid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHumidity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Weather Forcasting System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Minimum Temperature";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Maximum Temperature";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(541, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Wind speed /d";
            // 
            // cmbCity1
            // 
            this.cmbCity1.FormattingEnabled = true;
            this.cmbCity1.Location = new System.Drawing.Point(635, 47);
            this.cmbCity1.Name = "cmbCity1";
            this.cmbCity1.Size = new System.Drawing.Size(121, 21);
            this.cmbCity1.TabIndex = 8;
            this.cmbCity1.SelectedIndexChanged += new System.EventHandler(this.cmbCity1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(557, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Previos City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(635, 73);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(793, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnEData_Click);
            // 
            // dTime
            // 
            this.dTime.Location = new System.Drawing.Point(635, 96);
            this.dTime.Name = "dTime";
            this.dTime.Size = new System.Drawing.Size(200, 20);
            this.dTime.TabIndex = 16;
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(636, 120);
            this.nudMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(120, 20);
            this.nudMin.TabIndex = 17;
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(635, 144);
            this.nudMax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(120, 20);
            this.nudMax.TabIndex = 18;
            // 
            // nudWind
            // 
            this.nudWind.Location = new System.Drawing.Point(635, 167);
            this.nudWind.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudWind.Name = "nudWind";
            this.nudWind.Size = new System.Drawing.Size(120, 20);
            this.nudWind.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Start Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "End Date";
            // 
            // dStart
            // 
            this.dStart.Location = new System.Drawing.Point(179, 298);
            this.dStart.Name = "dStart";
            this.dStart.Size = new System.Drawing.Size(200, 20);
            this.dStart.TabIndex = 22;
            // 
            // dEnd
            // 
            this.dEnd.Location = new System.Drawing.Point(462, 298);
            this.dEnd.Name = "dEnd";
            this.dEnd.Size = new System.Drawing.Size(200, 20);
            this.dEnd.TabIndex = 23;
            this.dEnd.Value = new System.DateTime(2020, 5, 25, 16, 57, 0, 0);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 324);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(673, 188);
            this.dgv1.TabIndex = 24;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(572, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Humidity";
            // 
            // nudHumidity
            // 
            this.nudHumidity.Location = new System.Drawing.Point(635, 188);
            this.nudHumidity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudHumidity.Name = "nudHumidity";
            this.nudHumidity.Size = new System.Drawing.Size(120, 20);
            this.nudHumidity.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(554, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Precipitation";
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(90, 45);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(106, 36);
            this.btnLog.TabIndex = 29;
            this.btnLog.Text = "Login";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(90, 103);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(106, 23);
            this.btnAdmin.TabIndex = 30;
            this.btnAdmin.Text = "Admin Controlls";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(632, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(223, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "You have to log in before you can edit or add.";
            // 
            // txtPercipitation
            // 
            this.txtPercipitation.Location = new System.Drawing.Point(635, 211);
            this.txtPercipitation.Name = "txtPercipitation";
            this.txtPercipitation.Size = new System.Drawing.Size(119, 20);
            this.txtPercipitation.TabIndex = 32;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(12, 293);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 33;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(697, 351);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Minmum tempreture :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(692, 374);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Maximum tempreture :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(355, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Search Forcast";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(707, 397);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Max Wind Speed :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(749, 423);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Humidity :";
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.AutoSize = true;
            this.lblMinTemp.Location = new System.Drawing.Point(808, 351);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(37, 13);
            this.lblMinTemp.TabIndex = 39;
            this.lblMinTemp.Text = "_____";
            // 
            // cmbCity2
            // 
            this.cmbCity2.FormattingEnabled = true;
            this.cmbCity2.Location = new System.Drawing.Point(747, 298);
            this.cmbCity2.Name = "cmbCity2";
            this.cmbCity2.Size = new System.Drawing.Size(121, 21);
            this.cmbCity2.TabIndex = 40;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(711, 304);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "City";
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.Location = new System.Drawing.Point(808, 374);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(37, 13);
            this.lblMaxTemp.TabIndex = 42;
            this.lblMaxTemp.Text = "_____";
            // 
            // lblmaxWindy
            // 
            this.lblmaxWindy.AutoSize = true;
            this.lblmaxWindy.Location = new System.Drawing.Point(809, 396);
            this.lblmaxWindy.Name = "lblmaxWindy";
            this.lblmaxWindy.Size = new System.Drawing.Size(37, 13);
            this.lblmaxWindy.TabIndex = 43;
            this.lblmaxWindy.Text = "_____";
            // 
            // lblHumid
            // 
            this.lblHumid.AutoSize = true;
            this.lblHumid.Location = new System.Drawing.Point(809, 423);
            this.lblHumid.Name = "lblHumid";
            this.lblHumid.Size = new System.Drawing.Size(37, 13);
            this.lblHumid.TabIndex = 44;
            this.lblHumid.Text = "_____";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 519);
            this.Controls.Add(this.lblHumid);
            this.Controls.Add(this.lblmaxWindy);
            this.Controls.Add(this.lblMaxTemp);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cmbCity2);
            this.Controls.Add(this.lblMinTemp);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtPercipitation);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nudHumidity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.dEnd);
            this.Controls.Add(this.dStart);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudWind);
            this.Controls.Add(this.nudMax);
            this.Controls.Add(this.nudMin);
            this.Controls.Add(this.dTime);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCity1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Weather Forcaster";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHumidity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCity1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dTime;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.NumericUpDown nudWind;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dStart;
        private System.Windows.Forms.DateTimePicker dEnd;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudHumidity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPercipitation;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.ComboBox cmbCity2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.Label lblmaxWindy;
        private System.Windows.Forms.Label lblHumid;
    }
}

