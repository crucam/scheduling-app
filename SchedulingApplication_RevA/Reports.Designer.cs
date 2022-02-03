
namespace SchedulingApplication_RevA
{
    partial class Reports
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.monthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.aptTypesDGV = new System.Windows.Forms.DataGridView();
            this.aptTypeListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.scheduleBtn = new System.Windows.Forms.Button();
            this.scheduleLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userDGV = new System.Windows.Forms.DataGridView();
            this.userScheduleDGV = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clientCityLabel = new System.Windows.Forms.Label();
            this.cityClientDGV = new System.Windows.Forms.DataGridView();
            this.clientBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cityDGV = new System.Windows.Forms.DataGridView();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aptTypesDGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userScheduleDGV)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityClientDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.totalBox);
            this.groupBox1.Controls.Add(this.monthDateTimePicker);
            this.groupBox1.Controls.Add(this.aptTypesDGV);
            this.groupBox1.Controls.Add(this.aptTypeListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 459);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment Types By Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Select Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Select Appointment Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Total Appointments By Type per Selected Month";
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(123, 433);
            this.totalBox.Name = "totalBox";
            this.totalBox.ReadOnly = true;
            this.totalBox.Size = new System.Drawing.Size(127, 20);
            this.totalBox.TabIndex = 12;
            // 
            // monthDateTimePicker
            // 
            this.monthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monthDateTimePicker.Location = new System.Drawing.Point(164, 78);
            this.monthDateTimePicker.Name = "monthDateTimePicker";
            this.monthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.monthDateTimePicker.TabIndex = 11;
            this.monthDateTimePicker.ValueChanged += new System.EventHandler(this.monthDateTimePicker_ValueChanged);
            // 
            // aptTypesDGV
            // 
            this.aptTypesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aptTypesDGV.Location = new System.Drawing.Point(8, 104);
            this.aptTypesDGV.Name = "aptTypesDGV";
            this.aptTypesDGV.Size = new System.Drawing.Size(356, 299);
            this.aptTypesDGV.TabIndex = 10;
            // 
            // aptTypeListBox
            // 
            this.aptTypeListBox.AllowDrop = true;
            this.aptTypeListBox.FormattingEnabled = true;
            this.aptTypeListBox.Items.AddRange(new object[] {
            "In Person - Office",
            "In Person - Away",
            "Phone Call",
            "Online - Web Call"});
            this.aptTypeListBox.Location = new System.Drawing.Point(6, 42);
            this.aptTypeListBox.Name = "aptTypeListBox";
            this.aptTypeListBox.Size = new System.Drawing.Size(120, 56);
            this.aptTypeListBox.TabIndex = 9;
            this.aptTypeListBox.SelectedIndexChanged += new System.EventHandler(this.aptTypeListBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.scheduleBtn);
            this.groupBox2.Controls.Add(this.scheduleLabel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.userDGV);
            this.groupBox2.Controls.Add(this.userScheduleDGV);
            this.groupBox2.Location = new System.Drawing.Point(393, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 459);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Schedules";
            // 
            // scheduleBtn
            // 
            this.scheduleBtn.Location = new System.Drawing.Point(201, 78);
            this.scheduleBtn.Name = "scheduleBtn";
            this.scheduleBtn.Size = new System.Drawing.Size(144, 48);
            this.scheduleBtn.TabIndex = 17;
            this.scheduleBtn.Text = "Populate Schedule";
            this.scheduleBtn.UseVisualStyleBackColor = true;
            this.scheduleBtn.Click += new System.EventHandler(this.scheduleBtn_Click);
            // 
            // scheduleLabel
            // 
            this.scheduleLabel.AutoSize = true;
            this.scheduleLabel.Location = new System.Drawing.Point(114, 417);
            this.scheduleLabel.Name = "scheduleLabel";
            this.scheduleLabel.Size = new System.Drawing.Size(143, 13);
            this.scheduleLabel.TabIndex = 16;
            this.scheduleLabel.Text = "{User}\'s Schedule per Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Select User";
            // 
            // userDGV
            // 
            this.userDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDGV.Location = new System.Drawing.Point(6, 42);
            this.userDGV.Name = "userDGV";
            this.userDGV.Size = new System.Drawing.Size(167, 110);
            this.userDGV.TabIndex = 16;
            // 
            // userScheduleDGV
            // 
            this.userScheduleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userScheduleDGV.Location = new System.Drawing.Point(6, 158);
            this.userScheduleDGV.Name = "userScheduleDGV";
            this.userScheduleDGV.Size = new System.Drawing.Size(363, 245);
            this.userScheduleDGV.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clientCityLabel);
            this.groupBox3.Controls.Add(this.cityClientDGV);
            this.groupBox3.Controls.Add(this.clientBtn);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cityDGV);
            this.groupBox3.Location = new System.Drawing.Point(774, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(382, 459);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Custom Report - Clients per City";
            // 
            // clientCityLabel
            // 
            this.clientCityLabel.AutoSize = true;
            this.clientCityLabel.Location = new System.Drawing.Point(159, 417);
            this.clientCityLabel.Name = "clientCityLabel";
            this.clientCityLabel.Size = new System.Drawing.Size(92, 13);
            this.clientCityLabel.TabIndex = 18;
            this.clientCityLabel.Text = "{Clients} per {City}";
            // 
            // cityClientDGV
            // 
            this.cityClientDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cityClientDGV.Location = new System.Drawing.Point(9, 158);
            this.cityClientDGV.Name = "cityClientDGV";
            this.cityClientDGV.Size = new System.Drawing.Size(363, 245);
            this.cityClientDGV.TabIndex = 18;
            // 
            // clientBtn
            // 
            this.clientBtn.Location = new System.Drawing.Point(201, 93);
            this.clientBtn.Name = "clientBtn";
            this.clientBtn.Size = new System.Drawing.Size(144, 48);
            this.clientBtn.TabIndex = 18;
            this.clientBtn.Text = "Show Clients";
            this.clientBtn.UseVisualStyleBackColor = true;
            this.clientBtn.Click += new System.EventHandler(this.clientBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Select City";
            // 
            // cityDGV
            // 
            this.cityDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cityDGV.Location = new System.Drawing.Point(6, 42);
            this.cityDGV.Name = "cityDGV";
            this.cityDGV.Size = new System.Drawing.Size(167, 110);
            this.cityDGV.TabIndex = 18;
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Location = new System.Drawing.Point(991, 500);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(165, 54);
            this.mainMenuBtn.TabIndex = 3;
            this.mainMenuBtn.Text = "Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1164, 566);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reports";
            this.Text = "Reports";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aptTypesDGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userScheduleDGV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityClientDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox aptTypeListBox;
        private System.Windows.Forms.DataGridView aptTypesDGV;
        private System.Windows.Forms.DateTimePicker monthDateTimePicker;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView userScheduleDGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView userDGV;
        private System.Windows.Forms.Label scheduleLabel;
        private System.Windows.Forms.Button scheduleBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView cityDGV;
        private System.Windows.Forms.DataGridView cityClientDGV;
        private System.Windows.Forms.Button clientBtn;
        private System.Windows.Forms.Label clientCityLabel;
    }
}