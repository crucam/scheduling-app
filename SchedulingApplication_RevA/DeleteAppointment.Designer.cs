
namespace SchedulingApplication_RevA
{
    partial class DeleteAppointment
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.delAptBtn = new System.Windows.Forms.Button();
            this.aptDGV = new System.Windows.Forms.DataGridView();
            this.monthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aptDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.delAptBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 201);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CC Scheduler";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(6, 131);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(165, 54);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // delAptBtn
            // 
            this.delAptBtn.Location = new System.Drawing.Point(6, 49);
            this.delAptBtn.Name = "delAptBtn";
            this.delAptBtn.Size = new System.Drawing.Size(165, 54);
            this.delAptBtn.TabIndex = 0;
            this.delAptBtn.Text = "Delete Appointment";
            this.delAptBtn.UseVisualStyleBackColor = true;
            this.delAptBtn.Click += new System.EventHandler(this.delAptBtn_Click);
            // 
            // aptDGV
            // 
            this.aptDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aptDGV.Location = new System.Drawing.Point(206, 41);
            this.aptDGV.Name = "aptDGV";
            this.aptDGV.Size = new System.Drawing.Size(583, 397);
            this.aptDGV.TabIndex = 3;
            this.aptDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.aptDGV_CellContentClick);
            // 
            // monthDateTimePicker
            // 
            this.monthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monthDateTimePicker.Location = new System.Drawing.Point(589, 12);
            this.monthDateTimePicker.Name = "monthDateTimePicker";
            this.monthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.monthDateTimePicker.TabIndex = 5;
            this.monthDateTimePicker.ValueChanged += new System.EventHandler(this.monthDateTimePicker_ValueChanged);
            // 
            // DeleteAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.monthDateTimePicker);
            this.Controls.Add(this.aptDGV);
            this.Controls.Add(this.groupBox1);
            this.Name = "DeleteAppointment";
            this.Text = "DeleteAppointment";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aptDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button delAptBtn;
        private System.Windows.Forms.DataGridView aptDGV;
        private System.Windows.Forms.DateTimePicker monthDateTimePicker;
    }
}