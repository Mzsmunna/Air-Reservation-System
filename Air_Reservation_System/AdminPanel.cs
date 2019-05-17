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
    public partial class AdminPanel : Form
    {
        //Air_Reservation_DBDataContext aPD = new Air_Reservation_DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\documents\visual studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Air_Reservation.mdf;Integrated Security=True;Connect Timeout=30");
        int flightListNo=-1;
        Form alP = null;
        DataGridViewRow selectedRow=null;
        string currentGridView = "";
        public AdminPanel()
        {
            InitializeComponent();
        }
        public AdminPanel(Form alP)
        {
            InitializeComponent();
            this.alP = alP;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            currentGridView = "Flight Details";
            //Air_Reservation_DBDataContext aPD = new Air_Reservation_DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\documents\visual studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Air_Reservation.mdf;Integrated Security=True;Connect Timeout=30");
            Airline_Reservation_SystemDBCDataContext aPD = new Airline_Reservation_SystemDBCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\Visual Studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Airline_Reservation_System.mdf;Integrated Security=True;Connect Timeout=30");

            AP_Gridview_Display.DataSource = aPD.Flight_Details;
            AP_Gridview_Display.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void AP_Admin_Table_Click(object sender, EventArgs e)
        {
            currentGridView = "Admin Table";
            //Air_Reservation_DBDataContext aPD = new Air_Reservation_DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\documents\visual studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Air_Reservation.mdf;Integrated Security=True;Connect Timeout=30");
            Airline_Reservation_SystemDBCDataContext aPD = new Airline_Reservation_SystemDBCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\Visual Studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Airline_Reservation_System.mdf;Integrated Security=True;Connect Timeout=30");

            AP_Gridview_Display.DataSource = aPD.Admins;
            AP_Gridview_Display.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void AP_Customer_Table_Click(object sender, EventArgs e)
        {
            currentGridView = "Customer Information";
            //Air_Reservation_DBDataContext aPD = new Air_Reservation_DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\documents\visual studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Air_Reservation.mdf;Integrated Security=True;Connect Timeout=30");
            Airline_Reservation_SystemDBCDataContext aPD = new Airline_Reservation_SystemDBCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\Visual Studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Airline_Reservation_System.mdf;Integrated Security=True;Connect Timeout=30");

            AP_Gridview_Display.DataSource = aPD.Customer_Infos;
            AP_Gridview_Display.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void AP_Flight_Details_Table_Click(object sender, EventArgs e)
        {
            currentGridView = "Flight Details";
            //Air_Reservation_DBDataContext aPD = new Air_Reservation_DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\documents\visual studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Air_Reservation.mdf;Integrated Security=True;Connect Timeout=30");
            Airline_Reservation_SystemDBCDataContext aPD = new Airline_Reservation_SystemDBCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\Visual Studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Airline_Reservation_System.mdf;Integrated Security=True;Connect Timeout=30");

            AP_Gridview_Display.DataSource = aPD.Flight_Details;
            AP_Gridview_Display.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void AP_Seat_Booking_Click(object sender, EventArgs e)
        {
            currentGridView = "Ticket Booking Details";
            //Air_Reservation_DBDataContext aPD = new Air_Reservation_DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\documents\visual studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Air_Reservation.mdf;Integrated Security=True;Connect Timeout=30");
            Airline_Reservation_SystemDBCDataContext aPD = new Airline_Reservation_SystemDBCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\Visual Studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Airline_Reservation_System.mdf;Integrated Security=True;Connect Timeout=30");

            AP_Gridview_Display.DataSource = aPD.TicketBooked_Infos;
            AP_Gridview_Display.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void AP_Add_Flight_Click(object sender, EventArgs e)
        {
            //Air_Reservation_DBDataContext aPD = new Air_Reservation_DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\documents\visual studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Air_Reservation.mdf;Integrated Security=True;Connect Timeout=30");
            Airline_Reservation_SystemDBCDataContext aPD = new Airline_Reservation_SystemDBCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\Visual Studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Airline_Reservation_System.mdf;Integrated Security=True;Connect Timeout=30");

            AddFlightPanel aFF = new AddFlightPanel("Add", AP_Gridview_Display, flightListNo);
            aFF.Show();
        }

        private void AP_UpdateF_Click(object sender, EventArgs e)
        {
            //Air_Reservation_DBDataContext aPD = new Air_Reservation_DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\documents\visual studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Air_Reservation.mdf;Integrated Security=True;Connect Timeout=30");
            Airline_Reservation_SystemDBCDataContext aPD = new Airline_Reservation_SystemDBCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\Visual Studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Airline_Reservation_System.mdf;Integrated Security=True;Connect Timeout=30");
            if (currentGridView == "Flight Details")
            {
                AddFlightPanel aFF = new AddFlightPanel("Update", AP_Gridview_Display, flightListNo);
                aFF.Show();
            }
            else
            {
                MessageBox.Show("Currently Displaying " + currentGridView + " Table!!");
            }
        }

        private void AP_Gridview_Display_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Air_Reservation_DBDataContext aPD = new Air_Reservation_DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\documents\visual studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Air_Reservation.mdf;Integrated Security=True;Connect Timeout=30");
            Airline_Reservation_SystemDBCDataContext aPD = new Airline_Reservation_SystemDBCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\Visual Studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Airline_Reservation_System.mdf;Integrated Security=True;Connect Timeout=30");

            int index = e.RowIndex;
            selectedRow = AP_Gridview_Display.Rows[index];
            flightListNo = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
        }

        private void AP_Cancel_FS_Click(object sender, EventArgs e)
        {
            //Air_Reservation_DBDataContext aPD = new Air_Reservation_DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\documents\visual studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Air_Reservation.mdf;Integrated Security=True;Connect Timeout=30");
            Airline_Reservation_SystemDBCDataContext aPD = new Airline_Reservation_SystemDBCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\Visual Studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Airline_Reservation_System.mdf;Integrated Security=True;Connect Timeout=30");
            if (currentGridView == "Flight Details")
            {
                var x = from a in aPD.Flight_Details
                        where a.Flight_ID == flightListNo
                        select a;

                foreach (Flight_Detail p in x)
                {
                    aPD.Flight_Details.DeleteOnSubmit(p);
                }

                aPD.SubmitChanges();
                AP_Gridview_Display.DataSource = aPD.Flight_Details;
                AP_Gridview_Display.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else
            {
                MessageBox.Show("Currently Displaying " + currentGridView + " Table!!");
            }
        }

        private void AP_Search_Click(object sender, EventArgs e)
        {
            //Air_Reservation_DBDataContext aPD = new Air_Reservation_DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\documents\visual studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Air_Reservation.mdf;Integrated Security=True;Connect Timeout=30");
            Airline_Reservation_SystemDBCDataContext aPD = new Airline_Reservation_SystemDBCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\Visual Studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Airline_Reservation_System.mdf;Integrated Security=True;Connect Timeout=30");

            string searchS=APSearchBox.Text;

            if (currentGridView == "Flight Details")
            {
                var x = from a in aPD.Flight_Details
                        //where a.Flight_Name == APSearchBox.Text
                        where a.Flight_Name.Contains(APSearchBox.Text)
                            //|| a.Destination == APSearchBox.Text
                        || a.Destination.Contains(APSearchBox.Text)
                            //|| a.Departure == APSearchBox.Text
                        || a.Departure.Contains(APSearchBox.Text)
                            //|| a.Date == APSearchBox.Text
                        || a.Date.Contains(APSearchBox.Text)
                            //|| a.Time == APSearchBox.Text
                        || a.Time.Contains(APSearchBox.Text)
                        select a;

                if (x.Any())
                {
                    AP_Gridview_Display.DataSource = x.ToList();
                    AP_Gridview_Display.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                else
                {
                    MessageBox.Show("No such information stored in our database :/!");
                }
            }
            else if(currentGridView == "Ticket Booking Details")
            {
                var x = from a in aPD.TicketBooked_Infos
                        //where a.Flight_Name == APSearchBox.Text
                        where a.Flight_Name.Contains(APSearchBox.Text)
                            //|| a.Destination == APSearchBox.Text
                        || a.CName.Contains(APSearchBox.Text)
                            //|| a.Departure == APSearchBox.Text
                        || a.CID==Convert.ToInt32(APSearchBox.Text)
                            //|| a.Date == APSearchBox.Text
                        || a.Flight_ID.ToString()==APSearchBox.Text
                        select a;

                if (x.Any())
                {
                    AP_Gridview_Display.DataSource = x.ToList();
                    AP_Gridview_Display.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                else
                {
                    MessageBox.Show("No such information stored in our database :/!");
                }
            }
            else if(currentGridView == "Customer Information")
            {
                var x = from a in aPD.Customer_Infos
                        //where a.Flight_Name == APSearchBox.Text
                        where a.CName.Contains(APSearchBox.Text)
                            //|| a.Destination == APSearchBox.Text
                        || a.CNationality.Contains(APSearchBox.Text)
                            //|| a.Departure == APSearchBox.Text
                        || a.CPhone_Num.Contains(APSearchBox.Text)
                            //|| a.Date == APSearchBox.Text
                        || a.Card_Holder_Name.Contains(APSearchBox.Text)
                            //|| a.Time == APSearchBox.Text
                        || a.CEmail.Contains(APSearchBox.Text)
                        || a.CID.ToString() == APSearchBox.Text
                        select a;

                if (x.Any())
                {
                    AP_Gridview_Display.DataSource = x.ToList();
                    AP_Gridview_Display.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                else
                {
                    MessageBox.Show("No such information stored in our database :/!");
                }
            }

        }

        private void AP_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            alP.Show();
        }

        private void AP_CancelReservation_Click(object sender, EventArgs e)
        {
            Airline_Reservation_SystemDBCDataContext aPD = new Airline_Reservation_SystemDBCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\Visual Studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Airline_Reservation_System.mdf;Integrated Security=True;Connect Timeout=30");

            if(currentGridView == "Ticket Booking Details")
            {
                var x = from a in aPD.TicketBooked_Infos
                        where a.CID == flightListNo
                        select a;

                foreach (TicketBooked_Info p in x)
                {
                    aPD.TicketBooked_Infos.DeleteOnSubmit(p);
                }

                aPD.SubmitChanges();
                AP_Gridview_Display.DataSource = aPD.TicketBooked_Infos;
                AP_Gridview_Display.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }
    }
}
