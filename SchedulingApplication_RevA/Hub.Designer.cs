
namespace SchedulingApplication_RevA
{
    partial class Hub
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
            this.reportsBtn = new System.Windows.Forms.Button();
            this.aptBtn = new System.Windows.Forms.Button();
            this.customerRecordBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.apptDGV = new System.Windows.Forms.DataGridView();
            this.signOutBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apptDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportsBtn);
            this.groupBox1.Controls.Add(this.aptBtn);
            this.groupBox1.Controls.Add(this.customerRecordBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CC Scheduling";
            // 
            // reportsBtn
            // 
            this.reportsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.reportsBtn.Location = new System.Drawing.Point(531, 54);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(224, 56);
            this.reportsBtn.TabIndex = 2;
            this.reportsBtn.Text = "Reports";
            this.reportsBtn.UseVisualStyleBackColor = true;
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
            // 
            // aptBtn
            // 
            this.aptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.aptBtn.Location = new System.Drawing.Point(273, 54);
            this.aptBtn.Name = "aptBtn";
            this.aptBtn.Size = new System.Drawing.Size(224, 56);
            this.aptBtn.TabIndex = 1;
            this.aptBtn.Text = "Appointments";
            this.aptBtn.UseVisualStyleBackColor = true;
            this.aptBtn.Click += new System.EventHandler(this.aptBtn_Click);
            // 
            // customerRecordBtn
            // 
            this.customerRecordBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.customerRecordBtn.Location = new System.Drawing.Point(20, 54);
            this.customerRecordBtn.Name = "customerRecordBtn";
            this.customerRecordBtn.Size = new System.Drawing.Size(224, 56);
            this.customerRecordBtn.TabIndex = 0;
            this.customerRecordBtn.Text = "Customer Records";
            this.customerRecordBtn.UseVisualStyleBackColor = true;
            this.customerRecordBtn.Click += new System.EventHandler(this.customerRecordBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.apptDGV);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox2.Location = new System.Drawing.Point(12, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 242);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "All Appointments for the Day";
            // 
            // apptDGV
            // 
            this.apptDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apptDGV.Location = new System.Drawing.Point(20, 50);
            this.apptDGV.Name = "apptDGV";
            this.apptDGV.Size = new System.Drawing.Size(735, 165);
            this.apptDGV.TabIndex = 0;
            // 
            // signOutBtn
            // 
            this.signOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.signOutBtn.Location = new System.Drawing.Point(613, 402);
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.Size = new System.Drawing.Size(175, 41);
            this.signOutBtn.TabIndex = 3;
            this.signOutBtn.Text = "Sign Out";
            this.signOutBtn.UseVisualStyleBackColor = true;
            this.signOutBtn.Click += new System.EventHandler(this.signOutBtn_Click);
            // 
            // Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signOutBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Hub";
            this.Text = "Hub ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.apptDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        //test
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView apptDGV;
        private System.Windows.Forms.Button aptBtn;
        private System.Windows.Forms.Button customerRecordBtn;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Button signOutBtn;
    }
}