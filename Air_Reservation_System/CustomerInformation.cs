using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Air_Reservation_System
{
    public partial class CustomerInfoPanel : Form
    {
        string cID = "";
        string cName = "";
        string cGender = "";
        string cDOB = "";
        string cPN = "";
        string cEID = "";
        string cPPNo = "";
        string cNationality = "";
        Form sBF;
        int flightListNo;
        int totalAmount = 0;
        int intoE=0;
        int intoB=0;
        int sEAvail = 0;
        int sBAvail = 0;

        public CustomerInfoPanel()
        {
            InitializeComponent();
        }

        public CustomerInfoPanel(Form sBF, int flightListNo, int totalAmount, int intoE, int intoB, int sEAvail, int sBAvail)
        {
            InitializeComponent();
            this.sBF = sBF;
            this.flightListNo = flightListNo;
            this.totalAmount = totalAmount;
            this.intoE = intoE;
            this.intoB = intoB;
            this.sEAvail = sEAvail;
            this.sBAvail = sBAvail;
        }

        private void CustomerInfoPanel_Load(object sender, EventArgs e)
        {
            CustomerGender.Items.AddRange(new string[] { "Male", "Female" });
            CustomerGender.SelectedIndex = 0;
        }

        private void CI_Next_Click(object sender, EventArgs e)
        {
            int warning = 0;
            int nameV = 0;
            cID = CIDTB.Text;
            cName = CustomerName.Text;
            cGender = CustomerGender.SelectedItem.ToString();
            cDOB = CustomerDOB.Value.ToString("dd-MM-yyyy");
            cPN = CustomerPN.Text;
            cEID = CustomerEID.Text;
            cNationality = CustomerNationality.Text;
            cPPNo = CustomerPassportNo.Text;

            bool allDigitPP = cPPNo.All(char.IsDigit);
            bool allDigitPN = cPN.All(char.IsDigit);
            bool allDigitCID = cID.All(char.IsDigit);

            if ((cID == "") || (cName == "") || (cGender == "") || (cDOB == "") || (cPN == "") || (cEID == "") || (cNationality == "") || (cPPNo == ""))
            {
                MessageBox.Show("Can't skip any field!!! Fill up all to proceed!");
            }
            else
            {
                if (allDigitPP == false)
                {
                    MessageBox.Show("Invalid Passport Number");
                    warning = 3;
                }

                if (allDigitPN == false)
                {
                    MessageBox.Show("Invalid Phone Number");
                    warning = 4;
                }

                if (allDigitCID == false)
                {
                    MessageBox.Show("Invalid ID Number");
                    warning = 5;
                }

                if (Regex.IsMatch(cNationality, @"^[a-zA-Z]+$") == true) //all character
                {
                    //MessageBox.Show("All are letters");
                }
                else
                {
                    MessageBox.Show("Not a valid Nation!");
                    warning = 6;
                }

                if (Regex.IsMatch(cName, @"^[a-zA-Z ]{2,30}$") == true)
                {
                    //MessageBox.Show("valid name no number upto 30!");  
                    nameV = 1;
                }
                else
                {
                    //MessageBox.Show("Invalid name");
                    warning = 1;
                }

                if (nameV == 0)
                {
                    if (Regex.IsMatch(cName, @"^[a-zA-Z ]{2,26}[0-9]{1,4}$") == true)
                    {
                        //MessageBox.Show("at first letter then number up to 5");
                        warning = 0;
                    }
                    else
                    {
                        MessageBox.Show("Invalid name");
                        warning = 1;
                    }
                }

                if (Regex.IsMatch(cEID, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$") == true)
                {
                    //MessageBox.Show("VALID EMAIL ID");
                    //warning = 0;
                }
                else
                {
                    MessageBox.Show("Invalid email id");
                    warning = 2;
                }

                if(warning==0)
                {
                    //MessageBox.Show("Go to next form! :) "+warning);
                    PaymentMethodPanel pMF=new PaymentMethodPanel(this, flightListNo, totalAmount, cID, cName, cGender, cDOB, cPN, cEID, cPPNo, cNationality,intoE,intoB,sEAvail,sBAvail);
                    pMF.Show();
                    this.Hide();
                }
            }
        }

        private void CI_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            sBF.Show();
        }
    }
}
