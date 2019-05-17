namespace Air_Reservation_System
{
    partial class CreditCardInfoPanel
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
            this.CHNL = new System.Windows.Forms.Label();
            this.CCI_CCN = new System.Windows.Forms.Label();
            this.CCI_CPN = new System.Windows.Forms.Label();
            this.CCI_EXD = new System.Windows.Forms.Label();
            this.CardHolderNameTB = new System.Windows.Forms.TextBox();
            this.CreditCardNoTB = new System.Windows.Forms.TextBox();
            this.CardPinNoTB = new System.Windows.Forms.TextBox();
            this.CCIEXD = new System.Windows.Forms.DateTimePicker();
            this.CCI_Pay = new System.Windows.Forms.Button();
            this.CCI_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CHNL
            // 
            this.CHNL.AutoSize = true;
            this.CHNL.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CHNL.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHNL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CHNL.Location = new System.Drawing.Point(27, 34);
            this.CHNL.Name = "CHNL";
            this.CHNL.Size = new System.Drawing.Size(121, 16);
            this.CHNL.TabIndex = 0;
            this.CHNL.Text = " Card Holder Name : ";
            // 
            // CCI_CCN
            // 
            this.CCI_CCN.AutoSize = true;
            this.CCI_CCN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CCI_CCN.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCI_CCN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CCI_CCN.Location = new System.Drawing.Point(27, 85);
            this.CCI_CCN.Name = "CCI_CCN";
            this.CCI_CCN.Size = new System.Drawing.Size(105, 16);
            this.CCI_CCN.TabIndex = 1;
            this.CCI_CCN.Text = " Credit Card No : ";
            // 
            // CCI_CPN
            // 
            this.CCI_CPN.AutoSize = true;
            this.CCI_CPN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CCI_CPN.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCI_CPN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CCI_CPN.Location = new System.Drawing.Point(27, 137);
            this.CCI_CPN.Name = "CCI_CPN";
            this.CCI_CPN.Size = new System.Drawing.Size(58, 16);
            this.CCI_CPN.TabIndex = 2;
            this.CCI_CPN.Text = " Pin No : ";
            // 
            // CCI_EXD
            // 
            this.CCI_EXD.AutoSize = true;
            this.CCI_EXD.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CCI_EXD.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCI_EXD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CCI_EXD.Location = new System.Drawing.Point(27, 183);
            this.CCI_EXD.Name = "CCI_EXD";
            this.CCI_EXD.Size = new System.Drawing.Size(85, 16);
            this.CCI_EXD.TabIndex = 3;
            this.CCI_EXD.Text = " Expire Date : ";
            // 
            // CardHolderNameTB
            // 
            this.CardHolderNameTB.Location = new System.Drawing.Point(208, 34);
            this.CardHolderNameTB.Name = "CardHolderNameTB";
            this.CardHolderNameTB.Size = new System.Drawing.Size(200, 20);
            this.CardHolderNameTB.TabIndex = 4;
            // 
            // CreditCardNoTB
            // 
            this.CreditCardNoTB.Location = new System.Drawing.Point(208, 85);
            this.CreditCardNoTB.Name = "CreditCardNoTB";
            this.CreditCardNoTB.Size = new System.Drawing.Size(200, 20);
            this.CreditCardNoTB.TabIndex = 5;
            // 
            // CardPinNoTB
            // 
            this.CardPinNoTB.Location = new System.Drawing.Point(208, 137);
            this.CardPinNoTB.Name = "CardPinNoTB";
            this.CardPinNoTB.Size = new System.Drawing.Size(200, 20);
            this.CardPinNoTB.TabIndex = 6;
            // 
            // CCIEXD
            // 
            this.CCIEXD.Location = new System.Drawing.Point(208, 183);
            this.CCIEXD.Name = "CCIEXD";
            this.CCIEXD.Size = new System.Drawing.Size(200, 20);
            this.CCIEXD.TabIndex = 7;
            // 
            // CCI_Pay
            // 
            this.CCI_Pay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CCI_Pay.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCI_Pay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CCI_Pay.Location = new System.Drawing.Point(333, 226);
            this.CCI_Pay.Name = "CCI_Pay";
            this.CCI_Pay.Size = new System.Drawing.Size(75, 32);
            this.CCI_Pay.TabIndex = 8;
            this.CCI_Pay.Text = "Pay";
            this.CCI_Pay.UseVisualStyleBackColor = false;
            this.CCI_Pay.Click += new System.EventHandler(this.CCI_Pay_Click);
            // 
            // CCI_Back
            // 
            this.CCI_Back.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CCI_Back.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCI_Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CCI_Back.Location = new System.Drawing.Point(12, 226);
            this.CCI_Back.Name = "CCI_Back";
            this.CCI_Back.Size = new System.Drawing.Size(75, 32);
            this.CCI_Back.TabIndex = 9;
            this.CCI_Back.Text = "GO Back";
            this.CCI_Back.UseVisualStyleBackColor = false;
            // 
            // CreditCardInfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Air_Reservation_System.Properties.Resources._7363647099098980645no;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(420, 261);
            this.Controls.Add(this.CCI_Back);
            this.Controls.Add(this.CCI_Pay);
            this.Controls.Add(this.CCIEXD);
            this.Controls.Add(this.CardPinNoTB);
            this.Controls.Add(this.CreditCardNoTB);
            this.Controls.Add(this.CardHolderNameTB);
            this.Controls.Add(this.CCI_EXD);
            this.Controls.Add(this.CCI_CPN);
            this.Controls.Add(this.CCI_CCN);
            this.Controls.Add(this.CHNL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CreditCardInfoPanel";
            this.Text = "Credit Card Infomation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CHNL;
        private System.Windows.Forms.Label CCI_CCN;
        private System.Windows.Forms.Label CCI_CPN;
        private System.Windows.Forms.Label CCI_EXD;
        private System.Windows.Forms.TextBox CardHolderNameTB;
        private System.Windows.Forms.TextBox CreditCardNoTB;
        private System.Windows.Forms.TextBox CardPinNoTB;
        private System.Windows.Forms.DateTimePicker CCIEXD;
        private System.Windows.Forms.Button CCI_Pay;
        private System.Windows.Forms.Button CCI_Back;
    }
}