
namespace SchedulingApplication_RevA
{
    partial class ModifyAptData
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
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.aptTypeListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.custNameBox = new System.Windows.Forms.TextBox();
            this.allApts = new System.Windows.Forms.DataGridView();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveAptBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allApts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aptTimeBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.aptTypeListBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 367);
            this.groupBox1.TabIndex = 1;
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
            this.aptTimeBox.Location = new System.Drawing.Point(13, 334);
            this.aptTimeBox.Name = "aptTimeBox";
            this.aptTimeBox.Size = new System.Drawing.Size(142, 21);
            this.aptTimeBox.TabIndex = 13;
            this.aptTimeBox.SelectedIndexChanged += new System.EventHandler(this.aptTimeBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Appointments";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 133);
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
            this.aptTypeListBox.Location = new System.Drawing.Point(10, 38);
            this.aptTypeListBox.Name = "aptTypeListBox";
            this.aptTypeListBox.Size = new System.Drawing.Size(120, 56);
            this.aptTypeListBox.TabIndex = 8;
            this.aptTypeListBox.SelectedIndexChanged += new System.EventHandler(this.aptTypeListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Set Appointment Date / Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Appointment Type";
            // 
            // custNameBox
            // 
            this.custNameBox.Location = new System.Drawing.Point(12, 403);
            this.custNameBox.Name = "custNameBox";
            this.custNameBox.Size = new System.Drawing.Size(264, 20);
            this.custNameBox.TabIndex = 2;
            // 
            // allApts
            // 
            this.allApts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allApts.Location = new System.Drawing.Point(293, 34);
            this.allApts.Name = "allApts";
            this.allApts.Size = new System.Drawing.Size(680, 342);
            this.allApts.TabIndex = 10;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(873, 386);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 53);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveAptBtn
            // 
            this.saveAptBtn.Location = new System.Drawing.Point(753, 386);
            this.saveAptBtn.Name = "saveAptBtn";
            this.saveAptBtn.Size = new System.Drawing.Size(100, 53);
            this.saveAptBtn.TabIndex = 12;
            this.saveAptBtn.Text = "Save";
            this.saveAptBtn.UseVisualStyleBackColor = true;
            this.saveAptBtn.Click += new System.EventHandler(this.saveAptBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Original Appoointment:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(580, 406);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 14;
            this.dateLabel.Text = "Date";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(431, 406);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(33, 13);
            this.clientLabel.TabIndex = 15;
            this.clientLabel.Text = "Client";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(662, 406);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(30, 13);
            this.timeLabel.TabIndex = 16;
            this.timeLabel.Text = "Time";
            // 
            // ModifyAptData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(985, 450);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveAptBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.allApts);
            this.Controls.Add(this.custNameBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModifyAptData";
            this.Text = "ModifyAptData";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allApts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox aptTimeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox aptTypeListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox custNameBox;
        private System.Windows.Forms.DataGridView allApts;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveAptBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label timeLabel;
    }
}