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
    public partial class UserHome : Form
    {
        int userID = 0;
        Form cLF = null;
        int fID = 0;
        int addES = 0;
        int addBS = 0;
        int esT = 0;
        int bsT = 0;
        Airline_Reservation_SystemDBCDataContext uHD = new Airline_Reservation_SystemDBCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\Visual Studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Airline_Reservation_System.mdf;Integrated Security=True;Connect Timeout=30");

        public UserHome()
        {
            InitializeComponent();
        }

        public UserHome(Form cLF, int userID)
        {
            InitializeComponent();
            this.userID = userID;
            this.cLF = cLF;
        }

        private void CNameL_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserHome_Load(object sender, EventArgs e)
        {
            Airline_Reservation_SystemDBCDataContext uHLD = new Airline_Reservation_SystemDBCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\Visual Studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Airline_Reservation_System.mdf;Integrated Security=True;Connect Timeout=30");


            var x = from a in uHLD.Customer_Infos
                    where a.CID == userID
                    select a;

            CIDTB.Text = x.First().CID.ToString();
            CIDTB.Enabled = false;
            CustomerName.Text = x.First().CName;
            string cG = x.First().CGender;
            CustomerDOB.Text = x.First().CDOB;
            CustomerPN.Text = x.First().CPhone_Num;
            CustomerEID.Text = x.First().CEmail;
            CustomerPassportNo.Text = x.First().CPassport_No;
            CustomerNationality.Text = x.First().CNationality;
            CardHolderNameTB.Text = x.First().Card_Holder_Name;
            CreditCardNoTB.Text = x.First().Credit_Card_No.ToString();
            User_Pass_TB.Text = x.First().CPassword;

            CustomerGender.Items.AddRange(new string[] { "Male", "Female" });
            if (cG == "Male")
            {
                CustomerGender.SelectedIndex = 0;
            }
            else if (cG == "Female")
            {
                CustomerGender.SelectedIndex = 1;
            }

            int carryON = 0;

            var y = from b in uHLD.TicketBooked_Infos
                    where b.CID == userID
                    select b;

            if (y.Any())
            {
                fID = y.First().Flight_ID;
                UH_Flight_Name_TB.Text = y.First().Flight_ID.ToString();
                UH_Flight_Name_TB.Enabled = false;
                esT = y.First().Economy_Seat_Taken;
                EconomySeatBox.Text = y.First().Economy_Seat_Taken.ToString();
                EconomySeatBox.Enabled = false;
                bsT = y.First().Business_Seat_Taken;
                Business_SeatBox.Text = y.First().Business_Seat_Taken.ToString();
                Business_SeatBox.Enabled = false;
                //addES = y.First().Economy_Seat_Taken;
                //addBS = y.First().Business_Seat_Taken;

                carryON = 1;
            }
            if (carryON == 1)
            {
                var z = from c in uHLD.Flight_Details
                        where c.Flight_ID == fID
                        select c;

                UH_Destination_TB.Text = z.First().Destination;
                UH_Destination_TB.Enabled = false;
                UH_Departure_TB.Text = z.First().Departure;
                UH_Departure_TB.Enabled = false;
                Time_Schedule_Box.Text = z.First().Time;
                Time_Schedule_Box.Enabled = false;
                Date_Schedule_Box.Text = z.First().Date;
                Date_Schedule_Box.Enabled = false;
                addES = Convert.ToInt32(z.First().Available_Seat_E_);
                addBS = Convert.ToInt32(z.First().Available_Seat_B_);
            }
            else
            {
                UH_Flight_Name_TB.Text = "";
                UH_Flight_Name_TB.Enabled = false;
                EconomySeatBox.Text = "";
                EconomySeatBox.Enabled = false;
                Business_SeatBox.Text = "";
                Business_SeatBox.Enabled = false;

                UH_Destination_TB.Text = "";
                UH_Destination_TB.Enabled = false;
                UH_Departure_TB.Text = "";
                UH_Departure_TB.Enabled = false;
                Time_Schedule_Box.Text = "";
                Time_Schedule_Box.Enabled = false;
                Date_Schedule_Box.Text = "";
                Date_Schedule_Box.Enabled = false;

                UI_Cancel_Reservation.Visible = false;           
            }

        }

        private void UI_Cancel_Reservation_Click(object sender, EventArgs e)
        {
            Airline_Reservation_SystemDBCDataContext uHCD = new Airline_Reservation_SystemDBCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\Visual Studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Airline_Reservation_System.mdf;Integrated Security=True;Connect Timeout=30");

            var y = from b in uHCD.TicketBooked_Infos
                    where b.CID == userID
                    select b;

            //y.First().Flight_ID

            foreach (TicketBooked_Info p in y)
            {
                uHCD.TicketBooked_Infos.DeleteOnSubmit(p);
            }

            uHCD.SubmitChanges();

            MessageBox.Show("Reservation Canceled");

            var z = from c in uHCD.Flight_Details
                    where c.Flight_ID == fID
                    select c;

            z.First().Available_Seat_E_ = addES + esT;
            z.First().Available_Seat_B_ = addBS + bsT;

            uHCD.SubmitChanges();

            UH_Flight_Name_TB.Text = "";
            UH_Flight_Name_TB.Enabled = false;
            EconomySeatBox.Text = "";
            EconomySeatBox.Enabled = false;
            Business_SeatBox.Text = "";
            Business_SeatBox.Enabled = false;

            UH_Destination_TB.Text = "";
            UH_Destination_TB.Enabled = false;
            UH_Departure_TB.Text = "";
            UH_Departure_TB.Enabled = false;
            Time_Schedule_Box.Text = "";
            Time_Schedule_Box.Enabled = false;
            Date_Schedule_Box.Text = "";
            Date_Schedule_Box.Enabled = false;

            UI_Cancel_Reservation.Visible = false;     
        }

        private void UH_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            cLF.Show();
        }

        private void UI_Update_IB_Click(object sender, EventArgs e)
        {
            Airline_Reservation_SystemDBCDataContext uHLD = new Airline_Reservation_SystemDBCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\Visual Studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Airline_Reservation_System.mdf;Integrated Security=True;Connect Timeout=30");

            //string cID = "";
            string cName = "";
            string cGender = "";
            string cDOB = "";
            string cPN = "";
            string cEID = "";
            string cPPNo = "";
            string cNationality = "";
            string cHName = "";
            string cCrdN = "";
            string cPass = "";

            //x.First().CID = Convert.ToInt32(CIDTB.Text);
            cName = CustomerName.Text;
            cGender = CustomerGender.SelectedItem.ToString();
            cDOB = CustomerDOB.Text;
            cPN = CustomerPN.Text;
            cEID = CustomerEID.Text;
            cPPNo = CustomerPassportNo.Text;
            cNationality = CustomerNationality.Text;
            cHName = CardHolderNameTB.Text;
            cCrdN = CreditCardNoTB.Text;
            cPass = User_Pass_TB.Text;

            bool allDigitPP = cPPNo.All(char.IsDigit);
            bool allDigitPN = cPN.All(char.IsDigit);
            bool allDigitCCNo = cCrdN.All(char.IsDigit);
            int warning = 0;
            int nameV = 0;

            if ((cName == "") || (cGender == "") || (cDOB == "") || (cPN == "") || (cEID == "") || (cNationality == "") || (cPPNo == ""))
            {
                MessageBox.Show("Can't keep any field blank!!! Fill up all to proceed!");
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

                if (allDigitCCNo == false)
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

                if (Regex.IsMatch(cHName, @"^[a-zA-Z]+$") == true) //all character
                {
                    //MessageBox.Show("All are letters");
                }
                else
                {
                    MessageBox.Show("Not a valid Card Holder Name!");
                    warning = 7;
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

                if (warning == 0)
                {
                    //MessageBox.Show("Go to next form! :) "+warning);
                    //PaymentMethodPanel pMF=new PaymentMethodPanel(this, flightListNo, totalAmount, cID, cName, cGender, cDOB, cPN, cEID, cPPNo, cNationality,intoE,intoB,sEAvail,sBAvail);
                    //pMF.Show();
                    //this.Hide();
                    var x = from a in uHLD.Customer_Infos
                            where a.CID == userID
                            select a;

                    x.First().CID = Convert.ToInt32(CIDTB.Text);
                    x.First().CName = CustomerName.Text;
                    x.First().CGender = CustomerGender.Text;
                    x.First().CDOB = CustomerDOB.Text;
                    x.First().CPhone_Num = CustomerPN.Text;
                    x.First().CEmail = CustomerEID.Text;
                    x.First().CPassport_No = CustomerPassportNo.Text;
                    x.First().CNationality = CustomerNationality.Text;
                    x.First().Card_Holder_Name = CardHolderNameTB.Text;
                    x.First().Credit_Card_No = Convert.ToInt32(CreditCardNoTB.Text);
                    x.First().CPassword = User_Pass_TB.Text;

                    uHLD.SubmitChanges();

                    MessageBox.Show("Update Successfull!");
                    UserHome uH2 = new UserHome(cLF, userID);
                    this.Hide();
                    uH2.Show();
                }
            } 
        }
    }
}
