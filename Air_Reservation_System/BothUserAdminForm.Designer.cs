namespace Air_Reservation_System
{
    partial class BothUserAdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LIA_Admin = new System.Windows.Forms.Button();
            this.LIA_User = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(100, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "As User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(375, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "As Admin";
            // 
            // LIA_Admin
            // 
            this.LIA_Admin.BackgroundImage = global::Air_Reservation_System.Properties.Resources.image_support1;
            this.LIA_Admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LIA_Admin.Location = new System.Drawing.Point(262, 22);
            this.LIA_Admin.Name = "LIA_Admin";
            this.LIA_Admin.Size = new System.Drawing.Size(244, 213);
            this.LIA_Admin.TabIndex = 1;
            this.LIA_Admin.UseVisualStyleBackColor = true;
            this.LIA_Admin.Click += new System.EventHandler(this.LIA_Admin_Click);
            // 
            // LIA_User
            // 
            this.LIA_User.BackgroundImage = global::Air_Reservation_System.Properties.Resources.multy_user;
            this.LIA_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LIA_User.Location = new System.Drawing.Point(12, 22);
            this.LIA_User.Name = "LIA_User";
            this.LIA_User.Size = new System.Drawing.Size(244, 213);
            this.LIA_User.TabIndex = 0;
            this.LIA_User.Text = "User";
            this.LIA_User.UseVisualStyleBackColor = true;
            this.LIA_User.Click += new System.EventHandler(this.LIA_User_Click);
            // 
            // BothUserAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(517, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LIA_Admin);
            this.Controls.Add(this.LIA_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "BothUserAdminForm";
            this.Text = "Log in As";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LIA_User;
        private System.Windows.Forms.Button LIA_Admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}