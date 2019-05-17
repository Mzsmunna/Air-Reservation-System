namespace Air_Reservation_System
{
    partial class CashPaymentPanel
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
            this.Cash_Amount_TB = new System.Windows.Forms.TextBox();
            this.CashAmountL = new System.Windows.Forms.Label();
            this.Cash_Payment = new System.Windows.Forms.Button();
            this.AmountToPayL = new System.Windows.Forms.Label();
            this.TotalAmountTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cash_Amount_TB
            // 
            this.Cash_Amount_TB.Location = new System.Drawing.Point(215, 126);
            this.Cash_Amount_TB.Name = "Cash_Amount_TB";
            this.Cash_Amount_TB.Size = new System.Drawing.Size(152, 20);
            this.Cash_Amount_TB.TabIndex = 0;
            // 
            // CashAmountL
            // 
            this.CashAmountL.AutoSize = true;
            this.CashAmountL.BackColor = System.Drawing.Color.SteelBlue;
            this.CashAmountL.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashAmountL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CashAmountL.Location = new System.Drawing.Point(2, 126);
            this.CashAmountL.Name = "CashAmountL";
            this.CashAmountL.Size = new System.Drawing.Size(182, 18);
            this.CashAmountL.TabIndex = 1;
            this.CashAmountL.Text = "Enter the Cash Amount Here ";
            // 
            // Cash_Payment
            // 
            this.Cash_Payment.BackColor = System.Drawing.Color.SteelBlue;
            this.Cash_Payment.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cash_Payment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cash_Payment.Location = new System.Drawing.Point(276, 196);
            this.Cash_Payment.Name = "Cash_Payment";
            this.Cash_Payment.Size = new System.Drawing.Size(91, 31);
            this.Cash_Payment.TabIndex = 2;
            this.Cash_Payment.Text = "Pay";
            this.Cash_Payment.UseVisualStyleBackColor = false;
            this.Cash_Payment.Click += new System.EventHandler(this.Cash_Payment_Click);
            // 
            // AmountToPayL
            // 
            this.AmountToPayL.AutoSize = true;
            this.AmountToPayL.BackColor = System.Drawing.Color.SteelBlue;
            this.AmountToPayL.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountToPayL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AmountToPayL.Location = new System.Drawing.Point(149, 31);
            this.AmountToPayL.Name = "AmountToPayL";
            this.AmountToPayL.Size = new System.Drawing.Size(93, 18);
            this.AmountToPayL.TabIndex = 3;
            this.AmountToPayL.Text = "Amount to Pay";
            // 
            // TotalAmountTB
            // 
            this.TotalAmountTB.Location = new System.Drawing.Point(248, 31);
            this.TotalAmountTB.Name = "TotalAmountTB";
            this.TotalAmountTB.Size = new System.Drawing.Size(79, 20);
            this.TotalAmountTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(333, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "BDT";
            // 
            // CashPaymentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Air_Reservation_System.Properties.Resources.cash_payment_23_2147511454__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(372, 229);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalAmountTB);
            this.Controls.Add(this.AmountToPayL);
            this.Controls.Add(this.Cash_Payment);
            this.Controls.Add(this.CashAmountL);
            this.Controls.Add(this.Cash_Amount_TB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CashPaymentPanel";
            this.Text = "Cash Payment Panel";
            this.Load += new System.EventHandler(this.CashPaymentPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Cash_Amount_TB;
        private System.Windows.Forms.Label CashAmountL;
        private System.Windows.Forms.Button Cash_Payment;
        private System.Windows.Forms.Label AmountToPayL;
        private System.Windows.Forms.TextBox TotalAmountTB;
        private System.Windows.Forms.Label label1;
    }
}