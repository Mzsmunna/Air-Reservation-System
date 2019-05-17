namespace Air_Reservation_System
{
    partial class Seat_Booking
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
            this.EconomySBCB = new System.Windows.Forms.ComboBox();
            this.BusinessSBCB = new System.Windows.Forms.ComboBox();
            this.NoESL = new System.Windows.Forms.Label();
            this.NoBSL = new System.Windows.Forms.Label();
            this.TAB_BDT = new System.Windows.Forms.TextBox();
            this.Total_Amount = new System.Windows.Forms.Label();
            this.BDT = new System.Windows.Forms.Label();
            this.TAB_USD = new System.Windows.Forms.TextBox();
            this.USD = new System.Windows.Forms.Label();
            this.SB_Next = new System.Windows.Forms.Button();
            this.SeatBooking_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EconomySBCB
            // 
            this.EconomySBCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EconomySBCB.FormattingEnabled = true;
            this.EconomySBCB.Location = new System.Drawing.Point(588, 39);
            this.EconomySBCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EconomySBCB.Name = "EconomySBCB";
            this.EconomySBCB.Size = new System.Drawing.Size(134, 26);
            this.EconomySBCB.TabIndex = 0;
            this.EconomySBCB.SelectedIndexChanged += new System.EventHandler(this.EconomySBCB_SelectedIndexChanged);
            // 
            // BusinessSBCB
            // 
            this.BusinessSBCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BusinessSBCB.FormattingEnabled = true;
            this.BusinessSBCB.Location = new System.Drawing.Point(588, 130);
            this.BusinessSBCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BusinessSBCB.Name = "BusinessSBCB";
            this.BusinessSBCB.Size = new System.Drawing.Size(133, 26);
            this.BusinessSBCB.TabIndex = 1;
            this.BusinessSBCB.SelectedIndexChanged += new System.EventHandler(this.BusinessSBCB_SelectedIndexChanged);
            // 
            // NoESL
            // 
            this.NoESL.AutoSize = true;
            this.NoESL.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NoESL.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoESL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NoESL.Location = new System.Drawing.Point(32, 47);
            this.NoESL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NoESL.Name = "NoESL";
            this.NoESL.Size = new System.Drawing.Size(183, 18);
            this.NoESL.TabIndex = 2;
            this.NoESL.Text = "Number of Economy Seat : ";
            // 
            // NoBSL
            // 
            this.NoBSL.AutoSize = true;
            this.NoBSL.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NoBSL.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoBSL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NoBSL.Location = new System.Drawing.Point(32, 130);
            this.NoBSL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NoBSL.Name = "NoBSL";
            this.NoBSL.Size = new System.Drawing.Size(183, 18);
            this.NoBSL.TabIndex = 3;
            this.NoBSL.Text = " Number of Business Seat : ";
            // 
            // TAB_BDT
            // 
            this.TAB_BDT.Location = new System.Drawing.Point(588, 213);
            this.TAB_BDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TAB_BDT.Name = "TAB_BDT";
            this.TAB_BDT.Size = new System.Drawing.Size(134, 25);
            this.TAB_BDT.TabIndex = 4;
            this.TAB_BDT.Text = "0";
            // 
            // Total_Amount
            // 
            this.Total_Amount.AutoSize = true;
            this.Total_Amount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Total_Amount.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Amount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Total_Amount.Location = new System.Drawing.Point(32, 213);
            this.Total_Amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Total_Amount.Name = "Total_Amount";
            this.Total_Amount.Size = new System.Drawing.Size(99, 18);
            this.Total_Amount.TabIndex = 5;
            this.Total_Amount.Text = "Total Amount";
            // 
            // BDT
            // 
            this.BDT.AutoSize = true;
            this.BDT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BDT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BDT.Location = new System.Drawing.Point(734, 217);
            this.BDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BDT.Name = "BDT";
            this.BDT.Size = new System.Drawing.Size(39, 18);
            this.BDT.TabIndex = 6;
            this.BDT.Text = "BDT";
            // 
            // TAB_USD
            // 
            this.TAB_USD.Location = new System.Drawing.Point(588, 249);
            this.TAB_USD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TAB_USD.Name = "TAB_USD";
            this.TAB_USD.Size = new System.Drawing.Size(134, 25);
            this.TAB_USD.TabIndex = 7;
            this.TAB_USD.Text = "0";
            // 
            // USD
            // 
            this.USD.AutoSize = true;
            this.USD.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.USD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.USD.Location = new System.Drawing.Point(734, 253);
            this.USD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.USD.Name = "USD";
            this.USD.Size = new System.Drawing.Size(14, 18);
            this.USD.TabIndex = 8;
            this.USD.Text = "$";
            // 
            // SB_Next
            // 
            this.SB_Next.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SB_Next.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SB_Next.Location = new System.Drawing.Point(610, 303);
            this.SB_Next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SB_Next.Name = "SB_Next";
            this.SB_Next.Size = new System.Drawing.Size(112, 42);
            this.SB_Next.TabIndex = 9;
            this.SB_Next.Text = "Next";
            this.SB_Next.UseVisualStyleBackColor = false;
            this.SB_Next.Click += new System.EventHandler(this.SB_Next_Click);
            // 
            // SeatBooking_Back
            // 
            this.SeatBooking_Back.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SeatBooking_Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SeatBooking_Back.Location = new System.Drawing.Point(35, 303);
            this.SeatBooking_Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SeatBooking_Back.Name = "SeatBooking_Back";
            this.SeatBooking_Back.Size = new System.Drawing.Size(112, 42);
            this.SeatBooking_Back.TabIndex = 10;
            this.SeatBooking_Back.Text = "Go Back";
            this.SeatBooking_Back.UseVisualStyleBackColor = false;
            this.SeatBooking_Back.Click += new System.EventHandler(this.SeatBooking_Back_Click);
            // 
            // Seat_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::Air_Reservation_System.Properties.Resources._7ba6c9bbaf8a9f8953dce632107519ee;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 361);
            this.Controls.Add(this.SeatBooking_Back);
            this.Controls.Add(this.SB_Next);
            this.Controls.Add(this.USD);
            this.Controls.Add(this.TAB_USD);
            this.Controls.Add(this.BDT);
            this.Controls.Add(this.Total_Amount);
            this.Controls.Add(this.TAB_BDT);
            this.Controls.Add(this.NoBSL);
            this.Controls.Add(this.NoESL);
            this.Controls.Add(this.BusinessSBCB);
            this.Controls.Add(this.EconomySBCB);
            this.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Seat_Booking";
            this.Text = "Seat Booking";
            this.Load += new System.EventHandler(this.Seat_Booking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EconomySBCB;
        private System.Windows.Forms.ComboBox BusinessSBCB;
        private System.Windows.Forms.Label NoESL;
        private System.Windows.Forms.Label NoBSL;
        private System.Windows.Forms.TextBox TAB_BDT;
        private System.Windows.Forms.Label Total_Amount;
        private System.Windows.Forms.Label BDT;
        private System.Windows.Forms.TextBox TAB_USD;
        private System.Windows.Forms.Label USD;
        private System.Windows.Forms.Button SB_Next;
        private System.Windows.Forms.Button SeatBooking_Back;
    }
}