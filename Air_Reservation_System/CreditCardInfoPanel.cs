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
using System.IO;

namespace Air_Reservation_System
{
    public partial class CreditCardInfoPanel : Form
    {
        string cID = "";
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
        int sEAvail=0;
        int sBAvail=0;
        int cCount=3;
        int fCount=1;
        int aCount=3;
        int tbCount=0;

        string cHName = "";
        string cCNo = "";
        string cCPc = "";
        string cCEd = "";

        //Air_Reservation_DBDataContext ciD = new Air_Reservation_DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\visual studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Air_Reservation.mdf;Integrated Security=True;Connect Timeout=30");
        Airline_Reservation_SystemDBCDataContext ciD = new Airline_Reservation_SystemDBCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\Visual Studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Airline_Reservation_System.mdf;Integrated Security=True;Connect Timeout=30");


        public CreditCardInfoPanel()
        {
            InitializeComponent();
        }

        public CreditCardInfoPanel(Form cIF, int flightListNo, int totalAmount, string cID, string cName, string cGender, string cDOB, string cPN, string cEID, string cPPNo, string cNationality,int intoE, int intoB, int sEAvail, int sBAvail)
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
            this.intoE = intoE;
            this.intoB = intoB;
            this.sEAvail=sEAvail;
            this.sBAvail=sBAvail;
            this.cID = cID;
        }

        private void CCI_Pay_Click(object sender, EventArgs e)
        {
            int warning = 0;

            cHName = CardHolderNameTB.Text;
            cCNo = CreditCardNoTB.Text;
            cCPc = CardPinNoTB.Text;
            cCEd = CCIEXD.Value.ToString("dd-MM-yyyy");

            bool allDigitCCN = cCNo.All(char.IsDigit);
            bool allDigitCPC = cCPc.All(char.IsDigit);

            if ((cHName == "") || (cCNo == "") || (cCPc == "") || (cCEd == ""))
            {
                MessageBox.Show("Can't skip any field!!! Fill up all to proceed!");
            }
            else
            {
                if (allDigitCCN == false)
                {
                    MessageBox.Show("Invalid Credit Card Number");
                    warning = 3;
                }

                if (allDigitCPC == false)
                {
                    MessageBox.Show("Invalid Pin Code Number");
                    warning = 2;
                }

                if (Regex.IsMatch(cHName, @"^[a-zA-Z ]{2,30}$") == true)
                {
                    //MessageBox.Show("valid name no number upto 30!");  
                    //nameV = 1;
                }
                else
                {
                    MessageBox.Show("Invalid Card Holder name");
                    warning = 1;
                }

                if (warning == 0)
                {
                    int cusID = Convert.ToInt32(cID);
                    //string path=Path.GetRandomFileName();
                    //path=path.Replace(".","");
                    //cCount++;
                    string path = "12345" + cName;
                    Customer_Info ciT = new Customer_Info
                    {
                        CID=cusID,
                        CName=cName,
                        CGender=cGender,
                        CDOB=cDOB,
                        CPhone_Num=cPN,
                        CEmail=cEID,
                        CPassport_No=cPPNo,
                        CNationality=cNationality,
                        Card_Holder_Name=cHName,
                        Credit_Card_No=Convert.ToInt32(cCNo),
                        Card_Expire_Date=cCEd,
                        CPassword=path
                    };

                    ciD.Customer_Infos.InsertOnSubmit(ciT);
                    ciD.SubmitChanges();

                    var x = from a in ciD.Flight_Details
                            where a.Flight_ID == flightListNo
                            select a;

                    string fN = x.First().Flight_Name;
                    x.First().Available_Seat_E_ = sEAvail;
                    x.First().Available_Seat_B_ = sBAvail;

                    ciD.SubmitChanges();

                    var y = from b in ciD.Flight_Details
                            //where a.Flight_Name == APSearchBox.Text
                            where b.Available_Seat_B_ == 0
                               && b.Available_Seat_E_ == 0
                            select b;

                    foreach (Flight_Detail p in y)
                    {
                        ciD.Flight_Details.DeleteOnSubmit(p);
                    }

                    ciD.SubmitChanges();

                    TicketBooked_Info tbT = new TicketBooked_Info
                    {
                        CID=cusID,
                        CName=cName,
                        Flight_ID=flightListNo,
                        Flight_Name=fN,
                        Business_Seat_Taken=intoB,
                        Economy_Seat_Taken=intoE
                    };

                    ciD.TicketBooked_Infos.InsertOnSubmit(tbT);
                    ciD.SubmitChanges();

                    MessageBox.Show("Ticket Confirmation is Successfull!! :)\n\nYour User Password is : " + path + "\n\nyou can login with your user name using this password from login panel! ");
                    this.Hide();
                    AIRRMainFrame mF = new AIRRMainFrame();
                    mF.Show();
                }
            }
        }
    }
}
