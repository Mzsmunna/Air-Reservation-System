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
    public partial class Seat_Booking : Form
    {
        int economyP = 0;
        int businessP = 0;
        int flightListNo=0;
        int ecP = 0;
        int bsnsP = 0;
        int totalAmount = 0;
        int intoE = 0;
        int intoB = 0;
        int sEAvail = 0;
        int sBAvail = 0;
        Form fDF;
        string selectedE = "";
        string selectedB = "";

        public Seat_Booking()
        {
            InitializeComponent();
        }

        public Seat_Booking(Form fDF, int flightListNo, int economyP, int businessP, int sEAvail, int sBAvail)
        {
            InitializeComponent();
            this.fDF = fDF;
            this.flightListNo = flightListNo;
            this.economyP = economyP;
            this.businessP = businessP;
            this.sEAvail = sEAvail;
            this.sBAvail = sBAvail;
        }

        private void Seat_Booking_Load(object sender, EventArgs e)
        {
            EconomySBCB.Items.AddRange(new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            BusinessSBCB.Items.AddRange(new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });

            EconomySBCB.SelectedIndex = 0;
            BusinessSBCB.SelectedIndex = 0;

            TAB_BDT.Enabled = false;
            TAB_USD.Enabled = false;
        }

        private void EconomySBCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedE = EconomySBCB.SelectedItem.ToString();
            intoE = Convert.ToInt32(selectedE);
            ecP = economyP * intoE;
            totalAmount = ecP + bsnsP;
            float tAf = totalAmount / (float)81.15;
            TAB_BDT.Text = totalAmount.ToString();
            TAB_USD.Text = tAf.ToString();
        }

        private void BusinessSBCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedB = BusinessSBCB.SelectedItem.ToString();
            intoB = Convert.ToInt32(selectedB);
            bsnsP = businessP * intoB;
            totalAmount = ecP + bsnsP;
            float tAf = totalAmount / (float)81.15;
            TAB_BDT.Text = totalAmount.ToString();
            TAB_USD.Text = tAf.ToString();
        }

        private void SeatBooking_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            fDF.Show();
        }

        private void SB_Next_Click(object sender, EventArgs e)
        {
            if (totalAmount==0)
            {
                MessageBox.Show("Select atleast one seat then proceed.....!!!");
            }
            else if(intoE>sEAvail)
            {
                MessageBox.Show("That Much Economy seat is not available for the Flight!!!!");
            }
            else if(intoB>sBAvail)
            {
                MessageBox.Show("That Much Business seat is not available for the Flight!!!!");
            }
            else
            {
                sEAvail = sEAvail - intoE;
                sBAvail = sBAvail - intoB;
                CustomerInfoPanel cIF = new CustomerInfoPanel(this, flightListNo, totalAmount, intoE, intoB, sEAvail, sBAvail);
                this.Hide();
                cIF.Show();
            }
        }
    }
}
