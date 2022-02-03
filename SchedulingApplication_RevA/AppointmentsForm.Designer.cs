
namespace SchedulingApplication_RevA
{
    partial class AppointmentsForm
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
            this.delBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.modAptBtn = new System.Windows.Forms.Button();
            this.addAptBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.weekDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.monthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.aptDGV = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.aptWeekDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aptDGV)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aptWeekDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delBtn);
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.modAptBtn);
            this.groupBox1.Controls.Add(this.addAptBtn);
            this.groupBox1.Location = new System.Drawing.Point(25, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 377);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CC Scheduler";
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(6, 188);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(165, 54);
            this.delBtn.TabIndex = 3;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(6, 298);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(165, 54);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Main Menu";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // modAptBtn
            // 
            this.modAptBtn.Location = new System.Drawing.Point(6, 128);
            this.modAptBtn.Name = "modAptBtn";
            this.modAptBtn.Size = new System.Drawing.Size(165, 54);
            this.modAptBtn.TabIndex = 1;
            this.modAptBtn.Text = "Modify";
            this.modAptBtn.UseVisualStyleBackColor = true;
            this.modAptBtn.Click += new System.EventHandler(this.modAptBtn_Click);
            // 
            // addAptBtn
            // 
            this.addAptBtn.Location = new System.Drawing.Point(6, 68);
            this.addAptBtn.Name = "addAptBtn";
            this.addAptBtn.Size = new System.Drawing.Size(165, 54);
            this.addAptBtn.TabIndex = 0;
            this.addAptBtn.Text = "Create Appointment";
            this.addAptBtn.UseVisualStyleBackColor = true;
            this.addAptBtn.Click += new System.EventHandler(this.addAptBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.weekDateTimePicker);
            this.groupBox2.Controls.Add(this.monthDateTimePicker);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(221, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(830, 377);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointments";
            // 
            // weekDateTimePicker
            // 
            this.weekDateTimePicker.Location = new System.Drawing.Point(202, 351);
            this.weekDateTimePicker.Name = "weekDateTimePicker";
            this.weekDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.weekDateTimePicker.TabIndex = 5;
            this.weekDateTimePicker.ValueChanged += new System.EventHandler(this.weekDateTimePicker_ValueChanged);
            // 
            // monthDateTimePicker
            // 
            this.monthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monthDateTimePicker.Location = new System.Drawing.Point(604, 351);
            this.monthDateTimePicker.Name = "monthDateTimePicker";
            this.monthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.monthDateTimePicker.TabIndex = 4;
            this.monthDateTimePicker.ValueChanged += new System.EventHandler(this.monthDateTimePicker_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.aptDGV);
            this.groupBox4.Location = new System.Drawing.Point(418, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(397, 319);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "This Month";
            // 
            // aptDGV
            // 
            this.aptDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aptDGV.Location = new System.Drawing.Point(6, 29);
            this.aptDGV.Name = "aptDGV";
            this.aptDGV.Size = new System.Drawing.Size(380, 284);
            this.aptDGV.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.aptWeekDGV);
            this.groupBox3.Location = new System.Drawing.Point(16, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 319);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "This Week";
            // 
            // aptWeekDGV
            // 
            this.aptWeekDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aptWeekDGV.Location = new System.Drawing.Point(6, 29);
            this.aptWeekDGV.Name = "aptWeekDGV";
            this.aptWeekDGV.Size = new System.Drawing.Size(380, 284);
            this.aptWeekDGV.TabIndex = 1;
            // 
            // AppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1063, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AppointmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppointmentsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aptDGV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aptWeekDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button modAptBtn;
        private System.Windows.Forms.Button addAptBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView aptDGV;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView aptWeekDGV;
        private System.Windows.Forms.DateTimePicker weekDateTimePicker;
        private System.Windows.Forms.DateTimePicker monthDateTimePicker;
        private System.Windows.Forms.Button delBtn;
    }
}