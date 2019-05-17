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
    public partial class CustomerLoginPanel : Form
    {
        //Air_Reservation_DBDataContext uLD = new Air_Reservation_DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\documents\visual studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Air_Reservation.mdf;Integrated Security=True;Connect Timeout=30");
        Airline_Reservation_SystemDBCDataContext uLD = new Airline_Reservation_SystemDBCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\Visual Studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Airline_Reservation_System.mdf;Integrated Security=True;Connect Timeout=30");
       //int userID = 12;
        int userID = 0;
        public CustomerLoginPanel()
        {
            InitializeComponent();
        }

        private void USR_Login_Button_Click(object sender, EventArgs e)
        {
            Airline_Reservation_SystemDBCDataContext uLD = new Airline_Reservation_SystemDBCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\Visual Studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Airline_Reservation_System.mdf;Integrated Security=True;Connect Timeout=30");


             var x = from a in uLD.Customer_Infos
                     where a.CName == USR_UNBox.Text
                     //|| a.CEmail == USR_UNBox.Text
                     && a.CPassword == USR_PassBox.Text
                    select a;

            if (x.Any())
            {
                userID=x.First().CID;
                MessageBox.Show("Login Success!");
                UserHome uHP = new UserHome(this, userID);
                uHP.Show();
                this.Hide();
                //AdminPanel alp = new AdminPanel(this);
                //this.Hide();
                //alp.Show();

            }
            else
            {
                MessageBox.Show("Login Failed!");
            }
        }

        private void USR_Reg_Click(object sender, EventArgs e)
        {

        }

        private void USR_UNBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
