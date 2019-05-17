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
    public partial class AddFlightPanel : Form
    {
        //Air_Reservation_DBDataContext aFPD = new Air_Reservation_DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\documents\visual studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Air_Reservation.mdf;Integrated Security=True;Connect Timeout=30");
        Airline_Reservation_SystemDBCDataContext aFPD = new Airline_Reservation_SystemDBCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\Visual Studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Airline_Reservation_System.mdf;Integrated Security=True;Connect Timeout=30");

        string status = "";
        string fName = "";
        string des = "";
        string dep = "";
        string date = "";
        string time = "";
        string availES = "";
        string availBS = "";
        string ecoCost = "";
        string bsnsCost = "";

        Form cIF;
        DataGridView apDGV;

        int flightListNo = -1;
        int fID = 0;
        public AddFlightPanel()
        {
            InitializeComponent();
        }

        public AddFlightPanel(String status, DataGridView apDGV, int flightListNo)
        {
            InitializeComponent();
            this.status = status;
            this.apDGV = apDGV;
            this.flightListNo = flightListNo;
        }

        private void AFP_Add_Flight_Button_Click(object sender, EventArgs e)
        {
            int warning = 0;
            int nameV = 0;
            string fids = "";
            fids = AFP_FIDTB.Text;
            fName = AFP_Flight_Name_Box.Text;
            des = AFP_DestinationBox.Text;
            dep = AFP_DepertureBox.Text;
            date = AFP_Date.Value.ToString("dd-MM-yyyy");
            time = AFP_Time.Value.ToString("H:mm");
            availES = AFP_AvailESB.Text;
            availBS = AFP_AvailBSB.Text;
            ecoCost = AFP_EcoCostBox.Text;
            bsnsCost = AFP_BsnsCostBox.Text;

            bool allDigitAES = availES.All(char.IsDigit);
            bool allDigitABS = availBS.All(char.IsDigit);
            bool allDigitEC = ecoCost.All(char.IsDigit);
            bool allDigitBC = bsnsCost.All(char.IsDigit);
            bool allDigitFID = fids.All(char.IsDigit);
            int availES2I = 0;
            int availBS2I = 0;
            int ecoCost2I = 0;
            int bsnsCost2I = 0;

            if ((fName == "") || (des == "") || (dep == "") || (date == "") || (time == "") || (availES == "") || (availBS == "") || (ecoCost == "") || (bsnsCost == "") || (fids == ""))
            {
                MessageBox.Show("Can't skip any field!!! Fill up all to proceed!");
            }
            else
            {
                if (allDigitAES == false)
                {
                    MessageBox.Show("Number of Economy seat is invalid");
                    warning = 1;
                }
                else
                {
                    availES2I = Convert.ToInt32(availES);

                }

                if (allDigitFID == false)
                {
                    MessageBox.Show("Number of Economy seat is invalid");
                    warning = 1;
                }
                else
                {
                    fID = Convert.ToInt32(fids);

                }

                if (allDigitABS == false)
                {
                    MessageBox.Show("Number of Business seat is invalid");
                    warning = 2;
                }
                else
                {
                    availBS2I = Convert.ToInt32(availBS);
                }

                if (allDigitEC == false)
                {
                    MessageBox.Show("Economy Seeat Amount is invalid");
                    warning = 3;
                }
                else
                {
                    ecoCost2I = Convert.ToInt32(ecoCost);
                }

                if (allDigitBC == false)
                {
                    MessageBox.Show("Business Seat Amount is invalid");
                    warning = 4;
                }
                else
                {
                    bsnsCost2I = Convert.ToInt32(bsnsCost);
                }

                if (Regex.IsMatch(des, @"^[a-zA-Z]+$") == true) //all character
                {
                    //MessageBox.Show("All are letters");
                }
                else
                {
                    MessageBox.Show("Not a valid Destination!");
                    warning = 5;
                }

                if (Regex.IsMatch(dep, @"^[a-zA-Z]+$") == true) //all character
                {
                    //MessageBox.Show("All are letters");
                }
                else
                {
                    MessageBox.Show("Not a valid Departure!");
                    warning = 6;
                }

                if (Regex.IsMatch(fName, @"^[a-zA-Z ]{2,30}$") == true)
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
                    if (Regex.IsMatch(fName, @"^[a-zA-Z ]{2,26}[0-9]{1,4}$") == true)
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
            }

            if (status == "Add")
            {
                if (warning == 0)
                {

                    Flight_Detail fdT = new Flight_Detail
                    {
                        Flight_ID = fID,
                        Flight_Name = fName,
                        Destination = des,
                        Departure = dep,
                        Date = date,
                        Time = time,
                        Available_Seat_E_ = availES2I,
                        Available_Seat_B_ = availBS2I,
                        Economy_Cost_BDT_ = ecoCost2I,
                        Business_Cost_BDT_ = bsnsCost2I

                    };

                    aFPD.Flight_Details.InsertOnSubmit(fdT);
                    aFPD.SubmitChanges();

                    this.Hide();
                    apDGV.DataSource = aFPD.Flight_Details;

                    MessageBox.Show("Flight Added Successfully");
                }
                
            }
            else if (status == "Update")
            {
                var x = from a in aFPD.Flight_Details
                        where a.Flight_ID == flightListNo
                        select a;
                if (warning == 0)
                {
                    x.First().Flight_Name = fName;
                    x.First().Destination = des;
                    x.First().Departure = dep;
                    x.First().Date = date;
                    x.First().Time = time;
                    x.First().Available_Seat_E_ = availES2I;
                    x.First().Available_Seat_B_ = availBS2I;
                    x.First().Economy_Cost_BDT_ = ecoCost2I;
                    x.First().Business_Cost_BDT_ = bsnsCost2I;

                    aFPD.SubmitChanges();

                    apDGV.DataSource = aFPD.Flight_Details;

                    MessageBox.Show("Flight Updated Successfully");

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Something wnt wrong");
                }
            }
        }

        private void AddFlightPanel_Load(object sender, EventArgs e)
        {
            if(status=="Add")
            {

            }
            else if(status=="Update")
            {
                AFP_Add_Flight_Button.Text = "Update Flight";

                var x = from a in aFPD.Flight_Details
                        where a.Flight_ID == flightListNo
                        select a;

                AFP_FIDTB.Text = x.First().Flight_ID.ToString();
                AFP_FIDTB.Enabled = false;
                AFP_Flight_Name_Box.Text=x.First().Flight_Name;
                AFP_DestinationBox.Text=x.First().Destination;
                AFP_DepertureBox.Text = x.First().Departure;
                AFP_Date.Text=x.First().Date;
                AFP_Time.Text=x.First().Time;
                AFP_AvailESB.Text=x.First().Available_Seat_E_.ToString();
                AFP_AvailBSB.Text = x.First().Available_Seat_B_.ToString();
                AFP_EcoCostBox.Text = x.First().Economy_Cost_BDT_.ToString();
                AFP_BsnsCostBox.Text = x.First().Business_Cost_BDT_.ToString();
            }
        }

        private void AFP_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
