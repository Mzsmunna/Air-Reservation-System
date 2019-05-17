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
    public partial class CashPaymentPanel : Form
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
        int sEAvail = 0;
        int sBAvail = 0;
        int cCount = 3;
        int fCount = 1;
        int aCount = 3;
        int tbCount = 0;
        string amount = "";
        int payment = 0;

        Airline_Reservation_SystemDBCDataContext cpD = new Airline_Reservation_SystemDBCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\Visual Studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Airline_Reservation_System.mdf;Integrated Security=True;Connect Timeout=30");

        public CashPaymentPanel()
        {
            InitializeComponent();
        }

        public CashPaymentPanel(Form cIF, int flightListNo, int totalAmount, string cID, string cName, string cGender, string cDOB, string cPN, string cEID, string cPPNo, string cNationality, int intoE, int intoB, int sEAvail, int sBAvail)
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
            this.sEAvail = sEAvail;
            this.sBAvail = sBAvail;
            this.cID = cID;
        }

        private void Cash_Payment_Click(object sender, EventArgs e)
        {
            int warning =0;
            amount=Cash_Amount_TB.Text;
            bool allDigitCSH = amount.All(char.IsDigit);

            if (amount == "")
            {
                MessageBox.Show("Please Enter the Amount");
            }
            else
            {
                if (allDigitCSH == false)
                {
                    MessageBox.Show("Invalid Amount!!!");
                    warning = 3;
                }
                else
                {
                    payment=Convert.ToInt32(amount);
                }
                if (warning == 0)
                {
                    if(payment>=totalAmount)
                    {
                        int cusID = Convert.ToInt32(cID);
                        //string path=Path.GetRandomFileName();
                        //path=path.Replace(".","");
                        //cCount++;
                        string path = "12345" + cName;
                        Customer_Info ciT = new Customer_Info
                        {
                            CID = cusID,
                            CName = cName,
                            CGender = cGender,
                            CDOB = cDOB,
                            CPhone_Num = cPN,
                            CEmail = cEID,
                            CPassport_No = cPPNo,
                            CNationality = cNationality,
                            //Card_Holder_Name=cHName,
                            //Credit_Card_No=Convert.ToInt32(cCNo),
                            //Card_Expire_Date=cCEd,
                            CPassword = path
                        };

                        cpD.Customer_Infos.InsertOnSubmit(ciT);
                        cpD.SubmitChanges();

                        var x = from a in cpD.Flight_Details
                                where a.Flight_ID == flightListNo
                                select a;

                        string fN = x.First().Flight_Name;
                        x.First().Available_Seat_E_ = sEAvail;
                        x.First().Available_Seat_B_ = sBAvail;

                        cpD.SubmitChanges();


                        var y = from b in cpD.Flight_Details
                                //where a.Flight_Name == APSearchBox.Text
                                where b.Available_Seat_B_ == 0
                                   && b.Available_Seat_E_ == 0
                                select b;

                        foreach (Flight_Detail p in y)
                        {
                            cpD.Flight_Details.DeleteOnSubmit(p);
                        }

                        cpD.SubmitChanges();


                        TicketBooked_Info tbT = new TicketBooked_Info
                        {
                            CID = cusID,
                            CName = cName,
                            Flight_ID = flightListNo,
                            Flight_Name = fN,
                            Business_Seat_Taken = intoB,
                            Economy_Seat_Taken = intoE
                        };

                        cpD.TicketBooked_Infos.InsertOnSubmit(tbT);
                        cpD.SubmitChanges();

                        if(payment>totalAmount)
                        {
                            payment = payment - totalAmount;
                            MessageBox.Show("Your return back amount is : "+payment+" BDT");
                        }

                        MessageBox.Show("Ticket Confirmation is Successfull!! :)\n\nYour User Password is : " + path + "\n\nyou can login with your user name using this password from login panel! ");
                        this.Hide();
                        AIRRMainFrame mF = new AIRRMainFrame();
                        mF.Show();
                    }
                    else if(payment<totalAmount)
                    {
                        MessageBox.Show("Your amount is Insufficient!!");
                    }
                }
            }
        }

        private void CashPaymentPanel_Load(object sender, EventArgs e)
        {
            TotalAmountTB.Text = totalAmount.ToString();
            TotalAmountTB.Enabled = false;
        }
    }
}
