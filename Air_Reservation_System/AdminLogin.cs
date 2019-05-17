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
    public partial class AdminLogin : Form
    {
        //Air_Reservation_DBDataContext aLD = new Air_Reservation_DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\documents\visual studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Air_Reservation.mdf;Integrated Security=True;Connect Timeout=30");
        Airline_Reservation_SystemDBCDataContext aLD = new Airline_Reservation_SystemDBCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mzs Munna\Documents\Visual Studio 2013\Projects\Air_Reservation_System\Air_Reservation_System\Airline_Reservation_System.mdf;Integrated Security=True;Connect Timeout=30");

        public AdminLogin()
        {                            
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void AL_Login_Button_Click(object sender, EventArgs e)
        {
            var x = from a in aLD.Admins
                    where a.Admin_Name == AL_UNBox.Text
                    && a.Admin_Password==AL_PassBox.Text
                    select a;

            if(x.Any())
            {
                MessageBox.Show("Login Success!");
                AdminPanel alp = new AdminPanel(this);
                this.Hide();
                alp.Show();

            }
            else
            {
                MessageBox.Show("Login Failed!");
            }
        }
    }
}
