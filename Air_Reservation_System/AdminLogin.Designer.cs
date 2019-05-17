namespace Air_Reservation_System
{
    partial class AdminLogin
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
            this.AL_UNBox = new System.Windows.Forms.TextBox();
            this.AL_PassBox = new System.Windows.Forms.TextBox();
            this.AL_AUN = new System.Windows.Forms.Label();
            this.AL_PWD = new System.Windows.Forms.Label();
            this.AL_Login_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AL_UNBox
            // 
            this.AL_UNBox.Location = new System.Drawing.Point(111, 88);
            this.AL_UNBox.Name = "AL_UNBox";
            this.AL_UNBox.Size = new System.Drawing.Size(172, 20);
            this.AL_UNBox.TabIndex = 0;
            // 
            // AL_PassBox
            // 
            this.AL_PassBox.Location = new System.Drawing.Point(111, 138);
            this.AL_PassBox.Name = "AL_PassBox";
            this.AL_PassBox.Size = new System.Drawing.Size(172, 20);
            this.AL_PassBox.TabIndex = 1;
            // 
            // AL_AUN
            // 
            this.AL_AUN.AutoSize = true;
            this.AL_AUN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AL_AUN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AL_AUN.Location = new System.Drawing.Point(12, 91);
            this.AL_AUN.Name = "AL_AUN";
            this.AL_AUN.Size = new System.Drawing.Size(92, 13);
            this.AL_AUN.TabIndex = 2;
            this.AL_AUN.Text = "Admin User Name";
            // 
            // AL_PWD
            // 
            this.AL_PWD.AutoSize = true;
            this.AL_PWD.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AL_PWD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AL_PWD.Location = new System.Drawing.Point(32, 145);
            this.AL_PWD.Name = "AL_PWD";
            this.AL_PWD.Size = new System.Drawing.Size(53, 13);
            this.AL_PWD.TabIndex = 3;
            this.AL_PWD.Text = "Password";
            // 
            // AL_Login_Button
            // 
            this.AL_Login_Button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AL_Login_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AL_Login_Button.Location = new System.Drawing.Point(101, 175);
            this.AL_Login_Button.Name = "AL_Login_Button";
            this.AL_Login_Button.Size = new System.Drawing.Size(63, 32);
            this.AL_Login_Button.TabIndex = 4;
            this.AL_Login_Button.Text = "Log In";
            this.AL_Login_Button.UseVisualStyleBackColor = false;
            this.AL_Login_Button.Click += new System.EventHandler(this.AL_Login_Button_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Air_Reservation_System.Properties.Resources.admin_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 262);
            this.Controls.Add(this.AL_Login_Button);
            this.Controls.Add(this.AL_PWD);
            this.Controls.Add(this.AL_AUN);
            this.Controls.Add(this.AL_PassBox);
            this.Controls.Add(this.AL_UNBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AdminLogin";
            this.Text = "Admin Login";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AL_UNBox;
        private System.Windows.Forms.TextBox AL_PassBox;
        private System.Windows.Forms.Label AL_AUN;
        private System.Windows.Forms.Label AL_PWD;
        private System.Windows.Forms.Button AL_Login_Button;
    }
}