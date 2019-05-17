namespace Air_Reservation_System
{
    partial class AIRRMainFrame
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
            this.Main_About = new System.Windows.Forms.Button();
            this.Main_SeeAvailFlight = new System.Windows.Forms.Button();
            this.MainFLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Main_About
            // 
            this.Main_About.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_About.Location = new System.Drawing.Point(13, 12);
            this.Main_About.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Main_About.Name = "Main_About";
            this.Main_About.Size = new System.Drawing.Size(145, 29);
            this.Main_About.TabIndex = 1;
            this.Main_About.Text = "About US";
            this.Main_About.UseVisualStyleBackColor = true;
            this.Main_About.Click += new System.EventHandler(this.Main_About_Click);
            // 
            // Main_SeeAvailFlight
            // 
            this.Main_SeeAvailFlight.BackColor = System.Drawing.SystemColors.Control;
            this.Main_SeeAvailFlight.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_SeeAvailFlight.Location = new System.Drawing.Point(166, 12);
            this.Main_SeeAvailFlight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Main_SeeAvailFlight.Name = "Main_SeeAvailFlight";
            this.Main_SeeAvailFlight.Size = new System.Drawing.Size(567, 37);
            this.Main_SeeAvailFlight.TabIndex = 2;
            this.Main_SeeAvailFlight.Text = "See Available Flight";
            this.Main_SeeAvailFlight.UseVisualStyleBackColor = false;
            this.Main_SeeAvailFlight.Click += new System.EventHandler(this.Main_SeeAvailFlight_Click);
            // 
            // MainFLogin
            // 
            this.MainFLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MainFLogin.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainFLogin.Location = new System.Drawing.Point(741, 12);
            this.MainFLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainFLogin.Name = "MainFLogin";
            this.MainFLogin.Size = new System.Drawing.Size(154, 29);
            this.MainFLogin.TabIndex = 4;
            this.MainFLogin.Text = "Login";
            this.MainFLogin.UseVisualStyleBackColor = false;
            this.MainFLogin.Click += new System.EventHandler(this.MainFLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(614, 379);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "AIRLINE RESERVATION SYSTEM";
            // 
            // AIRRMainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Air_Reservation_System.Properties.Resources.airplane_flight_sunset;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(908, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainFLogin);
            this.Controls.Add(this.Main_SeeAvailFlight);
            this.Controls.Add(this.Main_About);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AIRRMainFrame";
            this.Text = "AIRRMainFrame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AIRRMainFrame_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Main_About;
        private System.Windows.Forms.Button Main_SeeAvailFlight;
        private System.Windows.Forms.Button MainFLogin;
        private System.Windows.Forms.Label label1;
    }
}