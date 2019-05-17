namespace Air_Reservation_System
{
    partial class PaymentMethodPanel
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
            this.PM_Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Credit_Card = new System.Windows.Forms.Button();
            this.Cash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PM_Back
            // 
            this.PM_Back.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PM_Back.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PM_Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PM_Back.Location = new System.Drawing.Point(12, 277);
            this.PM_Back.Name = "PM_Back";
            this.PM_Back.Size = new System.Drawing.Size(523, 35);
            this.PM_Back.TabIndex = 2;
            this.PM_Back.Text = "GO Back";
            this.PM_Back.UseVisualStyleBackColor = false;
            this.PM_Back.Click += new System.EventHandler(this.PM_Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(116, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cash";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(359, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Credit Card";
            // 
            // Credit_Card
            // 
            this.Credit_Card.BackgroundImage = global::Air_Reservation_System.Properties.Resources.all_credit_cards_accepted;
            this.Credit_Card.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Credit_Card.Location = new System.Drawing.Point(275, 1);
            this.Credit_Card.Name = "Credit_Card";
            this.Credit_Card.Size = new System.Drawing.Size(268, 252);
            this.Credit_Card.TabIndex = 1;
            this.Credit_Card.UseVisualStyleBackColor = true;
            this.Credit_Card.Click += new System.EventHandler(this.Credit_Card_Click);
            // 
            // Cash
            // 
            this.Cash.BackgroundImage = global::Air_Reservation_System.Properties.Resources._103796677_GettyImages_467345287_530x298;
            this.Cash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cash.Location = new System.Drawing.Point(3, 1);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(266, 252);
            this.Cash.TabIndex = 0;
            this.Cash.UseVisualStyleBackColor = true;
            this.Cash.Click += new System.EventHandler(this.Cash_Click);
            // 
            // PaymentMethodPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(547, 314);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PM_Back);
            this.Controls.Add(this.Credit_Card);
            this.Controls.Add(this.Cash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PaymentMethodPanel";
            this.Text = "Payment Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cash;
        private System.Windows.Forms.Button Credit_Card;
        private System.Windows.Forms.Button PM_Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}