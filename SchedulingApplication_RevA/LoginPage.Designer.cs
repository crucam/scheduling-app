
namespace SchedulingApplication_RevA
{
    partial class LoginPage
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
            this.loginButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.loginGPBox = new System.Windows.Forms.GroupBox();
            this.passLbl = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.createUserBtn = new System.Windows.Forms.Button();
            this.loginGPBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loginButton.Location = new System.Drawing.Point(102, 251);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(98, 46);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exitButton.Location = new System.Drawing.Point(367, 251);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(98, 46);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // loginGPBox
            // 
            this.loginGPBox.Controls.Add(this.passLbl);
            this.loginGPBox.Controls.Add(this.userNameLbl);
            this.loginGPBox.Controls.Add(this.passBox);
            this.loginGPBox.Controls.Add(this.userBox);
            this.loginGPBox.Controls.Add(this.exitButton);
            this.loginGPBox.Controls.Add(this.loginButton);
            this.loginGPBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.loginGPBox.Location = new System.Drawing.Point(46, 52);
            this.loginGPBox.Name = "loginGPBox";
            this.loginGPBox.Size = new System.Drawing.Size(577, 347);
            this.loginGPBox.TabIndex = 2;
            this.loginGPBox.TabStop = false;
            this.loginGPBox.Text = " Login";
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passLbl.Location = new System.Drawing.Point(103, 152);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(69, 17);
            this.passLbl.TabIndex = 5;
            this.passLbl.Text = "Password";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userNameLbl.Location = new System.Drawing.Point(103, 86);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(73, 17);
            this.userNameLbl.TabIndex = 4;
            this.userNameLbl.Text = "Username";
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passBox.Location = new System.Drawing.Point(102, 175);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(363, 26);
            this.passBox.TabIndex = 3;
            // 
            // userBox
            // 
            this.userBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.userBox.Location = new System.Drawing.Point(102, 113);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(363, 26);
            this.userBox.TabIndex = 2;
            // 
            // createUserBtn
            // 
            this.createUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserBtn.Location = new System.Drawing.Point(525, 410);
            this.createUserBtn.Name = "createUserBtn";
            this.createUserBtn.Size = new System.Drawing.Size(98, 28);
            this.createUserBtn.TabIndex = 6;
            this.createUserBtn.Text = "Create User";
            this.createUserBtn.UseVisualStyleBackColor = true;
            this.createUserBtn.Click += new System.EventHandler(this.createUserBtn_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.createUserBtn);
            this.Controls.Add(this.loginGPBox);
            this.Name = "LoginPage";
            this.Text = "CC Scheduler";
            this.loginGPBox.ResumeLayout(false);
            this.loginGPBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox loginGPBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Button createUserBtn;
    }
}

