
namespace SchedulingApplication_RevA
{
    partial class CreateAppointment
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
            this.aptTimeBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.aptTypeListBox = new System.Windows.Forms.ListBox();
            this.clientDGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createAptBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.allApts = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allApts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aptTimeBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.aptTypeListBox);
            this.groupBox1.Controls.Add(this.clientDGV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CC Scheduler";
            // 
            // aptTimeBox
            // 
            this.aptTimeBox.FormattingEnabled = true;
            this.aptTimeBox.Items.AddRange(new object[] {
            "06:00",
            "06:15",
            "06:30",
            "06:45",
            "07:00",
            "07:15",
            "07:30",
            "07:45",
            "08:00",
            "08:15",
            "08:30",
            "08:45",
            "09:00",
            "09:15",
            "09:30",
            "09:45",
            "10:00",
            "10:15",
            "10:30",
            "10:45",
            "11:00",
            "11:15",
            "11:30",
            "11:45",
            "12:00",
            "12:15",
            "12:30",
            "12:45",
            "13:00",
            "13:15",
            "13:30",
            "13:45",
            "14:00",
            "14:15",
            "14:30",
            "14:45",
            "15:00",
            "15:15",
            "15:30",
            "15:45",
            "16:00",
            "16:15",
            "16:30",
            "16:45",
            "17:00",
            "17:15",
            "17:30",
            "17:45",
            "18:00",
            "18:15",
            "18:30",
            "18:45",
            "19:00",
            "19:15",
            "19:30",
            "19:45",
            "19:45",
            "20:00"});
            this.aptTimeBox.Location = new System.Drawing.Point(161, 328);
            this.aptTimeBox.Name = "aptTimeBox";
            this.aptTimeBox.Size = new System.Drawing.Size(142, 21);
            this.aptTimeBox.TabIndex = 13;
            this.aptTimeBox.SelectedIndexChanged += new System.EventHandler(this.aptTimeBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Choose Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Appointments";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(160, 127);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
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
            this.aptTypeListBox.Location = new System.Drawing.Point(158, 32);
            this.aptTypeListBox.Name = "aptTypeListBox";
            this.aptTypeListBox.Size = new System.Drawing.Size(120, 56);
            this.aptTypeListBox.TabIndex = 8;
            this.aptTypeListBox.SelectedIndexChanged += new System.EventHandler(this.aptTypeListBox_SelectedIndexChanged);
            // 
            // clientDGV
            // 
            this.clientDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDGV.Location = new System.Drawing.Point(6, 32);
            this.clientDGV.Name = "clientDGV";
            this.clientDGV.Size = new System.Drawing.Size(146, 329);
            this.clientDGV.TabIndex = 0;
            this.clientDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientDGV_CellContentClick_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Set Appointment Date / Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Appointment Type";
            // 
            // createAptBtn
            // 
            this.createAptBtn.Location = new System.Drawing.Point(311, 385);
            this.createAptBtn.Name = "createAptBtn";
            this.createAptBtn.Size = new System.Drawing.Size(100, 53);
            this.createAptBtn.TabIndex = 7;
            this.createAptBtn.Text = "Create";
            this.createAptBtn.UseVisualStyleBackColor = true;
            this.createAptBtn.Click += new System.EventHandler(this.createAptBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(943, 385);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 53);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // allApts
            // 
            this.allApts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allApts.Location = new System.Drawing.Point(430, 37);
            this.allApts.Name = "allApts";
            this.allApts.Size = new System.Drawing.Size(680, 342);
            this.allApts.TabIndex = 9;
            // 
            // CreateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1122, 450);
            this.Controls.Add(this.allApts);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.createAptBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAppointment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allApts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView clientDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createAptBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ListBox aptTypeListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView allApts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox aptTimeBox;
    }
}