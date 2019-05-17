namespace Air_Reservation_System
{
    partial class AdminPanel
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
            this.AP_Add_Flight = new System.Windows.Forms.Button();
            this.AP_UpdateF = new System.Windows.Forms.Button();
            this.AP_CancelReservation = new System.Windows.Forms.Button();
            this.AP_Cancel_FS = new System.Windows.Forms.Button();
            this.APSearchBox = new System.Windows.Forms.TextBox();
            this.AP_Gridview_Display = new System.Windows.Forms.DataGridView();
            this.AP_Logout = new System.Windows.Forms.Button();
            this.AP_Admin_Table = new System.Windows.Forms.Button();
            this.AP_Seat_Booking = new System.Windows.Forms.Button();
            this.AP_Search = new System.Windows.Forms.Button();
            this.AP_Customer_Table = new System.Windows.Forms.Button();
            this.AP_Flight_Details_Table = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AP_Gridview_Display)).BeginInit();
            this.SuspendLayout();
            // 
            // AP_Add_Flight
            // 
            this.AP_Add_Flight.BackColor = System.Drawing.Color.Maroon;
            this.AP_Add_Flight.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AP_Add_Flight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AP_Add_Flight.Location = new System.Drawing.Point(12, 56);
            this.AP_Add_Flight.Name = "AP_Add_Flight";
            this.AP_Add_Flight.Size = new System.Drawing.Size(195, 44);
            this.AP_Add_Flight.TabIndex = 0;
            this.AP_Add_Flight.Text = "Add Flight";
            this.AP_Add_Flight.UseVisualStyleBackColor = false;
            this.AP_Add_Flight.Click += new System.EventHandler(this.AP_Add_Flight_Click);
            // 
            // AP_UpdateF
            // 
            this.AP_UpdateF.BackColor = System.Drawing.Color.DarkRed;
            this.AP_UpdateF.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AP_UpdateF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AP_UpdateF.Location = new System.Drawing.Point(12, 120);
            this.AP_UpdateF.Name = "AP_UpdateF";
            this.AP_UpdateF.Size = new System.Drawing.Size(195, 44);
            this.AP_UpdateF.TabIndex = 1;
            this.AP_UpdateF.Text = "Update Flight";
            this.AP_UpdateF.UseVisualStyleBackColor = false;
            this.AP_UpdateF.Click += new System.EventHandler(this.AP_UpdateF_Click);
            // 
            // AP_CancelReservation
            // 
            this.AP_CancelReservation.BackColor = System.Drawing.Color.DarkRed;
            this.AP_CancelReservation.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AP_CancelReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AP_CancelReservation.Location = new System.Drawing.Point(12, 186);
            this.AP_CancelReservation.Name = "AP_CancelReservation";
            this.AP_CancelReservation.Size = new System.Drawing.Size(195, 44);
            this.AP_CancelReservation.TabIndex = 2;
            this.AP_CancelReservation.Text = "Cancel Reservation";
            this.AP_CancelReservation.UseVisualStyleBackColor = false;
            this.AP_CancelReservation.Click += new System.EventHandler(this.AP_CancelReservation_Click);
            // 
            // AP_Cancel_FS
            // 
            this.AP_Cancel_FS.BackColor = System.Drawing.SystemColors.ControlText;
            this.AP_Cancel_FS.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AP_Cancel_FS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AP_Cancel_FS.Location = new System.Drawing.Point(12, 252);
            this.AP_Cancel_FS.Name = "AP_Cancel_FS";
            this.AP_Cancel_FS.Size = new System.Drawing.Size(195, 44);
            this.AP_Cancel_FS.TabIndex = 3;
            this.AP_Cancel_FS.Text = "Cancel Flight Schedule";
            this.AP_Cancel_FS.UseVisualStyleBackColor = false;
            this.AP_Cancel_FS.Click += new System.EventHandler(this.AP_Cancel_FS_Click);
            // 
            // APSearchBox
            // 
            this.APSearchBox.Location = new System.Drawing.Point(18, 10);
            this.APSearchBox.Name = "APSearchBox";
            this.APSearchBox.Size = new System.Drawing.Size(125, 20);
            this.APSearchBox.TabIndex = 4;
            // 
            // AP_Gridview_Display
            // 
            this.AP_Gridview_Display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AP_Gridview_Display.Location = new System.Drawing.Point(213, 5);
            this.AP_Gridview_Display.Name = "AP_Gridview_Display";
            this.AP_Gridview_Display.Size = new System.Drawing.Size(1026, 298);
            this.AP_Gridview_Display.TabIndex = 6;
            this.AP_Gridview_Display.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AP_Gridview_Display_CellClick);
            // 
            // AP_Logout
            // 
            this.AP_Logout.BackColor = System.Drawing.Color.Black;
            this.AP_Logout.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AP_Logout.ForeColor = System.Drawing.Color.Red;
            this.AP_Logout.Location = new System.Drawing.Point(1245, 5);
            this.AP_Logout.Name = "AP_Logout";
            this.AP_Logout.Size = new System.Drawing.Size(71, 27);
            this.AP_Logout.TabIndex = 7;
            this.AP_Logout.Text = "logout";
            this.AP_Logout.UseVisualStyleBackColor = false;
            this.AP_Logout.Click += new System.EventHandler(this.AP_Logout_Click);
            // 
            // AP_Admin_Table
            // 
            this.AP_Admin_Table.BackColor = System.Drawing.Color.Black;
            this.AP_Admin_Table.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AP_Admin_Table.ForeColor = System.Drawing.Color.Lime;
            this.AP_Admin_Table.Location = new System.Drawing.Point(1245, 58);
            this.AP_Admin_Table.Name = "AP_Admin_Table";
            this.AP_Admin_Table.Size = new System.Drawing.Size(71, 41);
            this.AP_Admin_Table.TabIndex = 8;
            this.AP_Admin_Table.Text = "Admin Table";
            this.AP_Admin_Table.UseVisualStyleBackColor = false;
            this.AP_Admin_Table.Click += new System.EventHandler(this.AP_Admin_Table_Click);
            // 
            // AP_Seat_Booking
            // 
            this.AP_Seat_Booking.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AP_Seat_Booking.ForeColor = System.Drawing.Color.Lime;
            this.AP_Seat_Booking.Location = new System.Drawing.Point(1245, 262);
            this.AP_Seat_Booking.Name = "AP_Seat_Booking";
            this.AP_Seat_Booking.Size = new System.Drawing.Size(71, 41);
            this.AP_Seat_Booking.TabIndex = 9;
            this.AP_Seat_Booking.Text = "Seat Booking Table";
            this.AP_Seat_Booking.UseVisualStyleBackColor = false;
            this.AP_Seat_Booking.Click += new System.EventHandler(this.AP_Seat_Booking_Click);
            // 
            // AP_Search
            // 
            this.AP_Search.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AP_Search.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AP_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AP_Search.Location = new System.Drawing.Point(149, 5);
            this.AP_Search.Name = "AP_Search";
            this.AP_Search.Size = new System.Drawing.Size(58, 27);
            this.AP_Search.TabIndex = 10;
            this.AP_Search.Text = "Search";
            this.AP_Search.UseVisualStyleBackColor = false;
            this.AP_Search.Click += new System.EventHandler(this.AP_Search_Click);
            // 
            // AP_Customer_Table
            // 
            this.AP_Customer_Table.BackColor = System.Drawing.SystemColors.ControlText;
            this.AP_Customer_Table.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AP_Customer_Table.ForeColor = System.Drawing.Color.Lime;
            this.AP_Customer_Table.Location = new System.Drawing.Point(1245, 123);
            this.AP_Customer_Table.Name = "AP_Customer_Table";
            this.AP_Customer_Table.Size = new System.Drawing.Size(71, 41);
            this.AP_Customer_Table.TabIndex = 11;
            this.AP_Customer_Table.Text = "Customer Table";
            this.AP_Customer_Table.UseVisualStyleBackColor = false;
            this.AP_Customer_Table.Click += new System.EventHandler(this.AP_Customer_Table_Click);
            // 
            // AP_Flight_Details_Table
            // 
            this.AP_Flight_Details_Table.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AP_Flight_Details_Table.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AP_Flight_Details_Table.ForeColor = System.Drawing.Color.Lime;
            this.AP_Flight_Details_Table.Location = new System.Drawing.Point(1245, 189);
            this.AP_Flight_Details_Table.Name = "AP_Flight_Details_Table";
            this.AP_Flight_Details_Table.Size = new System.Drawing.Size(71, 41);
            this.AP_Flight_Details_Table.TabIndex = 12;
            this.AP_Flight_Details_Table.Text = "Flight Details Table";
            this.AP_Flight_Details_Table.UseVisualStyleBackColor = false;
            this.AP_Flight_Details_Table.Click += new System.EventHandler(this.AP_Flight_Details_Table_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Air_Reservation_System.Properties.Resources.airplane_flight_sunset;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1318, 315);
            this.Controls.Add(this.AP_Flight_Details_Table);
            this.Controls.Add(this.AP_Customer_Table);
            this.Controls.Add(this.AP_Search);
            this.Controls.Add(this.AP_Seat_Booking);
            this.Controls.Add(this.AP_Admin_Table);
            this.Controls.Add(this.AP_Logout);
            this.Controls.Add(this.AP_Gridview_Display);
            this.Controls.Add(this.APSearchBox);
            this.Controls.Add(this.AP_Cancel_FS);
            this.Controls.Add(this.AP_CancelReservation);
            this.Controls.Add(this.AP_UpdateF);
            this.Controls.Add(this.AP_Add_Flight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AdminPanel";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AP_Gridview_Display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AP_Add_Flight;
        private System.Windows.Forms.Button AP_UpdateF;
        private System.Windows.Forms.Button AP_CancelReservation;
        private System.Windows.Forms.Button AP_Cancel_FS;
        private System.Windows.Forms.TextBox APSearchBox;
        private System.Windows.Forms.DataGridView AP_Gridview_Display;
        private System.Windows.Forms.Button AP_Logout;
        private System.Windows.Forms.Button AP_Admin_Table;
        private System.Windows.Forms.Button AP_Seat_Booking;
        private System.Windows.Forms.Button AP_Search;
        private System.Windows.Forms.Button AP_Customer_Table;
        private System.Windows.Forms.Button AP_Flight_Details_Table;
    }
}