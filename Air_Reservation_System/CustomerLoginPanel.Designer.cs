namespace Air_Reservation_System
{
    partial class CustomerLoginPanel
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
            this.USR_Login_Button = new System.Windows.Forms.Button();
            this.USR_PassBox = new System.Windows.Forms.TextBox();
            this.USR_UNBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // USR_Login_Button
            // 
            this.USR_Login_Button.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.USR_Login_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.USR_Login_Button.Location = new System.Drawing.Point(79, 197);
            this.USR_Login_Button.Name = "USR_Login_Button";
            this.USR_Login_Button.Size = new System.Drawing.Size(249, 40);
            this.USR_Login_Button.TabIndex = 9;
            this.USR_Login_Button.Text = "Sign In";
            this.USR_Login_Button.UseVisualStyleBackColor = false;
            this.USR_Login_Button.Click += new System.EventHandler(this.USR_Login_Button_Click);
            // 
            // USR_PassBox
            // 
            this.USR_PassBox.Location = new System.Drawing.Point(156, 148);
            this.USR_PassBox.Name = "USR_PassBox";
            this.USR_PassBox.Size = new System.Drawing.Size(136, 20);
            this.USR_PassBox.TabIndex = 6;
            // 
            // USR_UNBox
            // 
            this.USR_UNBox.Location = new System.Drawing.Point(156, 109);
            this.USR_UNBox.Name = "USR_UNBox";
            this.USR_UNBox.Size = new System.Drawing.Size(136, 20);
            this.USR_UNBox.TabIndex = 5;
            this.USR_UNBox.TextChanged += new System.EventHandler(this.USR_UNBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(85, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "User name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(85, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // CustomerLoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Air_Reservation_System.Properties.Resources.login_12;
            this.ClientSize = new System.Drawing.Size(378, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.USR_Login_Button);
            this.Controls.Add(this.USR_PassBox);
            this.Controls.Add(this.USR_UNBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CustomerLoginPanel";
            this.Text = "CustomerLoginPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button USR_Login_Button;
        private System.Windows.Forms.TextBox USR_PassBox;
        private System.Windows.Forms.TextBox USR_UNBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}