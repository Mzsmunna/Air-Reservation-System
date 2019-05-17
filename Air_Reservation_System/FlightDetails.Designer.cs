namespace Air_Reservation_System
{
    partial class Flight_Details
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
            this.FlightDetailsGridView = new System.Windows.Forms.DataGridView();
            this.FlightDetails_Next = new System.Windows.Forms.Button();
            this.Flight_Details_Back = new System.Windows.Forms.Button();
            this.FDB_Search_Button = new System.Windows.Forms.Button();
            this.Flight_Booking_SearchBox = new System.Windows.Forms.TextBox();
            this.Refresh_Display = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FlightDetailsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FlightDetailsGridView
            // 
            this.FlightDetailsGridView.AllowUserToAddRows = false;
            this.FlightDetailsGridView.AllowUserToDeleteRows = false;
            this.FlightDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightDetailsGridView.Location = new System.Drawing.Point(12, 27);
            this.FlightDetailsGridView.Name = "FlightDetailsGridView";
            this.FlightDetailsGridView.ReadOnly = true;
            this.FlightDetailsGridView.Size = new System.Drawing.Size(1040, 270);
            this.FlightDetailsGridView.TabIndex = 0;
            this.FlightDetailsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FlightDetailsGridView_CellClick);
            // 
            // FlightDetails_Next
            // 
            this.FlightDetails_Next.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FlightDetails_Next.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightDetails_Next.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FlightDetails_Next.Location = new System.Drawing.Point(967, 303);
            this.FlightDetails_Next.Name = "FlightDetails_Next";
            this.FlightDetails_Next.Size = new System.Drawing.Size(85, 28);
            this.FlightDetails_Next.TabIndex = 1;
            this.FlightDetails_Next.Text = "Next";
            this.FlightDetails_Next.UseVisualStyleBackColor = false;
            this.FlightDetails_Next.Click += new System.EventHandler(this.FlightDetails_Next_Click);
            // 
            // Flight_Details_Back
            // 
            this.Flight_Details_Back.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Flight_Details_Back.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flight_Details_Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Flight_Details_Back.Location = new System.Drawing.Point(12, 303);
            this.Flight_Details_Back.Name = "Flight_Details_Back";
            this.Flight_Details_Back.Size = new System.Drawing.Size(98, 28);
            this.Flight_Details_Back.TabIndex = 2;
            this.Flight_Details_Back.Text = "Back";
            this.Flight_Details_Back.UseVisualStyleBackColor = false;
            this.Flight_Details_Back.Click += new System.EventHandler(this.Flight_Details_Back_Click);
            // 
            // FDB_Search_Button
            // 
            this.FDB_Search_Button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FDB_Search_Button.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FDB_Search_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FDB_Search_Button.Location = new System.Drawing.Point(632, 2);
            this.FDB_Search_Button.Name = "FDB_Search_Button";
            this.FDB_Search_Button.Size = new System.Drawing.Size(75, 21);
            this.FDB_Search_Button.TabIndex = 3;
            this.FDB_Search_Button.Text = "Search";
            this.FDB_Search_Button.UseVisualStyleBackColor = false;
            this.FDB_Search_Button.Click += new System.EventHandler(this.FDB_Search_Button_Click);
            // 
            // Flight_Booking_SearchBox
            // 
            this.Flight_Booking_SearchBox.Location = new System.Drawing.Point(399, 3);
            this.Flight_Booking_SearchBox.Name = "Flight_Booking_SearchBox";
            this.Flight_Booking_SearchBox.Size = new System.Drawing.Size(227, 20);
            this.Flight_Booking_SearchBox.TabIndex = 4;
            // 
            // Refresh_Display
            // 
            this.Refresh_Display.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Refresh_Display.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_Display.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Refresh_Display.Location = new System.Drawing.Point(497, 303);
            this.Refresh_Display.Name = "Refresh_Display";
            this.Refresh_Display.Size = new System.Drawing.Size(98, 28);
            this.Refresh_Display.TabIndex = 5;
            this.Refresh_Display.Text = "Refresh";
            this.Refresh_Display.UseVisualStyleBackColor = false;
            this.Refresh_Display.Click += new System.EventHandler(this.Refresh_Display_Click);
            // 
            // Flight_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Air_Reservation_System.Properties.Resources.airplane_flight_sunset;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1069, 338);
            this.Controls.Add(this.Refresh_Display);
            this.Controls.Add(this.Flight_Booking_SearchBox);
            this.Controls.Add(this.FDB_Search_Button);
            this.Controls.Add(this.Flight_Details_Back);
            this.Controls.Add(this.FlightDetails_Next);
            this.Controls.Add(this.FlightDetailsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Flight_Details";
            this.Text = "Fligh Details";
            this.Load += new System.EventHandler(this.Flight_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlightDetailsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FlightDetailsGridView;
        private System.Windows.Forms.Button FlightDetails_Next;
        private System.Windows.Forms.Button Flight_Details_Back;
        private System.Windows.Forms.Button FDB_Search_Button;
        private System.Windows.Forms.TextBox Flight_Booking_SearchBox;
        private System.Windows.Forms.Button Refresh_Display;
    }
}

