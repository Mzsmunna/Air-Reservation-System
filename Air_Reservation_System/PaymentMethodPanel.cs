using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_Reservation_System
{
    public partial class PaymentMethodPanel : Form
    {
        string cName = "";
        string cGender = "";
        string cDOB = "";
        string cPN = "";
        string cEID = "";
        string cPPNo = "";
        string cNationality = "";
        Form cIF;
        int flightListNo = 0;
        int totalAmount = 0;
        int intoE = 0;
        int intoB = 0;
        int sEAvail = 0;
        int sBAvail=0;
        string cID;
        public PaymentMethodPanel()
        {
            InitializeComponent();
        }

        public PaymentMethodPanel(Form cIF, int flightListNo, int totalAmount, string cID, string cName, string cGender, string cDOB, string cPN, string cEID, string cPPNo, string cNationality, int intoE, int intoB, int sEAvail, int sBAvail)
        {
            InitializeComponent();
            this.cIF = cIF;
            this.flightListNo = flightListNo;
            this.totalAmount = totalAmount;
            this.cName = cName;
            this.cGender = cGender;
            this.cDOB = cDOB;
            this.cPN = cPN;
            this.cEID = cEID;
            this.cPPNo = cPPNo;
            this.cNationality = cNationality;
            this.intoB = intoB;
            this.intoE = intoE;
            this.sEAvail = sEAvail;
            this.sBAvail = sBAvail;
            this.cID = cID;
        }

        private void Cash_Click(object sender, EventArgs e)
        {
            //
            CashPaymentPanel cpPF = new CashPaymentPanel(this, flightListNo, totalAmount, cID, cName, cGender, cDOB, cPN, cEID, cPPNo, cNationality, intoE, intoB, sEAvail, sBAvail);
            cpPF.Show();
            this.Hide();
        }

        private void Credit_Card_Click(object sender, EventArgs e)
        {
            CreditCardInfoPanel cCIF = new CreditCardInfoPanel(this, flightListNo, totalAmount, cID, cName, cGender, cDOB, cPN, cEID, cPPNo, cNationality,intoE,intoB,sEAvail,sBAvail);
            cCIF.Show();
            this.Hide();
        }

        private void PM_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            cIF.Show();
        }
    }
}
