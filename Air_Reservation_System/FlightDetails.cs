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
    public partial class Flight_Details : Form
    {
        //FlightDetails_TableDataContext fdt = new FlightDetails_TableDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\mzs munna\documents\visual studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Air_Reservation.mdf;Integrated Security=True;Connect Timeout=30");
        //Air_Reservation_DBDataContext fdt = new Air_Reservation_DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\visual studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Air_Reservation.mdf;Integrated Security=True;Connect Timeout=30");
        Airline_Reservation_SystemDBCDataContext fdt = new Airline_Reservation_SystemDBCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\Visual Studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Airline_Reservation_System.mdf;Integrated Security=True;Connect Timeout=30");

        int flightListNo=-1;
        int economyP = 0;
        int businessP = 0;
        int sEAvail = 0;
        int sBAvail = 0;
        Form mF;
        public Flight_Details()
        {
            InitializeComponent();
        }

        public Flight_Details(Form mF)
        {
            InitializeComponent();
            this.mF = mF;
        }

        private void Flight_Details_Load(object sender, EventArgs e)
        {
            FlightDetailsGridView.DataSource = fdt.Flight_Details;
            FlightDetailsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void FlightDetailsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = FlightDetailsGridView.Rows[index];
            flightListNo = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
            sEAvail = Convert.ToInt32(selectedRow.Cells[6].Value.ToString());
            sBAvail = Convert.ToInt32(selectedRow.Cells[7].Value.ToString());
            economyP = Convert.ToInt32(selectedRow.Cells[8].Value.ToString());
            businessP = Convert.ToInt32(selectedRow.Cells[9].Value.ToString());
        }

        private void FlightDetails_Next_Click(object sender, EventArgs e)
        {
            if(flightListNo>-1)
            {
                Seat_Booking sBF = new Seat_Booking(this,flightListNo,economyP,businessP,sEAvail,sBAvail);
                sBF.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select Anyone from the list to proceed!!!");
            }
        }

        private void Flight_Details_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            mF.Show();
        }

        private void FDB_Search_Button_Click(object sender, EventArgs e)
        {
            Airline_Reservation_SystemDBCDataContext fDD = new Airline_Reservation_SystemDBCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\Visual Studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Airline_Reservation_System.mdf;Integrated Security=True;Connect Timeout=30");

            string searchS = Flight_Booking_SearchBox.Text;

            var x = from a in fDD.Flight_Details
                    //where a.Flight_Name == APSearchBox.Text
                    where a.Flight_Name.Contains(Flight_Booking_SearchBox.Text)
                        //|| a.Destination == APSearchBox.Text
                    || a.Destination.Contains(Flight_Booking_SearchBox.Text)
                        //|| a.Departure == APSearchBox.Text
                    || a.Departure.Contains(Flight_Booking_SearchBox.Text)
                        //|| a.Date == APSearchBox.Text
                    || a.Date.Contains(Flight_Booking_SearchBox.Text)
                        //|| a.Time == APSearchBox.Text
                    || a.Time.Contains(Flight_Booking_SearchBox.Text)
                    select a;

            if (x.Any())
            {
                FlightDetailsGridView.DataSource = x.ToList();
                FlightDetailsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else
            {
                MessageBox.Show("No such result available!! :/");
            }
        }

        private void Refresh_Display_Click(object sender, EventArgs e)
        {
            Airline_Reservation_SystemDBCDataContext fdt = new Airline_Reservation_SystemDBCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\Visual Studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Airline_Reservation_System.mdf;Integrated Security=True;Connect Timeout=30");

            FlightDetailsGridView.DataSource = fdt.Flight_Details;
            FlightDetailsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
